using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using Moq;
using SoG_SGreader.Wrapper;

namespace SoG_SGreader.Test
{
    public class DataReaderTests
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

            return DataReader.ReadFromFile(filePath, fakeTextBox);
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
            yield return new object[] { 40, GetSaveGame(0) };
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
                    ItemID = SogItem.Usable_CardAlbum, 
                    ItemCount = 1, 
                    ItemPos = 189755
            }, GetSaveGame(0).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.KeyItem_DivaMirror,
                    ItemCount = 0, 
                    ItemPos = 158319
                }, GetSaveGame(1).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.Usable_CardAlbum,
                    ItemCount = 1, 
                    ItemPos = 46623
            }, GetSaveGame(2).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.Usable_CardAlbum,
                    ItemCount = 1, 
                    ItemPos = 16756
            }, GetSaveGame(3).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.Usable_CardAlbum,
                    ItemCount = 1, 
                    ItemPos = 25026
            }, GetSaveGame(4).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.Usable_CardAlbum,
                    ItemCount = 1, 
                    ItemPos = 18895
            }, GetSaveGame(5).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.Usable_CardAlbum,
                    ItemCount = 1, 
                    ItemPos = 16634
            }, GetSaveGame(6).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.Usable_CardAlbum,
                    ItemCount = 1, 
                    ItemPos = 14455
            }, GetSaveGame(7).Inventory };
            
            yield return new object[] { 
                new Item{
                    ItemID = SogItem.Usable_CardAlbum,
                    ItemCount = 1, 
                    ItemPos = 96617
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
                    ItemID = SogItem.Furniture_Decoration_ArcadeChallengeTrophyF08, 
                    ItemCount = 1, 
                    ItemPos = 189760 
            }, GetSaveGame(0).Inventory };
            
            yield return new object[] { 
                new Item {
                    ItemID = SogItem.KeyItem_CatalystOfPower, 
                    ItemCount = 1, 
                    ItemPos = 159243
            }, GetSaveGame(1).Inventory };
            
            yield return new object[] { 
                new Item {
                    ItemID = SogItem.KeyItem_CatalystOfPower,
                    ItemCount = 1,
                    ItemPos = 46457 
            }, GetSaveGame(2).Inventory };
            
            yield return new object[] { 
                new Item {
                    ItemID = SogItem.Shoes_MushroomSlippers, 
                    ItemCount = 1, 
                    ItemPos = 16738}, 
            GetSaveGame(3).Inventory };
            
            yield return new object[] { 
                new Item {
                    ItemID = SogItem.TwoHanded_BugNet, 
                    ItemCount = 0, 
                    ItemPos = 25025
            }, GetSaveGame(4).Inventory };
            
            yield return new object[] { 
                new Item {
                    ItemID = SogItem.TwoHanded_BugNet, 
                    ItemCount = 0, 
                    ItemPos = 18894}, 
            GetSaveGame(5).Inventory };
            
            yield return new object[] { 
                new Item {
                    ItemID = SogItem.Furniture_Carpet_MasterHQRed, 
                    ItemCount = 0, 
                    ItemPos = 16614}, 
            GetSaveGame(6).Inventory };
            
            yield return new object[] { 
                new Item {
                    ItemID = SogItem.TwoHanded_BugNet, 
                    ItemCount = 0, 
                    ItemPos =14454}, 
            GetSaveGame(7).Inventory };
            
            yield return new object[] { 
                new Item {
                        ItemID = SogItem.OneHanded_UgrasScroll, 
                        ItemCount = 1, 
                        ItemPos =96375
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