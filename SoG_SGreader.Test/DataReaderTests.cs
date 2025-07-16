using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using Moq;
using SoG_SGreader.Wrapper;
using SoG_SGreader;

namespace SoG_SGreader.Test
{
    public class SaveGameSerializerTests
    {
        private static List<Player> players = new List<Player>();

        private static Player GetSaveGame(int saveGameNumber)
        {
            var fakeTextBox = new FakeTextBox();
            
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

            // Exception for GitHub Actions Test Runner
            if (Environment.GetEnvironmentVariable("GITHUB_WORKSPACE") != null) {
                projectDirectory = Environment.GetEnvironmentVariable("GITHUB_WORKSPACE");
            }
            else if (Environment.OSVersion.Platform != PlatformID.Unix)
            {
                projectDirectory = Path.Combine(projectDirectory, "SoG_SGreader");
            }

            string filePath = Path.Combine(projectDirectory, "SoG_SGreader.Test", "SaveGames", saveGameNumber + ".cha");

            return SaveGameSerializer.Deserialize(filePath, fakeTextBox);
        }

        private static IEnumerable<object[]> Nicknames()
        {
            yield return new object[] { "Miseris", GetSaveGame(0) };
            yield return new object[] { "Chang", GetSaveGame(1) };
            yield return new object[] { "Supportia", GetSaveGame(2) };
            yield return new object[] { "Etherious", GetSaveGame(3) };
            yield return new object[] { "Zima", GetSaveGame(4) };
            yield return new object[] { "Magma", GetSaveGame(5) };
            yield return new object[] { "Zakwit", GetSaveGame(6) };
            yield return new object[] { "Bryza", GetSaveGame(7) };
            yield return new object[] { "Eiroth", GetSaveGame(8) };
        }

        [Theory]
        [MemberData(nameof(Nicknames))]
        private void TestCanReadNickname(string nickname, Player player)
        {
            Assert.Equal(nickname, player.Nickname);
        }
        
        private static IEnumerable<object[]> Levels()
        {
            yield return new object[] { 41, GetSaveGame(0) };
            yield return new object[] { 32, GetSaveGame(1) };
            yield return new object[] { 34, GetSaveGame(2) };
            yield return new object[] { 32, GetSaveGame(3) };
            yield return new object[] { 40, GetSaveGame(4) };
            yield return new object[] { 31, GetSaveGame(5) };
            yield return new object[] { 34, GetSaveGame(6) };
            yield return new object[] { 30, GetSaveGame(7) };
            yield return new object[] { 34, GetSaveGame(8) };
        }

        [Theory]
        [MemberData(nameof(Levels))]
        private void TestCanReadLevel(short level, Player player)
        {
            Assert.Equal(level, player.Level);
        }
        
        private static IEnumerable<object[]> Birthdays()
        {
            yield return new object[] { 23, 11, GetSaveGame(0) };
            yield return new object[] { 24, 06, GetSaveGame(1) };
            yield return new object[] { 03, 11, GetSaveGame(2) };
            yield return new object[] { 27, 05, GetSaveGame(3) };
            yield return new object[] { 20, 02, GetSaveGame(4) };
            yield return new object[] { 26, 07, GetSaveGame(5) };
            yield return new object[] { 10, 04, GetSaveGame(6) };
            yield return new object[] { 12, 11, GetSaveGame(7) };
            yield return new object[] { 05, 05, GetSaveGame(8) };
        }

        [Theory]
        [MemberData(nameof(Birthdays))]
        private void TestCanReadBirthday(int birthdayDay, int birthdayMonth, Player player)
        {
            Assert.Equal(birthdayDay, player.BirthdayDay);
            Assert.Equal(birthdayMonth, player.BirthdayMonth);
        }
        
        private static IEnumerable<object[]> FirstItem()
        {
            yield return new object[] { 
                new Item {
                    ID = SogItem.Usable_CardAlbum, 
                    Count = 1, 
                    Position = 210623
            }, GetSaveGame(0).Inventory };

            yield return new object[] { 
                new Item{
                    ID = SogItem.KeyItem_DivaMirror,
                    Count = 0, 
                    Position = 159257
                }, GetSaveGame(1).Inventory };
            
            yield return new object[] { 
                new Item{
                    ID = SogItem.Usable_CardAlbum,
                    Count = 1,
                    Position = 46639
            }, GetSaveGame(2).Inventory };
            
            yield return new object[] { 
                new Item{
                    ID = SogItem.Usable_CardAlbum,
                    Count = 1,
                    Position = 16766
            }, GetSaveGame(3).Inventory };
            
            yield return new object[] { 
                new Item{
                    ID = SogItem.Usable_CardAlbum,
                    Count = 1,
                    Position = 25043
            }, GetSaveGame(4).Inventory };
            
            yield return new object[] { 
                new Item{
                    ID = SogItem.Usable_CardAlbum,
                    Count = 1,
                    Position = 18912
            }, GetSaveGame(5).Inventory };
            
            yield return new object[] { 
                new Item{
                    ID = SogItem.Usable_CardAlbum,
                    Count = 1, 
                    Position = 16649
            }, GetSaveGame(6).Inventory };
            
            yield return new object[] { 
                new Item{
                    ID = SogItem.Usable_CardAlbum,
                    Count = 1, 
                    Position = 14526
            }, GetSaveGame(7).Inventory };

            yield return new object[] { 
                new Item{
                    ID = SogItem.Usable_CardAlbum,
                    Count = 1, 
                    Position = 96648
            }, GetSaveGame(8).Inventory };
        }

        [Theory]
        [MemberData(nameof(FirstItem))]
        private void TestCanGetFirstItemFromInventory(Item firstItem, List<Item> inventory)
        {
            Assert.Equal(firstItem, inventory[0]);
        }
        
        private static IEnumerable<object[]> LastItem()
        {
            yield return new object[] { 
                new Item {
                    ID = SogItem.KeyItem_KailansID, 
                    Count = 0, 
                    Position = 210618
            }, GetSaveGame(0).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.KeyItem_KailansID, 
                    Count = 0, 
                    Position = 159258
            }, GetSaveGame(1).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.TwoHanded_BugNet,
                    Count = 0,
                    Position = 46638
            }, GetSaveGame(2).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.TwoHanded_BugNet, 
                    Count = 0, 
                    Position = 16765}, 
            GetSaveGame(3).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.Usable_CardSummoner, 
                    Count = 1, 
                    Position = 25045
            }, GetSaveGame(4).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.KeyItem_KailansID, 
                    Count = 0, 
                    Position = 18907}, 
            GetSaveGame(5).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.KeyItem_KailansID, 
                    Count = 0, 
                    Position = 16644}, 
            GetSaveGame(6).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.KeyItem_KailansID, 
                    Count = 1, 
                    Position = 14521}, 
            GetSaveGame(7).Inventory };
            
            yield return new object[] { 
                new Item {
                    ID = SogItem.Hat_Kiwi, 
                    Count = 1, 
                    Position = 96650
            }, GetSaveGame(8).Inventory };
        }

        [Theory]
        [MemberData(nameof(LastItem))]
        private void TestCanGetLastItemFromInventory(Item lastItem, List<Item> inventory)
        {
            Assert.Equal(lastItem, inventory.Last());
        }
    }
}