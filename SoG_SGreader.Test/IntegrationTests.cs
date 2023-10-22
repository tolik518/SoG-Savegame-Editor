using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace SoG_SGreader.Test
{
    public class IntegrationTests
    {
        private static string GetExePath()
        {
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

            // Exception for GitHub Actions Test Runner
            if (Environment.GetEnvironmentVariable("GITHUB_WORKSPACE") != null) {
                projectDirectory = Environment.GetEnvironmentVariable("GITHUB_WORKSPACE");
                return Path.Combine(projectDirectory, "SoG_SGreader", "bin", "Release", "SoG_SGreader.exe");
            }
            
            return Path.Combine(projectDirectory, "SoG_SGreader", "bin", "Debug", "SoG_SGreader.exe");
        }
        
        private static string GetSaveGamePath(string saveGameNumber)
        {
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

            // Exception for GitHub Actions Test Runner
            if (Environment.GetEnvironmentVariable("GITHUB_WORKSPACE") != null) {
                projectDirectory = Environment.GetEnvironmentVariable("GITHUB_WORKSPACE");
            }
            
            return Path.Combine(projectDirectory, "SoG_SGreader.Test", "SaveGames", saveGameNumber + ".cha");
        }
        
        [Fact]
        public void TestBadPath()
        {
            string arguments = "-t " + GetSaveGamePath("doesntexist");

            // Start the process
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = GetExePath(),
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            
            Assert.Contains("Could not find file", output);
            Assert.Contains(Path.Combine("SaveGames", "doesntexist.cha"), output);
        }

        [Fact]
        public void TestTextOutput()
        {
            string arguments = "-t " + GetSaveGamePath("1");

            // Start the process
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = GetExePath(),
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            
            Assert.Contains("Filesize: 4494", output);
            Assert.Contains("Birthday: 24.6.1081", output);
            Assert.Contains("ItemsMetCount: 124", output);
            Assert.Contains("KilledEnemiesCount: 58", output);
        }
        
        [Fact]
        public void TestJsonOutput()
        {
            string arguments = "-j " + GetSaveGamePath("1");

            // Start the process
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = GetExePath(),
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            
            Assert.Contains("\"MagicByte\": 116", output);
            Assert.Contains("\"PlayTimeTotal\": 1645950", output);
            Assert.Contains("\"UniquePlayerId\": 451873", output);
            Assert.Contains("\"Cash\": 6873538", output);
        }
        
        [Fact]
        public void TestPatchOutput()
        {
            string arguments = "--patch";

            // Start the process
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = GetExePath(),
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            
            Assert.Contains(FrmMain.CurrentPatch, output);
        }
    }
}