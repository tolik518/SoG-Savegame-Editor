using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Moq;

namespace SoG_SGreader.Test
{
    public class ReaderTests
    {
        private static Player ReadSaveGame(string saveGameNumber)
        {
            DataReader dataReader = new DataReader();
            var txtConsoleMock = new Mock<ITextBoxWrapper>();
        
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "SaveGames", saveGameNumber + ".cha");
            
            return dataReader.ReadFromFile(filePath, txtConsoleMock.Object);
        }

        private static IEnumerable<object[]> GetNicknames()
        {
            yield return new object[] { "Miseris", ReadSaveGame("0") };
            yield return new object[] { "Chang", ReadSaveGame("1") };
            yield return new object[] { "Supportia", ReadSaveGame("2") };
            yield return new object[] { "Etherious", ReadSaveGame("3") };
            yield return new object[] { "Zima", ReadSaveGame("4") };
            yield return new object[] { "Magma", ReadSaveGame("5") };
            yield return new object[] { "Zakwit", ReadSaveGame("6") };
            yield return new object[] { "Bryza", ReadSaveGame("7") };
            yield return new object[] { "Eiroth", ReadSaveGame("8") };
        }

        [Theory]
        [MemberData(nameof(GetNicknames))]
        private void TestCanReadNickname(string nickname, Player player)
        {
            Assert.Equal(nickname, player.Nickname);
        }
    }
}