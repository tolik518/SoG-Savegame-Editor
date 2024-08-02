using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SoG_SGreader
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTrophiesNullWarning = new System.Windows.Forms.TabControl();
            this.tabChar = new System.Windows.Forms.TabPage();
            this.grpPatch = new System.Windows.Forms.GroupBox();
            this.lblGamePatch = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblTimePlayed = new System.Windows.Forms.Label();
            this.lblCollectorId = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.numBirtdayMonth = new System.Windows.Forms.NumericUpDown();
            this.numBirthdayDay = new System.Windows.Forms.NumericUpDown();
            this.txtTimePlayed = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.grpEquipped = new System.Windows.Forms.GroupBox();
            this.lblAccessory2 = new System.Windows.Forms.Label();
            this.lblAccessory1 = new System.Windows.Forms.Label();
            this.lblShoes = new System.Windows.Forms.Label();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblShield = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.lblFacegear = new System.Windows.Forms.Label();
            this.lblHat = new System.Windows.Forms.Label();
            this.cbAccessory2 = new System.Windows.Forms.ComboBox();
            this.cbAccessory1 = new System.Windows.Forms.ComboBox();
            this.cbShoes = new System.Windows.Forms.ComboBox();
            this.cbArmor = new System.Windows.Forms.ComboBox();
            this.cbShield = new System.Windows.Forms.ComboBox();
            this.cbWeapon = new System.Windows.Forms.ComboBox();
            this.cbFacegear = new System.Windows.Forms.ComboBox();
            this.cbHat = new System.Windows.Forms.ComboBox();
            this.grpEquippedStyle = new System.Windows.Forms.GroupBox();
            this.lblEqShield = new System.Windows.Forms.Label();
            this.cbStyleShield = new System.Windows.Forms.ComboBox();
            this.lblEqWeapon = new System.Windows.Forms.Label();
            this.cbStyleHat = new System.Windows.Forms.ComboBox();
            this.lblEqFacegear = new System.Windows.Forms.Label();
            this.cbStyleFacegear = new System.Windows.Forms.ComboBox();
            this.lblEqHat = new System.Windows.Forms.Label();
            this.cbStyleWeapon = new System.Windows.Forms.ComboBox();
            this.grpSkillpoints = new System.Windows.Forms.GroupBox();
            this.numSkillTalentPoints = new System.Windows.Forms.NumericUpDown();
            this.lblGoldPoints = new System.Windows.Forms.Label();
            this.numSkillSilverPoints = new System.Windows.Forms.NumericUpDown();
            this.numSkillGoldPoints = new System.Windows.Forms.NumericUpDown();
            this.lblSilverPoints = new System.Windows.Forms.Label();
            this.lblTalentPoints = new System.Windows.Forms.Label();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.lblExpUnknown1 = new System.Windows.Forms.Label();
            this.lblExpUnknown0 = new System.Windows.Forms.Label();
            this.lblCurrectExp = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.numEXPUnknown1 = new System.Windows.Forms.NumericUpDown();
            this.numEXPUnknown0 = new System.Windows.Forms.NumericUpDown();
            this.numEXPcurrent = new System.Windows.Forms.NumericUpDown();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.lblPants = new System.Windows.Forms.Label();
            this.lblShirt = new System.Windows.Forms.Label();
            this.lblPoncho = new System.Windows.Forms.Label();
            this.lblSkin = new System.Windows.Forms.Label();
            this.btnPantsColor = new System.Windows.Forms.Button();
            this.btnShirtColor = new System.Windows.Forms.Button();
            this.btnPonchoColor = new System.Windows.Forms.Button();
            this.btnSkinColor = new System.Windows.Forms.Button();
            this.btnHairColor = new System.Windows.Forms.Button();
            this.lblHair = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.numGold = new System.Windows.Forms.NumericUpDown();
            this.lblGold = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectedItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.numItemCount = new System.Windows.Forms.NumericUpDown();
            this.cbSelectedItem = new System.Windows.Forms.ComboBox();
            this.lstInventory = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPets = new System.Windows.Forms.TabPage();
            this.lstPets = new System.Windows.Forms.ListView();
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dmg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Crit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpPet = new System.Windows.Forms.GroupBox();
            this.cbPetType = new System.Windows.Forms.ComboBox();
            this.lblPetType = new System.Windows.Forms.Label();
            this.numPetLevel = new System.Windows.Forms.NumericUpDown();
            this.lblPetLevel = new System.Windows.Forms.Label();
            this.lblPetSpeed = new System.Windows.Forms.Label();
            this.lblPetCrit = new System.Windows.Forms.Label();
            this.lblPetDamage = new System.Windows.Forms.Label();
            this.lblPetEnergy = new System.Windows.Forms.Label();
            this.lblPetNickname = new System.Windows.Forms.Label();
            this.txtPetNickname = new System.Windows.Forms.TextBox();
            this.lblPetHealth = new System.Windows.Forms.Label();
            this.numPetSpeed = new System.Windows.Forms.NumericUpDown();
            this.numPetCrit = new System.Windows.Forms.NumericUpDown();
            this.numPetDamage = new System.Windows.Forms.NumericUpDown();
            this.numPetEnergy = new System.Windows.Forms.NumericUpDown();
            this.numPetHP = new System.Windows.Forms.NumericUpDown();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSkillsMelee = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.numSkillMelee2h4 = new System.Windows.Forms.NumericUpDown();
            this.numSkillMelee2h3 = new System.Windows.Forms.NumericUpDown();
            this.numSkillMelee2h2 = new System.Windows.Forms.NumericUpDown();
            this.numSkillMelee2h1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.numSkillMelee2h0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.numSkillMelee1h1 = new System.Windows.Forms.NumericUpDown();
            this.numSkillMelee1h0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numSkillMelee1h2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.numSkillMelee1h3 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.numSkillMelee1h4 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabSkillsMagic = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.numSkillMagicA2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicA1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicA0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.numSkillMagicE2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicE1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicE0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.numSkillMagicI2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicI1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicI0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numSkillMagicF2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicF1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.numSkillMagicF0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.tabSkillsUtility = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.numUtilityE0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.numUtilityE1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.numUtilityE2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.numUtilityD0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.numUtilityD1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.numUtilityD2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.numUtilityO0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.numUtilityO1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.numUtilityO2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.tabTalentsMelee = new System.Windows.Forms.TabPage();
            this.tabTalentsMagic = new System.Windows.Forms.TabPage();
            this.tabTalentsGeneral = new System.Windows.Forms.TabPage();
            this.tabCards = new System.Windows.Forms.TabPage();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.lblCardsNullWarning = new System.Windows.Forms.Label();
            this.btnSelectAllCards = new System.Windows.Forms.Button();
            this.btnResetCards = new System.Windows.Forms.Button();
            this.btnDeselectAllCards = new System.Windows.Forms.Button();
            this.cblstCards = new System.Windows.Forms.CheckedListBox();
            this.tabMaps = new System.Windows.Forms.TabPage();
            this.grpMaps = new System.Windows.Forms.GroupBox();
            this.lblMapsNullWarning = new System.Windows.Forms.Label();
            this.btnSelectAllMaps = new System.Windows.Forms.Button();
            this.btnResetMaps = new System.Windows.Forms.Button();
            this.btnDeselectAllMaps = new System.Windows.Forms.Button();
            this.cblstMaps = new System.Windows.Forms.CheckedListBox();
            this.tabQuests = new System.Windows.Forms.TabPage();
            this.grpQuests = new System.Windows.Forms.GroupBox();
            this.lblQuestsChaningNoEffect = new System.Windows.Forms.Label();
            this.lblQuestsNullWarning = new System.Windows.Forms.Label();
            this.btnSelectAllQuests = new System.Windows.Forms.Button();
            this.btnResetQuests = new System.Windows.Forms.Button();
            this.btnDeselectAllQuests = new System.Windows.Forms.Button();
            this.cblstQuests = new System.Windows.Forms.CheckedListBox();
            this.tabFlags = new System.Windows.Forms.TabPage();
            this.cblstFlagsChecked = new System.Windows.Forms.CheckedListBox();
            this.grpFlags = new System.Windows.Forms.GroupBox();
            this.lblFlagsChaningNoEffect = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btnSelectAllFlags = new System.Windows.Forms.Button();
            this.btnResetFlags = new System.Windows.Forms.Button();
            this.btnDeselectAllFlags = new System.Windows.Forms.Button();
            this.cblstFlags = new System.Windows.Forms.CheckedListBox();
            this.tabTrophies = new System.Windows.Forms.TabPage();
            this.grpTrophies = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.btnSelectAllTrophies = new System.Windows.Forms.Button();
            this.btnResetTrophies = new System.Windows.Forms.Button();
            this.btnDeselectAllTrophies = new System.Windows.Forms.Button();
            this.cblstTrophies = new System.Windows.Forms.CheckedListBox();
            this.tabFishCaught = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFishNullWarning = new System.Windows.Forms.Label();
            this.btnSelectAllFishCaught = new System.Windows.Forms.Button();
            this.btnResetFishCaught = new System.Windows.Forms.Button();
            this.btnDeselectAllFishCaught = new System.Windows.Forms.Button();
            this.cblstFishCaught = new System.Windows.Forms.CheckedListBox();
            this.tabEnemiesSeen = new System.Windows.Forms.TabPage();
            this.grpEnemiesSeen = new System.Windows.Forms.GroupBox();
            this.lblEnemiesSeenNullWarning = new System.Windows.Forms.Label();
            this.btnSelectAllEnemiesSeen = new System.Windows.Forms.Button();
            this.btnResetEnemiesSeen = new System.Windows.Forms.Button();
            this.btnDeselectAllEnemiesSeen = new System.Windows.Forms.Button();
            this.cblstEnemiesSeens = new System.Windows.Forms.CheckedListBox();
            this.tabItemsSeen = new System.Windows.Forms.TabPage();
            this.grpItemsSeen = new System.Windows.Forms.GroupBox();
            this.lblItemsSeenNullWarning = new System.Windows.Forms.Label();
            this.btnSelectAllItemsSeen = new System.Windows.Forms.Button();
            this.btnResetItemsSeen = new System.Windows.Forms.Button();
            this.btnDeselectAllItemsSeen = new System.Windows.Forms.Button();
            this.cblstItemsSeen = new System.Windows.Forms.CheckedListBox();
            this.tabItemsCrafted = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblItemsCraftedNullWarning = new System.Windows.Forms.Label();
            this.btnSelectAllItemsCrafted = new System.Windows.Forms.Button();
            this.btnResetItemsCrafted = new System.Windows.Forms.Button();
            this.btnDeselectAllItemsCrafted = new System.Windows.Forms.Button();
            this.cblstItemsCrafted = new System.Windows.Forms.CheckedListBox();
            this.tabQuickslots = new System.Windows.Forms.TabPage();
            this.label57 = new System.Windows.Forms.Label();
            this.grpQuickslots = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavegameFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.Tooltips = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numTalentMelee13 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMelee8 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee14 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMelee9 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee10 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMelee5 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee11 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMelee6 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee12 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMelee7 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee3 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee4 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.numTalentMelee2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numTalentMagic13 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMagic8 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic14 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMagic9 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic10 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMagic5 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic11 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMagic6 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic12 = new System.Windows.Forms.NumericUpDown();
            this.numTalentMagic7 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic3 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic4 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.numTalentMagic2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numTalentGeneral0 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral5 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral4 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral3 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral6 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral14 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral7 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral13 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral12 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral11 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral10 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral9 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral8 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox77 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral20 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral19 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral18 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral17 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral16 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.numTalentGeneral15 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.lblTrophiesNullWarning.SuspendLayout();
            this.tabChar.SuspendLayout();
            this.grpPatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirtdayMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthdayDay)).BeginInit();
            this.grpEquipped.SuspendLayout();
            this.grpEquippedStyle.SuspendLayout();
            this.grpSkillpoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTalentPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillSilverPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillGoldPoints)).BeginInit();
            this.grpLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEXPUnknown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEXPUnknown0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEXPcurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            this.grpColors.SuspendLayout();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGold)).BeginInit();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).BeginInit();
            this.tabPets.SuspendLayout();
            this.grpPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPetLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetHP)).BeginInit();
            this.tabSkills.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSkillsMelee.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabSkillsMagic.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicA0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicE0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicI0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicF0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.tabSkillsUtility.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityE0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityD0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityO0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            this.tabTalentsMelee.SuspendLayout();
            this.tabTalentsMagic.SuspendLayout();
            this.tabTalentsGeneral.SuspendLayout();
            this.tabCards.SuspendLayout();
            this.grpCards.SuspendLayout();
            this.tabMaps.SuspendLayout();
            this.grpMaps.SuspendLayout();
            this.tabQuests.SuspendLayout();
            this.grpQuests.SuspendLayout();
            this.tabFlags.SuspendLayout();
            this.grpFlags.SuspendLayout();
            this.tabTrophies.SuspendLayout();
            this.grpTrophies.SuspendLayout();
            this.tabFishCaught.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabEnemiesSeen.SuspendLayout();
            this.grpEnemiesSeen.SuspendLayout();
            this.tabItemsSeen.SuspendLayout();
            this.grpItemsSeen.SuspendLayout();
            this.tabItemsCrafted.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabQuickslots.SuspendLayout();
            this.grpQuickslots.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrophiesNullWarning
            // 
            this.lblTrophiesNullWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrophiesNullWarning.Controls.Add(this.tabChar);
            this.lblTrophiesNullWarning.Controls.Add(this.tabInventory);
            this.lblTrophiesNullWarning.Controls.Add(this.tabPets);
            this.lblTrophiesNullWarning.Controls.Add(this.tabSkills);
            this.lblTrophiesNullWarning.Controls.Add(this.tabCards);
            this.lblTrophiesNullWarning.Controls.Add(this.tabMaps);
            this.lblTrophiesNullWarning.Controls.Add(this.tabQuests);
            this.lblTrophiesNullWarning.Controls.Add(this.tabFlags);
            this.lblTrophiesNullWarning.Controls.Add(this.tabTrophies);
            this.lblTrophiesNullWarning.Controls.Add(this.tabFishCaught);
            this.lblTrophiesNullWarning.Controls.Add(this.tabEnemiesSeen);
            this.lblTrophiesNullWarning.Controls.Add(this.tabItemsSeen);
            this.lblTrophiesNullWarning.Controls.Add(this.tabItemsCrafted);
            this.lblTrophiesNullWarning.Controls.Add(this.tabQuickslots);
            this.lblTrophiesNullWarning.Location = new System.Drawing.Point(0, 37);
            this.lblTrophiesNullWarning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTrophiesNullWarning.Name = "lblTrophiesNullWarning";
            this.lblTrophiesNullWarning.SelectedIndex = 0;
            this.lblTrophiesNullWarning.Size = new System.Drawing.Size(850, 649);
            this.lblTrophiesNullWarning.TabIndex = 0;
            // 
            // tabChar
            // 
            this.tabChar.Controls.Add(this.grpPatch);
            this.tabChar.Controls.Add(this.numID);
            this.tabChar.Controls.Add(this.grpGeneral);
            this.tabChar.Controls.Add(this.label49);
            this.tabChar.Controls.Add(this.grpEquipped);
            this.tabChar.Controls.Add(this.grpEquippedStyle);
            this.tabChar.Controls.Add(this.grpSkillpoints);
            this.tabChar.Controls.Add(this.grpLevel);
            this.tabChar.Controls.Add(this.grpColors);
            this.tabChar.Location = new System.Drawing.Point(4, 29);
            this.tabChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabChar.Name = "tabChar";
            this.tabChar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabChar.Size = new System.Drawing.Size(842, 616);
            this.tabChar.TabIndex = 3;
            this.tabChar.Text = "Character / Equip";
            this.tabChar.UseVisualStyleBackColor = true;
            // 
            // grpPatch
            // 
            this.grpPatch.BackColor = System.Drawing.Color.Transparent;
            this.grpPatch.Controls.Add(this.lblGamePatch);
            this.grpPatch.Controls.Add(this.label55);
            this.grpPatch.Location = new System.Drawing.Point(254, 243);
            this.grpPatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPatch.Name = "grpPatch";
            this.grpPatch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPatch.Size = new System.Drawing.Size(158, 354);
            this.grpPatch.TabIndex = 54;
            this.grpPatch.TabStop = false;
            // 
            // lblGamePatch
            // 
            this.lblGamePatch.AutoSize = true;
            this.lblGamePatch.Location = new System.Drawing.Point(20, 178);
            this.lblGamePatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamePatch.Name = "lblGamePatch";
            this.lblGamePatch.Size = new System.Drawing.Size(114, 20);
            this.lblGamePatch.TabIndex = 1;
            this.lblGamePatch.Text = "[Game 0.000a]";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(20, 152);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(102, 20);
            this.label55.TabIndex = 0;
            this.label55.Text = "[Patch 1.03a]";
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(118, 75);
            this.numID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numID.Maximum = new decimal(new int[] {
            -2,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(112, 26);
            this.numID.TabIndex = 53;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.rbFemale);
            this.grpGeneral.Controls.Add(this.lblGender);
            this.grpGeneral.Controls.Add(this.rbMale);
            this.grpGeneral.Controls.Add(this.lblTimePlayed);
            this.grpGeneral.Controls.Add(this.lblCollectorId);
            this.grpGeneral.Controls.Add(this.txtNickname);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.lblBirthday);
            this.grpGeneral.Controls.Add(this.numBirtdayMonth);
            this.grpGeneral.Controls.Add(this.numBirthdayDay);
            this.grpGeneral.Controls.Add(this.txtTimePlayed);
            this.grpGeneral.Location = new System.Drawing.Point(9, 6);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGeneral.Size = new System.Drawing.Size(236, 228);
            this.grpGeneral.TabIndex = 52;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(162, 195);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(50, 24);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "♀";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(8, 194);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 52;
            this.lblGender.Text = "Gender:";
            this.Tooltips.SetToolTip(this.lblGender, "Day / Month");
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(110, 195);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 24);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "♂";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblTimePlayed
            // 
            this.lblTimePlayed.AutoSize = true;
            this.lblTimePlayed.Location = new System.Drawing.Point(8, 115);
            this.lblTimePlayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimePlayed.Name = "lblTimePlayed";
            this.lblTimePlayed.Size = new System.Drawing.Size(97, 20);
            this.lblTimePlayed.TabIndex = 44;
            this.lblTimePlayed.Text = "Time played:";
            this.Tooltips.SetToolTip(this.lblTimePlayed, "D:HH:MM:SS");
            // 
            // lblCollectorId
            // 
            this.lblCollectorId.AutoSize = true;
            this.lblCollectorId.Location = new System.Drawing.Point(8, 74);
            this.lblCollectorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCollectorId.Name = "lblCollectorId";
            this.lblCollectorId.Size = new System.Drawing.Size(96, 20);
            this.lblCollectorId.TabIndex = 51;
            this.lblCollectorId.Text = "Collector ID:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(70, 29);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(150, 26);
            this.txtNickname.TabIndex = 34;
            this.txtNickname.Text = "tolik518";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(8, 154);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(71, 20);
            this.lblBirthday.TabIndex = 49;
            this.lblBirthday.Text = "Birthday:";
            this.Tooltips.SetToolTip(this.lblBirthday, "Day / Month");
            // 
            // numBirtdayMonth
            // 
            this.numBirtdayMonth.Location = new System.Drawing.Point(170, 151);
            this.numBirtdayMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBirtdayMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numBirtdayMonth.Name = "numBirtdayMonth";
            this.numBirtdayMonth.Size = new System.Drawing.Size(52, 26);
            this.numBirtdayMonth.TabIndex = 48;
            this.Tooltips.SetToolTip(this.numBirtdayMonth, "Month\tStarsign\r\n____________________\r\n1-2\tThe Slime\r\n3-4\tThe Rabby\r\n5-6\tThe Bee\r\n" +
        "7-8\tThe Boar\r\n9-10\tThe Bloomo\r\n11-12\tThe Yeti");
            this.numBirtdayMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numBirthdayDay
            // 
            this.numBirthdayDay.Location = new System.Drawing.Point(110, 151);
            this.numBirthdayDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBirthdayDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numBirthdayDay.Name = "numBirthdayDay";
            this.numBirthdayDay.Size = new System.Drawing.Size(52, 26);
            this.numBirthdayDay.TabIndex = 46;
            this.numBirthdayDay.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // txtTimePlayed
            // 
            this.txtTimePlayed.Location = new System.Drawing.Point(110, 111);
            this.txtTimePlayed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimePlayed.MaxLength = 13;
            this.txtTimePlayed.Name = "txtTimePlayed";
            this.txtTimePlayed.Size = new System.Drawing.Size(110, 26);
            this.txtTimePlayed.TabIndex = 45;
            this.Tooltips.SetToolTip(this.txtTimePlayed, "D:HH:MM:SS");
            // 
            // label49
            // 
            this.label49.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(652, 582);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(163, 20);
            this.label49.TabIndex = 42;
            this.label49.Text = "↑ ↑ ↓ ↓ ← → ← → B A";
            // 
            // grpEquipped
            // 
            this.grpEquipped.Controls.Add(this.lblAccessory2);
            this.grpEquipped.Controls.Add(this.lblAccessory1);
            this.grpEquipped.Controls.Add(this.lblShoes);
            this.grpEquipped.Controls.Add(this.lblArmor);
            this.grpEquipped.Controls.Add(this.lblShield);
            this.grpEquipped.Controls.Add(this.lblWeapon);
            this.grpEquipped.Controls.Add(this.lblFacegear);
            this.grpEquipped.Controls.Add(this.lblHat);
            this.grpEquipped.Controls.Add(this.cbAccessory2);
            this.grpEquipped.Controls.Add(this.cbAccessory1);
            this.grpEquipped.Controls.Add(this.cbShoes);
            this.grpEquipped.Controls.Add(this.cbArmor);
            this.grpEquipped.Controls.Add(this.cbShield);
            this.grpEquipped.Controls.Add(this.cbWeapon);
            this.grpEquipped.Controls.Add(this.cbFacegear);
            this.grpEquipped.Controls.Add(this.cbHat);
            this.grpEquipped.Location = new System.Drawing.Point(420, 6);
            this.grpEquipped.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEquipped.Name = "grpEquipped";
            this.grpEquipped.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEquipped.Size = new System.Drawing.Size(406, 368);
            this.grpEquipped.TabIndex = 40;
            this.grpEquipped.TabStop = false;
            this.grpEquipped.Text = "Equipped Gear";
            // 
            // lblAccessory2
            // 
            this.lblAccessory2.AutoSize = true;
            this.lblAccessory2.Location = new System.Drawing.Point(10, 325);
            this.lblAccessory2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessory2.Name = "lblAccessory2";
            this.lblAccessory2.Size = new System.Drawing.Size(99, 20);
            this.lblAccessory2.TabIndex = 22;
            this.lblAccessory2.Text = "Accessory 2:";
            // 
            // lblAccessory1
            // 
            this.lblAccessory1.AutoSize = true;
            this.lblAccessory1.Location = new System.Drawing.Point(10, 283);
            this.lblAccessory1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessory1.Name = "lblAccessory1";
            this.lblAccessory1.Size = new System.Drawing.Size(99, 20);
            this.lblAccessory1.TabIndex = 21;
            this.lblAccessory1.Text = "Accessory 1:";
            // 
            // lblShoes
            // 
            this.lblShoes.AutoSize = true;
            this.lblShoes.Location = new System.Drawing.Point(10, 242);
            this.lblShoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShoes.Name = "lblShoes";
            this.lblShoes.Size = new System.Drawing.Size(59, 20);
            this.lblShoes.TabIndex = 20;
            this.lblShoes.Text = "Shoes:";
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Location = new System.Drawing.Point(10, 200);
            this.lblArmor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(56, 20);
            this.lblArmor.TabIndex = 19;
            this.lblArmor.Text = "Armor:";
            // 
            // lblShield
            // 
            this.lblShield.AutoSize = true;
            this.lblShield.Location = new System.Drawing.Point(10, 158);
            this.lblShield.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShield.Name = "lblShield";
            this.lblShield.Size = new System.Drawing.Size(57, 20);
            this.lblShield.TabIndex = 18;
            this.lblShield.Text = "Shield:";
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Location = new System.Drawing.Point(10, 117);
            this.lblWeapon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(73, 20);
            this.lblWeapon.TabIndex = 17;
            this.lblWeapon.Text = "Weapon:";
            // 
            // lblFacegear
            // 
            this.lblFacegear.AutoSize = true;
            this.lblFacegear.Location = new System.Drawing.Point(10, 75);
            this.lblFacegear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacegear.Name = "lblFacegear";
            this.lblFacegear.Size = new System.Drawing.Size(81, 20);
            this.lblFacegear.TabIndex = 16;
            this.lblFacegear.Text = "Facegear:";
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.Location = new System.Drawing.Point(10, 34);
            this.lblHat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(39, 20);
            this.lblHat.TabIndex = 15;
            this.lblHat.Text = "Hat:";
            // 
            // cbAccessory2
            // 
            this.cbAccessory2.FormattingEnabled = true;
            this.cbAccessory2.Location = new System.Drawing.Point(118, 320);
            this.cbAccessory2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAccessory2.Name = "cbAccessory2";
            this.cbAccessory2.Size = new System.Drawing.Size(277, 28);
            this.cbAccessory2.TabIndex = 14;
            // 
            // cbAccessory1
            // 
            this.cbAccessory1.FormattingEnabled = true;
            this.cbAccessory1.Location = new System.Drawing.Point(118, 278);
            this.cbAccessory1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAccessory1.Name = "cbAccessory1";
            this.cbAccessory1.Size = new System.Drawing.Size(277, 28);
            this.cbAccessory1.TabIndex = 13;
            // 
            // cbShoes
            // 
            this.cbShoes.FormattingEnabled = true;
            this.cbShoes.Location = new System.Drawing.Point(118, 237);
            this.cbShoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShoes.Name = "cbShoes";
            this.cbShoes.Size = new System.Drawing.Size(277, 28);
            this.cbShoes.TabIndex = 12;
            // 
            // cbArmor
            // 
            this.cbArmor.FormattingEnabled = true;
            this.cbArmor.Location = new System.Drawing.Point(118, 195);
            this.cbArmor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbArmor.Name = "cbArmor";
            this.cbArmor.Size = new System.Drawing.Size(277, 28);
            this.cbArmor.TabIndex = 11;
            // 
            // cbShield
            // 
            this.cbShield.FormattingEnabled = true;
            this.cbShield.Location = new System.Drawing.Point(118, 154);
            this.cbShield.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShield.Name = "cbShield";
            this.cbShield.Size = new System.Drawing.Size(277, 28);
            this.cbShield.TabIndex = 10;
            // 
            // cbWeapon
            // 
            this.cbWeapon.FormattingEnabled = true;
            this.cbWeapon.Location = new System.Drawing.Point(118, 112);
            this.cbWeapon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbWeapon.Name = "cbWeapon";
            this.cbWeapon.Size = new System.Drawing.Size(277, 28);
            this.cbWeapon.TabIndex = 9;
            // 
            // cbFacegear
            // 
            this.cbFacegear.FormattingEnabled = true;
            this.cbFacegear.Location = new System.Drawing.Point(118, 71);
            this.cbFacegear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFacegear.Name = "cbFacegear";
            this.cbFacegear.Size = new System.Drawing.Size(277, 28);
            this.cbFacegear.TabIndex = 8;
            // 
            // cbHat
            // 
            this.cbHat.FormattingEnabled = true;
            this.cbHat.Location = new System.Drawing.Point(118, 29);
            this.cbHat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHat.Name = "cbHat";
            this.cbHat.Size = new System.Drawing.Size(277, 28);
            this.cbHat.TabIndex = 7;
            // 
            // grpEquippedStyle
            // 
            this.grpEquippedStyle.Controls.Add(this.lblEqShield);
            this.grpEquippedStyle.Controls.Add(this.cbStyleShield);
            this.grpEquippedStyle.Controls.Add(this.lblEqWeapon);
            this.grpEquippedStyle.Controls.Add(this.cbStyleHat);
            this.grpEquippedStyle.Controls.Add(this.lblEqFacegear);
            this.grpEquippedStyle.Controls.Add(this.cbStyleFacegear);
            this.grpEquippedStyle.Controls.Add(this.lblEqHat);
            this.grpEquippedStyle.Controls.Add(this.cbStyleWeapon);
            this.grpEquippedStyle.Location = new System.Drawing.Point(420, 383);
            this.grpEquippedStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEquippedStyle.Name = "grpEquippedStyle";
            this.grpEquippedStyle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEquippedStyle.Size = new System.Drawing.Size(406, 198);
            this.grpEquippedStyle.TabIndex = 41;
            this.grpEquippedStyle.TabStop = false;
            this.grpEquippedStyle.Text = "Equipped Style";
            // 
            // lblEqShield
            // 
            this.lblEqShield.AutoSize = true;
            this.lblEqShield.Location = new System.Drawing.Point(10, 158);
            this.lblEqShield.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEqShield.Name = "lblEqShield";
            this.lblEqShield.Size = new System.Drawing.Size(57, 20);
            this.lblEqShield.TabIndex = 30;
            this.lblEqShield.Text = "Shield:";
            // 
            // cbStyleShield
            // 
            this.cbStyleShield.FormattingEnabled = true;
            this.cbStyleShield.Location = new System.Drawing.Point(118, 154);
            this.cbStyleShield.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStyleShield.Name = "cbStyleShield";
            this.cbStyleShield.Size = new System.Drawing.Size(277, 28);
            this.cbStyleShield.TabIndex = 26;
            // 
            // lblEqWeapon
            // 
            this.lblEqWeapon.AutoSize = true;
            this.lblEqWeapon.Location = new System.Drawing.Point(10, 117);
            this.lblEqWeapon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEqWeapon.Name = "lblEqWeapon";
            this.lblEqWeapon.Size = new System.Drawing.Size(73, 20);
            this.lblEqWeapon.TabIndex = 29;
            this.lblEqWeapon.Text = "Weapon:";
            // 
            // cbStyleHat
            // 
            this.cbStyleHat.FormattingEnabled = true;
            this.cbStyleHat.Location = new System.Drawing.Point(118, 29);
            this.cbStyleHat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStyleHat.Name = "cbStyleHat";
            this.cbStyleHat.Size = new System.Drawing.Size(277, 28);
            this.cbStyleHat.TabIndex = 23;
            // 
            // lblEqFacegear
            // 
            this.lblEqFacegear.AutoSize = true;
            this.lblEqFacegear.Location = new System.Drawing.Point(10, 75);
            this.lblEqFacegear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEqFacegear.Name = "lblEqFacegear";
            this.lblEqFacegear.Size = new System.Drawing.Size(81, 20);
            this.lblEqFacegear.TabIndex = 28;
            this.lblEqFacegear.Text = "Facegear:";
            // 
            // cbStyleFacegear
            // 
            this.cbStyleFacegear.FormattingEnabled = true;
            this.cbStyleFacegear.Location = new System.Drawing.Point(118, 71);
            this.cbStyleFacegear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStyleFacegear.Name = "cbStyleFacegear";
            this.cbStyleFacegear.Size = new System.Drawing.Size(277, 28);
            this.cbStyleFacegear.TabIndex = 24;
            // 
            // lblEqHat
            // 
            this.lblEqHat.AutoSize = true;
            this.lblEqHat.Location = new System.Drawing.Point(10, 34);
            this.lblEqHat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEqHat.Name = "lblEqHat";
            this.lblEqHat.Size = new System.Drawing.Size(39, 20);
            this.lblEqHat.TabIndex = 27;
            this.lblEqHat.Text = "Hat:";
            // 
            // cbStyleWeapon
            // 
            this.cbStyleWeapon.FormattingEnabled = true;
            this.cbStyleWeapon.Location = new System.Drawing.Point(118, 112);
            this.cbStyleWeapon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStyleWeapon.Name = "cbStyleWeapon";
            this.cbStyleWeapon.Size = new System.Drawing.Size(277, 28);
            this.cbStyleWeapon.TabIndex = 25;
            // 
            // grpSkillpoints
            // 
            this.grpSkillpoints.Controls.Add(this.numSkillTalentPoints);
            this.grpSkillpoints.Controls.Add(this.lblGoldPoints);
            this.grpSkillpoints.Controls.Add(this.numSkillSilverPoints);
            this.grpSkillpoints.Controls.Add(this.numSkillGoldPoints);
            this.grpSkillpoints.Controls.Add(this.lblSilverPoints);
            this.grpSkillpoints.Controls.Add(this.lblTalentPoints);
            this.grpSkillpoints.Location = new System.Drawing.Point(9, 443);
            this.grpSkillpoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSkillpoints.Name = "grpSkillpoints";
            this.grpSkillpoints.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSkillpoints.Size = new System.Drawing.Size(236, 154);
            this.grpSkillpoints.TabIndex = 37;
            this.grpSkillpoints.TabStop = false;
            this.grpSkillpoints.Text = "Skill Points";
            // 
            // numSkillTalentPoints
            // 
            this.numSkillTalentPoints.Location = new System.Drawing.Point(142, 31);
            this.numSkillTalentPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSkillTalentPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numSkillTalentPoints.Name = "numSkillTalentPoints";
            this.numSkillTalentPoints.Size = new System.Drawing.Size(76, 26);
            this.numSkillTalentPoints.TabIndex = 3;
            // 
            // lblGoldPoints
            // 
            this.lblGoldPoints.AutoSize = true;
            this.lblGoldPoints.Location = new System.Drawing.Point(8, 114);
            this.lblGoldPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoldPoints.Name = "lblGoldPoints";
            this.lblGoldPoints.Size = new System.Drawing.Size(119, 20);
            this.lblGoldPoints.TabIndex = 2;
            this.lblGoldPoints.Text = "Gold Skill Point:";
            // 
            // numSkillSilverPoints
            // 
            this.numSkillSilverPoints.Location = new System.Drawing.Point(142, 71);
            this.numSkillSilverPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSkillSilverPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numSkillSilverPoints.Name = "numSkillSilverPoints";
            this.numSkillSilverPoints.Size = new System.Drawing.Size(76, 26);
            this.numSkillSilverPoints.TabIndex = 4;
            // 
            // numSkillGoldPoints
            // 
            this.numSkillGoldPoints.Location = new System.Drawing.Point(142, 111);
            this.numSkillGoldPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSkillGoldPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numSkillGoldPoints.Name = "numSkillGoldPoints";
            this.numSkillGoldPoints.Size = new System.Drawing.Size(76, 26);
            this.numSkillGoldPoints.TabIndex = 5;
            // 
            // lblSilverPoints
            // 
            this.lblSilverPoints.AutoSize = true;
            this.lblSilverPoints.Location = new System.Drawing.Point(8, 74);
            this.lblSilverPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilverPoints.Name = "lblSilverPoints";
            this.lblSilverPoints.Size = new System.Drawing.Size(123, 20);
            this.lblSilverPoints.TabIndex = 1;
            this.lblSilverPoints.Text = "Silver Skill Point:";
            // 
            // lblTalentPoints
            // 
            this.lblTalentPoints.AutoSize = true;
            this.lblTalentPoints.Location = new System.Drawing.Point(8, 34);
            this.lblTalentPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTalentPoints.Name = "lblTalentPoints";
            this.lblTalentPoints.Size = new System.Drawing.Size(105, 20);
            this.lblTalentPoints.TabIndex = 0;
            this.lblTalentPoints.Text = "Talent Points:";
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.lblExpUnknown1);
            this.grpLevel.Controls.Add(this.lblExpUnknown0);
            this.grpLevel.Controls.Add(this.lblCurrectExp);
            this.grpLevel.Controls.Add(this.lblLevel);
            this.grpLevel.Controls.Add(this.numEXPUnknown1);
            this.grpLevel.Controls.Add(this.numEXPUnknown0);
            this.grpLevel.Controls.Add(this.numEXPcurrent);
            this.grpLevel.Controls.Add(this.numLevel);
            this.grpLevel.Location = new System.Drawing.Point(9, 243);
            this.grpLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLevel.Size = new System.Drawing.Size(236, 194);
            this.grpLevel.TabIndex = 36;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "Level";
            // 
            // lblExpUnknown1
            // 
            this.lblExpUnknown1.AutoSize = true;
            this.lblExpUnknown1.Location = new System.Drawing.Point(8, 152);
            this.lblExpUnknown1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpUnknown1.Name = "lblExpUnknown1";
            this.lblExpUnknown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExpUnknown1.Size = new System.Drawing.Size(129, 20);
            this.lblExpUnknown1.TabIndex = 7;
            this.lblExpUnknown1.Text = "[EXPUnknown1]:";
            // 
            // lblExpUnknown0
            // 
            this.lblExpUnknown0.AutoSize = true;
            this.lblExpUnknown0.Location = new System.Drawing.Point(8, 112);
            this.lblExpUnknown0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpUnknown0.Name = "lblExpUnknown0";
            this.lblExpUnknown0.Size = new System.Drawing.Size(129, 20);
            this.lblExpUnknown0.TabIndex = 6;
            this.lblExpUnknown0.Text = "[EXPUnknown0]:";
            // 
            // lblCurrectExp
            // 
            this.lblCurrectExp.AutoSize = true;
            this.lblCurrectExp.Location = new System.Drawing.Point(8, 72);
            this.lblCurrectExp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrectExp.Name = "lblCurrectExp";
            this.lblCurrectExp.Size = new System.Drawing.Size(102, 20);
            this.lblCurrectExp.TabIndex = 5;
            this.lblCurrectExp.Text = "Current EXP:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(8, 32);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level:";
            // 
            // numEXPUnknown1
            // 
            this.numEXPUnknown1.Location = new System.Drawing.Point(144, 149);
            this.numEXPUnknown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numEXPUnknown1.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numEXPUnknown1.Name = "numEXPUnknown1";
            this.numEXPUnknown1.Size = new System.Drawing.Size(76, 26);
            this.numEXPUnknown1.TabIndex = 3;
            this.Tooltips.SetToolTip(this.numEXPUnknown1, "idk? probably the exp you need to level up?");
            // 
            // numEXPUnknown0
            // 
            this.numEXPUnknown0.Location = new System.Drawing.Point(144, 109);
            this.numEXPUnknown0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numEXPUnknown0.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numEXPUnknown0.Name = "numEXPUnknown0";
            this.numEXPUnknown0.Size = new System.Drawing.Size(76, 26);
            this.numEXPUnknown0.TabIndex = 2;
            this.Tooltips.SetToolTip(this.numEXPUnknown0, "idk");
            // 
            // numEXPcurrent
            // 
            this.numEXPcurrent.Location = new System.Drawing.Point(144, 69);
            this.numEXPcurrent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numEXPcurrent.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numEXPcurrent.Name = "numEXPcurrent";
            this.numEXPcurrent.Size = new System.Drawing.Size(76, 26);
            this.numEXPcurrent.TabIndex = 1;
            this.Tooltips.SetToolTip(this.numEXPcurrent, "Seit it to 9999 to level up after next kill");
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(162, 29);
            this.numLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numLevel.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(58, 26);
            this.numLevel.TabIndex = 0;
            this.Tooltips.SetToolTip(this.numLevel, "Changing Level won\'t give you any Skill Points!");
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.lblPants);
            this.grpColors.Controls.Add(this.lblShirt);
            this.grpColors.Controls.Add(this.lblPoncho);
            this.grpColors.Controls.Add(this.lblSkin);
            this.grpColors.Controls.Add(this.btnPantsColor);
            this.grpColors.Controls.Add(this.btnShirtColor);
            this.grpColors.Controls.Add(this.btnPonchoColor);
            this.grpColors.Controls.Add(this.btnSkinColor);
            this.grpColors.Controls.Add(this.btnHairColor);
            this.grpColors.Controls.Add(this.lblHair);
            this.grpColors.Location = new System.Drawing.Point(254, 6);
            this.grpColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpColors.Name = "grpColors";
            this.grpColors.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpColors.Size = new System.Drawing.Size(158, 228);
            this.grpColors.TabIndex = 33;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Colors";
            // 
            // lblPants
            // 
            this.lblPants.AutoSize = true;
            this.lblPants.Location = new System.Drawing.Point(9, 188);
            this.lblPants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPants.Name = "lblPants";
            this.lblPants.Size = new System.Drawing.Size(54, 20);
            this.lblPants.TabIndex = 13;
            this.lblPants.Text = "Pants:";
            // 
            // lblShirt
            // 
            this.lblShirt.AutoSize = true;
            this.lblShirt.Location = new System.Drawing.Point(9, 148);
            this.lblShirt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShirt.Name = "lblShirt";
            this.lblShirt.Size = new System.Drawing.Size(46, 20);
            this.lblShirt.TabIndex = 12;
            this.lblShirt.Text = "Shirt:";
            // 
            // lblPoncho
            // 
            this.lblPoncho.AutoSize = true;
            this.lblPoncho.Location = new System.Drawing.Point(9, 108);
            this.lblPoncho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoncho.Name = "lblPoncho";
            this.lblPoncho.Size = new System.Drawing.Size(67, 20);
            this.lblPoncho.TabIndex = 11;
            this.lblPoncho.Text = "Poncho:";
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(9, 68);
            this.lblSkin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(44, 20);
            this.lblSkin.TabIndex = 10;
            this.lblSkin.Text = "Skin:";
            // 
            // btnPantsColor
            // 
            this.btnPantsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantsColor.Location = new System.Drawing.Point(111, 182);
            this.btnPantsColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPantsColor.Name = "btnPantsColor";
            this.btnPantsColor.Size = new System.Drawing.Size(30, 31);
            this.btnPantsColor.TabIndex = 9;
            this.btnPantsColor.TabStop = false;
            this.btnPantsColor.UseVisualStyleBackColor = false;
            this.btnPantsColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // btnShirtColor
            // 
            this.btnShirtColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShirtColor.Location = new System.Drawing.Point(111, 142);
            this.btnShirtColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShirtColor.Name = "btnShirtColor";
            this.btnShirtColor.Size = new System.Drawing.Size(30, 31);
            this.btnShirtColor.TabIndex = 8;
            this.btnShirtColor.TabStop = false;
            this.btnShirtColor.UseVisualStyleBackColor = false;
            this.btnShirtColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // btnPonchoColor
            // 
            this.btnPonchoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonchoColor.Location = new System.Drawing.Point(111, 102);
            this.btnPonchoColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPonchoColor.Name = "btnPonchoColor";
            this.btnPonchoColor.Size = new System.Drawing.Size(30, 31);
            this.btnPonchoColor.TabIndex = 7;
            this.btnPonchoColor.TabStop = false;
            this.btnPonchoColor.UseVisualStyleBackColor = false;
            this.btnPonchoColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // btnSkinColor
            // 
            this.btnSkinColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkinColor.Location = new System.Drawing.Point(111, 62);
            this.btnSkinColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSkinColor.Name = "btnSkinColor";
            this.btnSkinColor.Size = new System.Drawing.Size(30, 31);
            this.btnSkinColor.TabIndex = 6;
            this.btnSkinColor.TabStop = false;
            this.Tooltips.SetToolTip(this.btnSkinColor, "Not implemented yet");
            this.btnSkinColor.UseVisualStyleBackColor = false;
            // 
            // btnHairColor
            // 
            this.btnHairColor.BackColor = System.Drawing.Color.White;
            this.btnHairColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHairColor.Location = new System.Drawing.Point(111, 22);
            this.btnHairColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHairColor.Name = "btnHairColor";
            this.btnHairColor.Size = new System.Drawing.Size(30, 31);
            this.btnHairColor.TabIndex = 5;
            this.btnHairColor.TabStop = false;
            this.btnHairColor.UseVisualStyleBackColor = false;
            this.btnHairColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // lblHair
            // 
            this.lblHair.AutoSize = true;
            this.lblHair.Location = new System.Drawing.Point(9, 28);
            this.lblHair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHair.Name = "lblHair";
            this.lblHair.Size = new System.Drawing.Size(42, 20);
            this.lblHair.TabIndex = 0;
            this.lblHair.Text = "Hair:";
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.numGold);
            this.tabInventory.Controls.Add(this.lblGold);
            this.tabInventory.Controls.Add(this.grpItem);
            this.tabInventory.Controls.Add(this.lstInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInventory.Size = new System.Drawing.Size(842, 616);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // numGold
            // 
            this.numGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numGold.Location = new System.Drawing.Point(675, 555);
            this.numGold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGold.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numGold.Name = "numGold";
            this.numGold.Size = new System.Drawing.Size(152, 26);
            this.numGold.TabIndex = 40;
            this.Tooltips.SetToolTip(this.numGold, "Money/Papes/Cheddar/Mulla/Dollar/Coins/Green Faces/Loochies/Bread/Dosh");
            // 
            // lblGold
            // 
            this.lblGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(670, 531);
            this.lblGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(47, 20);
            this.lblGold.TabIndex = 41;
            this.lblGold.Text = "Gold:";
            // 
            // grpItem
            // 
            this.grpItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpItem.Controls.Add(this.btnDeleteSelectedItem);
            this.grpItem.Controls.Add(this.btnAddItem);
            this.grpItem.Controls.Add(this.lblItemCount);
            this.grpItem.Controls.Add(this.numItemCount);
            this.grpItem.Controls.Add(this.cbSelectedItem);
            this.grpItem.Location = new System.Drawing.Point(4, 485);
            this.grpItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpItem.Name = "grpItem";
            this.grpItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpItem.Size = new System.Drawing.Size(478, 114);
            this.grpItem.TabIndex = 1;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            // 
            // btnDeleteSelectedItem
            // 
            this.btnDeleteSelectedItem.Location = new System.Drawing.Point(380, 66);
            this.btnDeleteSelectedItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteSelectedItem.Name = "btnDeleteSelectedItem";
            this.btnDeleteSelectedItem.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteSelectedItem.TabIndex = 2;
            this.btnDeleteSelectedItem.Text = "Remove";
            this.btnDeleteSelectedItem.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedItem.Click += new System.EventHandler(this.BtnDeleteSelectedItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(380, 26);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(90, 35);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.Tooltips.SetToolTip(this.btnAddItem, "Some Items COULD potentially break your game");
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(198, 74);
            this.lblItemCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(56, 20);
            this.lblItemCount.TabIndex = 2;
            this.lblItemCount.Text = "Count:";
            // 
            // numItemCount
            // 
            this.numItemCount.Location = new System.Drawing.Point(264, 71);
            this.numItemCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numItemCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numItemCount.Name = "numItemCount";
            this.numItemCount.Size = new System.Drawing.Size(106, 26);
            this.numItemCount.TabIndex = 1;
            this.numItemCount.ValueChanged += new System.EventHandler(this.NumItemCount_ValueChanged);
            // 
            // cbSelectedItem
            // 
            this.cbSelectedItem.FormattingEnabled = true;
            this.cbSelectedItem.Location = new System.Drawing.Point(9, 29);
            this.cbSelectedItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSelectedItem.Name = "cbSelectedItem";
            this.cbSelectedItem.Size = new System.Drawing.Size(360, 28);
            this.cbSelectedItem.TabIndex = 0;
            // 
            // lstInventory
            // 
            this.lstInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Count,
            this.Position});
            this.lstInventory.FullRowSelect = true;
            this.lstInventory.GridLines = true;
            this.lstInventory.HideSelection = false;
            this.lstInventory.LabelWrap = false;
            this.lstInventory.Location = new System.Drawing.Point(9, 9);
            this.lstInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstInventory.MultiSelect = false;
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(818, 464);
            this.lstInventory.TabIndex = 0;
            this.lstInventory.UseCompatibleStateImageBehavior = false;
            this.lstInventory.View = System.Windows.Forms.View.Details;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.LstInventory_SelectedIndexChanged);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 321;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 54;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 71;
            // 
            // tabPets
            // 
            this.tabPets.Controls.Add(this.lstPets);
            this.tabPets.Controls.Add(this.grpPet);
            this.tabPets.Location = new System.Drawing.Point(4, 29);
            this.tabPets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPets.Size = new System.Drawing.Size(842, 616);
            this.tabPets.TabIndex = 8;
            this.tabPets.Text = "Pets";
            this.tabPets.UseVisualStyleBackColor = true;
            // 
            // lstPets
            // 
            this.lstPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Level,
            this.Nickname,
            this.HP,
            this.SP,
            this.Dmg,
            this.Crit,
            this.Speed});
            this.lstPets.FullRowSelect = true;
            this.lstPets.GridLines = true;
            this.lstPets.HideSelection = false;
            this.lstPets.Location = new System.Drawing.Point(9, 9);
            this.lstPets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPets.MultiSelect = false;
            this.lstPets.Name = "lstPets";
            this.lstPets.Size = new System.Drawing.Size(550, 587);
            this.lstPets.TabIndex = 1;
            this.lstPets.UseCompatibleStateImageBehavior = false;
            this.lstPets.View = System.Windows.Forms.View.Details;
            this.lstPets.SelectedIndexChanged += new System.EventHandler(this.LstPets_SelectedIndexChanged);
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 39;
            // 
            // Nickname
            // 
            this.Nickname.Text = "Nickname";
            this.Nickname.Width = 92;
            // 
            // HP
            // 
            this.HP.Text = "HP";
            this.HP.Width = 45;
            // 
            // SP
            // 
            this.SP.Text = "SP";
            this.SP.Width = 47;
            // 
            // Dmg
            // 
            this.Dmg.Text = "Dmg";
            this.Dmg.Width = 48;
            // 
            // Crit
            // 
            this.Crit.Text = "Crit";
            this.Crit.Width = 49;
            // 
            // Speed
            // 
            this.Speed.Text = "Speed";
            this.Speed.Width = 44;
            // 
            // grpPet
            // 
            this.grpPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPet.Controls.Add(this.cbPetType);
            this.grpPet.Controls.Add(this.lblPetType);
            this.grpPet.Controls.Add(this.numPetLevel);
            this.grpPet.Controls.Add(this.lblPetLevel);
            this.grpPet.Controls.Add(this.lblPetSpeed);
            this.grpPet.Controls.Add(this.lblPetCrit);
            this.grpPet.Controls.Add(this.lblPetDamage);
            this.grpPet.Controls.Add(this.lblPetEnergy);
            this.grpPet.Controls.Add(this.lblPetNickname);
            this.grpPet.Controls.Add(this.txtPetNickname);
            this.grpPet.Controls.Add(this.lblPetHealth);
            this.grpPet.Controls.Add(this.numPetSpeed);
            this.grpPet.Controls.Add(this.numPetCrit);
            this.grpPet.Controls.Add(this.numPetDamage);
            this.grpPet.Controls.Add(this.numPetEnergy);
            this.grpPet.Controls.Add(this.numPetHP);
            this.grpPet.Location = new System.Drawing.Point(570, 9);
            this.grpPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPet.Name = "grpPet";
            this.grpPet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPet.Size = new System.Drawing.Size(256, 349);
            this.grpPet.TabIndex = 0;
            this.grpPet.TabStop = false;
            this.grpPet.Text = "Pet";
            // 
            // cbPetType
            // 
            this.cbPetType.Enabled = false;
            this.cbPetType.FormattingEnabled = true;
            this.cbPetType.Location = new System.Drawing.Point(110, 71);
            this.cbPetType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPetType.Name = "cbPetType";
            this.cbPetType.Size = new System.Drawing.Size(138, 28);
            this.cbPetType.TabIndex = 2;
            // 
            // lblPetType
            // 
            this.lblPetType.AutoSize = true;
            this.lblPetType.Location = new System.Drawing.Point(9, 75);
            this.lblPetType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetType.Name = "lblPetType";
            this.lblPetType.Size = new System.Drawing.Size(37, 20);
            this.lblPetType.TabIndex = 15;
            this.lblPetType.Text = "Pet:";
            // 
            // numPetLevel
            // 
            this.numPetLevel.Location = new System.Drawing.Point(166, 111);
            this.numPetLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPetLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPetLevel.Name = "numPetLevel";
            this.numPetLevel.Size = new System.Drawing.Size(82, 26);
            this.numPetLevel.TabIndex = 14;
            this.numPetLevel.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // lblPetLevel
            // 
            this.lblPetLevel.AutoSize = true;
            this.lblPetLevel.Location = new System.Drawing.Point(9, 114);
            this.lblPetLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetLevel.Name = "lblPetLevel";
            this.lblPetLevel.Size = new System.Drawing.Size(72, 20);
            this.lblPetLevel.TabIndex = 13;
            this.lblPetLevel.Text = "Pet level:";
            // 
            // lblPetSpeed
            // 
            this.lblPetSpeed.AutoSize = true;
            this.lblPetSpeed.Location = new System.Drawing.Point(9, 306);
            this.lblPetSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetSpeed.Name = "lblPetSpeed";
            this.lblPetSpeed.Size = new System.Drawing.Size(95, 20);
            this.lblPetSpeed.TabIndex = 12;
            this.lblPetSpeed.Text = "Speed level:";
            // 
            // lblPetCrit
            // 
            this.lblPetCrit.AutoSize = true;
            this.lblPetCrit.Location = new System.Drawing.Point(9, 268);
            this.lblPetCrit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetCrit.Name = "lblPetCrit";
            this.lblPetCrit.Size = new System.Drawing.Size(72, 20);
            this.lblPetCrit.TabIndex = 11;
            this.lblPetCrit.Text = "Crit level:";
            // 
            // lblPetDamage
            // 
            this.lblPetDamage.AutoSize = true;
            this.lblPetDamage.Location = new System.Drawing.Point(9, 229);
            this.lblPetDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetDamage.Name = "lblPetDamage";
            this.lblPetDamage.Size = new System.Drawing.Size(109, 20);
            this.lblPetDamage.TabIndex = 10;
            this.lblPetDamage.Text = "Damage level:";
            // 
            // lblPetEnergy
            // 
            this.lblPetEnergy.AutoSize = true;
            this.lblPetEnergy.Location = new System.Drawing.Point(9, 191);
            this.lblPetEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetEnergy.Name = "lblPetEnergy";
            this.lblPetEnergy.Size = new System.Drawing.Size(98, 20);
            this.lblPetEnergy.TabIndex = 9;
            this.lblPetEnergy.Text = "Energy level:";
            // 
            // lblPetNickname
            // 
            this.lblPetNickname.AutoSize = true;
            this.lblPetNickname.Location = new System.Drawing.Point(9, 37);
            this.lblPetNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetNickname.Name = "lblPetNickname";
            this.lblPetNickname.Size = new System.Drawing.Size(83, 20);
            this.lblPetNickname.TabIndex = 2;
            this.lblPetNickname.Text = "Nickname:";
            // 
            // txtPetNickname
            // 
            this.txtPetNickname.Location = new System.Drawing.Point(110, 32);
            this.txtPetNickname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPetNickname.Name = "txtPetNickname";
            this.txtPetNickname.Size = new System.Drawing.Size(138, 26);
            this.txtPetNickname.TabIndex = 1;
            this.txtPetNickname.TextChanged += new System.EventHandler(this.TxtPetNickname_TextChanged);
            // 
            // lblPetHealth
            // 
            this.lblPetHealth.AutoSize = true;
            this.lblPetHealth.Location = new System.Drawing.Point(9, 152);
            this.lblPetHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetHealth.Name = "lblPetHealth";
            this.lblPetHealth.Size = new System.Drawing.Size(95, 20);
            this.lblPetHealth.TabIndex = 8;
            this.lblPetHealth.Text = "Health level:";
            // 
            // numPetSpeed
            // 
            this.numPetSpeed.Location = new System.Drawing.Point(166, 303);
            this.numPetSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPetSpeed.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetSpeed.Name = "numPetSpeed";
            this.numPetSpeed.Size = new System.Drawing.Size(82, 26);
            this.numPetSpeed.TabIndex = 7;
            this.numPetSpeed.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetCrit
            // 
            this.numPetCrit.Location = new System.Drawing.Point(166, 265);
            this.numPetCrit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPetCrit.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetCrit.Name = "numPetCrit";
            this.numPetCrit.Size = new System.Drawing.Size(82, 26);
            this.numPetCrit.TabIndex = 6;
            this.numPetCrit.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetDamage
            // 
            this.numPetDamage.Location = new System.Drawing.Point(166, 226);
            this.numPetDamage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPetDamage.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetDamage.Name = "numPetDamage";
            this.numPetDamage.Size = new System.Drawing.Size(82, 26);
            this.numPetDamage.TabIndex = 5;
            this.numPetDamage.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetEnergy
            // 
            this.numPetEnergy.Location = new System.Drawing.Point(166, 188);
            this.numPetEnergy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPetEnergy.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetEnergy.Name = "numPetEnergy";
            this.numPetEnergy.Size = new System.Drawing.Size(82, 26);
            this.numPetEnergy.TabIndex = 4;
            this.numPetEnergy.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetHP
            // 
            this.numPetHP.Location = new System.Drawing.Point(166, 149);
            this.numPetHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPetHP.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetHP.Name = "numPetHP";
            this.numPetHP.Size = new System.Drawing.Size(82, 26);
            this.numPetHP.TabIndex = 3;
            this.numPetHP.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // tabSkills
            // 
            this.tabSkills.BackColor = System.Drawing.Color.Transparent;
            this.tabSkills.Controls.Add(this.tabControl1);
            this.tabSkills.Location = new System.Drawing.Point(4, 29);
            this.tabSkills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkills.Size = new System.Drawing.Size(842, 616);
            this.tabSkills.TabIndex = 7;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabSkillsMelee);
            this.tabControl1.Controls.Add(this.tabSkillsMagic);
            this.tabControl1.Controls.Add(this.tabSkillsUtility);
            this.tabControl1.Controls.Add(this.tabTalentsMelee);
            this.tabControl1.Controls.Add(this.tabTalentsMagic);
            this.tabControl1.Controls.Add(this.tabTalentsGeneral);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 100);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 562);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 32;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem);
            // 
            // tabSkillsMelee
            // 
            this.tabSkillsMelee.Controls.Add(this.groupBox11);
            this.tabSkillsMelee.Controls.Add(this.groupBox10);
            this.tabSkillsMelee.Location = new System.Drawing.Point(104, 4);
            this.tabSkillsMelee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkillsMelee.Name = "tabSkillsMelee";
            this.tabSkillsMelee.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkillsMelee.Size = new System.Drawing.Size(710, 554);
            this.tabSkillsMelee.TabIndex = 0;
            this.tabSkillsMelee.Text = "Skills: Melee";
            this.tabSkillsMelee.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.numSkillMelee2h4);
            this.groupBox11.Controls.Add(this.numSkillMelee2h3);
            this.groupBox11.Controls.Add(this.numSkillMelee2h2);
            this.groupBox11.Controls.Add(this.numSkillMelee2h1);
            this.groupBox11.Controls.Add(this.pictureBox7);
            this.groupBox11.Controls.Add(this.pictureBox11);
            this.groupBox11.Controls.Add(this.pictureBox8);
            this.groupBox11.Controls.Add(this.pictureBox10);
            this.groupBox11.Controls.Add(this.numSkillMelee2h0);
            this.groupBox11.Controls.Add(this.pictureBox9);
            this.groupBox11.Location = new System.Drawing.Point(9, 196);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Size = new System.Drawing.Size(638, 174);
            this.groupBox11.TabIndex = 21;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Two Handed";
            // 
            // numSkillMelee2h4
            // 
            this.numSkillMelee2h4.Location = new System.Drawing.Point(507, 131);
            this.numSkillMelee2h4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee2h4.Name = "numSkillMelee2h4";
            this.numSkillMelee2h4.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee2h4.TabIndex = 19;
            // 
            // numSkillMelee2h3
            // 
            this.numSkillMelee2h3.Location = new System.Drawing.Point(380, 131);
            this.numSkillMelee2h3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee2h3.Name = "numSkillMelee2h3";
            this.numSkillMelee2h3.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee2h3.TabIndex = 19;
            // 
            // numSkillMelee2h2
            // 
            this.numSkillMelee2h2.Location = new System.Drawing.Point(261, 131);
            this.numSkillMelee2h2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee2h2.Name = "numSkillMelee2h2";
            this.numSkillMelee2h2.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee2h2.TabIndex = 19;
            // 
            // numSkillMelee2h1
            // 
            this.numSkillMelee2h1.Location = new System.Drawing.Point(142, 131);
            this.numSkillMelee2h1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee2h1.Name = "numSkillMelee2h1";
            this.numSkillMelee2h1.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee2h1.TabIndex = 20;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SoG_SGreader.Properties.Resources.icon_berserk;
            this.pictureBox7.Location = new System.Drawing.Point(532, 52);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(69, 71);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::SoG_SGreader.Properties.Resources.icon_overhead;
            this.pictureBox11.Location = new System.Drawing.Point(40, 52);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(69, 71);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SoG_SGreader.Properties.Resources.icon_2hsmash;
            this.pictureBox8.Location = new System.Drawing.Point(405, 52);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(69, 71);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SoG_SGreader.Properties.Resources.icon_swirl_clover;
            this.pictureBox10.Location = new System.Drawing.Point(168, 52);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(69, 71);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // numSkillMelee2h0
            // 
            this.numSkillMelee2h0.Location = new System.Drawing.Point(15, 131);
            this.numSkillMelee2h0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee2h0.Name = "numSkillMelee2h0";
            this.numSkillMelee2h0.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee2h0.TabIndex = 10;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SoG_SGreader.Properties.Resources.icon_2hthrow;
            this.pictureBox9.Location = new System.Drawing.Point(286, 52);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(69, 71);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.numSkillMelee1h1);
            this.groupBox10.Controls.Add(this.numSkillMelee1h0);
            this.groupBox10.Controls.Add(this.pictureBox1);
            this.groupBox10.Controls.Add(this.pictureBox2);
            this.groupBox10.Controls.Add(this.numSkillMelee1h2);
            this.groupBox10.Controls.Add(this.pictureBox4);
            this.groupBox10.Controls.Add(this.numSkillMelee1h3);
            this.groupBox10.Controls.Add(this.pictureBox5);
            this.groupBox10.Controls.Add(this.numSkillMelee1h4);
            this.groupBox10.Controls.Add(this.pictureBox6);
            this.groupBox10.Location = new System.Drawing.Point(9, 9);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Size = new System.Drawing.Size(638, 177);
            this.groupBox10.TabIndex = 20;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "One Handed";
            // 
            // numSkillMelee1h1
            // 
            this.numSkillMelee1h1.Location = new System.Drawing.Point(142, 135);
            this.numSkillMelee1h1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee1h1.Name = "numSkillMelee1h1";
            this.numSkillMelee1h1.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee1h1.TabIndex = 13;
            // 
            // numSkillMelee1h0
            // 
            this.numSkillMelee1h0.Location = new System.Drawing.Point(15, 135);
            this.numSkillMelee1h0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee1h0.Name = "numSkillMelee1h0";
            this.numSkillMelee1h0.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee1h0.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoG_SGreader.Properties.Resources.icon_stinger_clover;
            this.pictureBox1.Location = new System.Drawing.Point(40, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoG_SGreader.Properties.Resources.icon_millionstabs;
            this.pictureBox2.Location = new System.Drawing.Point(168, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // numSkillMelee1h2
            // 
            this.numSkillMelee1h2.Location = new System.Drawing.Point(261, 135);
            this.numSkillMelee1h2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee1h2.Name = "numSkillMelee1h2";
            this.numSkillMelee1h2.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee1h2.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SoG_SGreader.Properties.Resources.icon_soulstrike;
            this.pictureBox4.Location = new System.Drawing.Point(286, 55);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // numSkillMelee1h3
            // 
            this.numSkillMelee1h3.Location = new System.Drawing.Point(380, 135);
            this.numSkillMelee1h3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee1h3.Name = "numSkillMelee1h3";
            this.numSkillMelee1h3.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee1h3.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SoG_SGreader.Properties.Resources.icon_shadowclone;
            this.pictureBox5.Location = new System.Drawing.Point(405, 55);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // numSkillMelee1h4
            // 
            this.numSkillMelee1h4.Location = new System.Drawing.Point(507, 135);
            this.numSkillMelee1h4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMelee1h4.Name = "numSkillMelee1h4";
            this.numSkillMelee1h4.Size = new System.Drawing.Size(118, 26);
            this.numSkillMelee1h4.TabIndex = 8;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SoG_SGreader.Properties.Resources.icon_dodgingstrike;
            this.pictureBox6.Location = new System.Drawing.Point(532, 55);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(69, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // tabSkillsMagic
            // 
            this.tabSkillsMagic.Controls.Add(this.groupBox15);
            this.tabSkillsMagic.Controls.Add(this.groupBox14);
            this.tabSkillsMagic.Controls.Add(this.groupBox13);
            this.tabSkillsMagic.Controls.Add(this.groupBox12);
            this.tabSkillsMagic.Location = new System.Drawing.Point(104, 4);
            this.tabSkillsMagic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkillsMagic.Name = "tabSkillsMagic";
            this.tabSkillsMagic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkillsMagic.Size = new System.Drawing.Size(710, 554);
            this.tabSkillsMagic.TabIndex = 1;
            this.tabSkillsMagic.Text = "Skills: Magic";
            this.tabSkillsMagic.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.numSkillMagicA2);
            this.groupBox15.Controls.Add(this.pictureBox21);
            this.groupBox15.Controls.Add(this.numSkillMagicA1);
            this.groupBox15.Controls.Add(this.pictureBox22);
            this.groupBox15.Controls.Add(this.numSkillMagicA0);
            this.groupBox15.Controls.Add(this.pictureBox23);
            this.groupBox15.Location = new System.Drawing.Point(332, 262);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox15.Size = new System.Drawing.Size(314, 243);
            this.groupBox15.TabIndex = 22;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Air Magic";
            // 
            // numSkillMagicA2
            // 
            this.numSkillMagicA2.Location = new System.Drawing.Point(204, 135);
            this.numSkillMagicA2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicA2.Name = "numSkillMagicA2";
            this.numSkillMagicA2.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicA2.TabIndex = 10;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::SoG_SGreader.Properties.Resources.icon_statictouch;
            this.pictureBox21.Location = new System.Drawing.Point(219, 55);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(69, 71);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 11;
            this.pictureBox21.TabStop = false;
            // 
            // numSkillMagicA1
            // 
            this.numSkillMagicA1.Location = new System.Drawing.Point(110, 135);
            this.numSkillMagicA1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicA1.Name = "numSkillMagicA1";
            this.numSkillMagicA1.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicA1.TabIndex = 8;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::SoG_SGreader.Properties.Resources.icon_summoncloud;
            this.pictureBox22.Location = new System.Drawing.Point(124, 55);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(69, 71);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 9;
            this.pictureBox22.TabStop = false;
            // 
            // numSkillMagicA0
            // 
            this.numSkillMagicA0.Location = new System.Drawing.Point(14, 135);
            this.numSkillMagicA0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicA0.Name = "numSkillMagicA0";
            this.numSkillMagicA0.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicA0.TabIndex = 6;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::SoG_SGreader.Properties.Resources.icon_chainlightning;
            this.pictureBox23.Location = new System.Drawing.Point(28, 55);
            this.pictureBox23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(69, 71);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 7;
            this.pictureBox23.TabStop = false;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.numSkillMagicE2);
            this.groupBox14.Controls.Add(this.pictureBox18);
            this.groupBox14.Controls.Add(this.numSkillMagicE1);
            this.groupBox14.Controls.Add(this.pictureBox19);
            this.groupBox14.Controls.Add(this.numSkillMagicE0);
            this.groupBox14.Controls.Add(this.pictureBox20);
            this.groupBox14.Location = new System.Drawing.Point(9, 262);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox14.Size = new System.Drawing.Size(314, 243);
            this.groupBox14.TabIndex = 22;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Earth Magic";
            // 
            // numSkillMagicE2
            // 
            this.numSkillMagicE2.Location = new System.Drawing.Point(204, 135);
            this.numSkillMagicE2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicE2.Name = "numSkillMagicE2";
            this.numSkillMagicE2.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicE2.TabIndex = 10;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::SoG_SGreader.Properties.Resources.icon_swarm;
            this.pictureBox18.Location = new System.Drawing.Point(219, 55);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(69, 71);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 11;
            this.pictureBox18.TabStop = false;
            // 
            // numSkillMagicE1
            // 
            this.numSkillMagicE1.Location = new System.Drawing.Point(110, 135);
            this.numSkillMagicE1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicE1.Name = "numSkillMagicE1";
            this.numSkillMagicE1.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicE1.TabIndex = 8;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::SoG_SGreader.Properties.Resources.icon_plantsummon;
            this.pictureBox19.Location = new System.Drawing.Point(124, 55);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(69, 71);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 9;
            this.pictureBox19.TabStop = false;
            // 
            // numSkillMagicE0
            // 
            this.numSkillMagicE0.Location = new System.Drawing.Point(14, 135);
            this.numSkillMagicE0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicE0.Name = "numSkillMagicE0";
            this.numSkillMagicE0.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicE0.TabIndex = 6;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::SoG_SGreader.Properties.Resources.icon_earthspike;
            this.pictureBox20.Location = new System.Drawing.Point(28, 55);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(69, 71);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 7;
            this.pictureBox20.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.numSkillMagicI2);
            this.groupBox13.Controls.Add(this.pictureBox15);
            this.groupBox13.Controls.Add(this.numSkillMagicI1);
            this.groupBox13.Controls.Add(this.pictureBox16);
            this.groupBox13.Controls.Add(this.numSkillMagicI0);
            this.groupBox13.Controls.Add(this.pictureBox17);
            this.groupBox13.Location = new System.Drawing.Point(332, 9);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox13.Size = new System.Drawing.Size(314, 243);
            this.groupBox13.TabIndex = 22;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Ice Magic";
            // 
            // numSkillMagicI2
            // 
            this.numSkillMagicI2.Location = new System.Drawing.Point(204, 135);
            this.numSkillMagicI2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicI2.Name = "numSkillMagicI2";
            this.numSkillMagicI2.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicI2.TabIndex = 10;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::SoG_SGreader.Properties.Resources.icon_frosty;
            this.pictureBox15.Location = new System.Drawing.Point(219, 55);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(69, 71);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 11;
            this.pictureBox15.TabStop = false;
            // 
            // numSkillMagicI1
            // 
            this.numSkillMagicI1.Location = new System.Drawing.Point(110, 135);
            this.numSkillMagicI1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicI1.Name = "numSkillMagicI1";
            this.numSkillMagicI1.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicI1.TabIndex = 8;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::SoG_SGreader.Properties.Resources.icon_frostnova_clover;
            this.pictureBox16.Location = new System.Drawing.Point(124, 55);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(69, 71);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 9;
            this.pictureBox16.TabStop = false;
            // 
            // numSkillMagicI0
            // 
            this.numSkillMagicI0.Location = new System.Drawing.Point(14, 135);
            this.numSkillMagicI0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicI0.Name = "numSkillMagicI0";
            this.numSkillMagicI0.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicI0.TabIndex = 6;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::SoG_SGreader.Properties.Resources.icon_icespikes;
            this.pictureBox17.Location = new System.Drawing.Point(28, 55);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(69, 71);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 7;
            this.pictureBox17.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numSkillMagicF2);
            this.groupBox12.Controls.Add(this.pictureBox14);
            this.groupBox12.Controls.Add(this.numSkillMagicF1);
            this.groupBox12.Controls.Add(this.pictureBox13);
            this.groupBox12.Controls.Add(this.numSkillMagicF0);
            this.groupBox12.Controls.Add(this.pictureBox12);
            this.groupBox12.Location = new System.Drawing.Point(9, 9);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Size = new System.Drawing.Size(314, 243);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Fire Magic";
            // 
            // numSkillMagicF2
            // 
            this.numSkillMagicF2.Location = new System.Drawing.Point(204, 135);
            this.numSkillMagicF2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicF2.Name = "numSkillMagicF2";
            this.numSkillMagicF2.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicF2.TabIndex = 10;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::SoG_SGreader.Properties.Resources.icon_flamethrower;
            this.pictureBox14.Location = new System.Drawing.Point(219, 55);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(69, 71);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 11;
            this.pictureBox14.TabStop = false;
            // 
            // numSkillMagicF1
            // 
            this.numSkillMagicF1.Location = new System.Drawing.Point(110, 135);
            this.numSkillMagicF1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicF1.Name = "numSkillMagicF1";
            this.numSkillMagicF1.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicF1.TabIndex = 8;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::SoG_SGreader.Properties.Resources.icon_meteor;
            this.pictureBox13.Location = new System.Drawing.Point(124, 55);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(69, 71);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 9;
            this.pictureBox13.TabStop = false;
            // 
            // numSkillMagicF0
            // 
            this.numSkillMagicF0.Location = new System.Drawing.Point(14, 135);
            this.numSkillMagicF0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSkillMagicF0.Name = "numSkillMagicF0";
            this.numSkillMagicF0.Size = new System.Drawing.Size(100, 26);
            this.numSkillMagicF0.TabIndex = 6;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::SoG_SGreader.Properties.Resources.icon_fireball;
            this.pictureBox12.Location = new System.Drawing.Point(28, 55);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(69, 71);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 7;
            this.pictureBox12.TabStop = false;
            // 
            // tabSkillsUtility
            // 
            this.tabSkillsUtility.Controls.Add(this.groupBox18);
            this.tabSkillsUtility.Controls.Add(this.groupBox17);
            this.tabSkillsUtility.Controls.Add(this.groupBox16);
            this.tabSkillsUtility.Location = new System.Drawing.Point(104, 4);
            this.tabSkillsUtility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkillsUtility.Name = "tabSkillsUtility";
            this.tabSkillsUtility.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSkillsUtility.Size = new System.Drawing.Size(710, 554);
            this.tabSkillsUtility.TabIndex = 2;
            this.tabSkillsUtility.Text = "Skills: Utility";
            this.tabSkillsUtility.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.numUtilityE0);
            this.groupBox18.Controls.Add(this.pictureBox30);
            this.groupBox18.Controls.Add(this.numUtilityE1);
            this.groupBox18.Controls.Add(this.pictureBox31);
            this.groupBox18.Controls.Add(this.numUtilityE2);
            this.groupBox18.Controls.Add(this.pictureBox32);
            this.groupBox18.Location = new System.Drawing.Point(9, 389);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox18.Size = new System.Drawing.Size(638, 186);
            this.groupBox18.TabIndex = 22;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Enhancing";
            // 
            // numUtilityE0
            // 
            this.numUtilityE0.Location = new System.Drawing.Point(135, 105);
            this.numUtilityE0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityE0.Name = "numUtilityE0";
            this.numUtilityE0.Size = new System.Drawing.Size(118, 26);
            this.numUtilityE0.TabIndex = 0;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = global::SoG_SGreader.Properties.Resources.icon_dmgup;
            this.pictureBox30.Location = new System.Drawing.Point(160, 29);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(69, 71);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 1;
            this.pictureBox30.TabStop = false;
            // 
            // numUtilityE1
            // 
            this.numUtilityE1.Location = new System.Drawing.Point(262, 105);
            this.numUtilityE1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityE1.Name = "numUtilityE1";
            this.numUtilityE1.Size = new System.Drawing.Size(118, 26);
            this.numUtilityE1.TabIndex = 2;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = global::SoG_SGreader.Properties.Resources.icon_speedup;
            this.pictureBox31.Location = new System.Drawing.Point(288, 29);
            this.pictureBox31.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(69, 71);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox31.TabIndex = 3;
            this.pictureBox31.TabStop = false;
            // 
            // numUtilityE2
            // 
            this.numUtilityE2.Location = new System.Drawing.Point(381, 105);
            this.numUtilityE2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityE2.Name = "numUtilityE2";
            this.numUtilityE2.Size = new System.Drawing.Size(118, 26);
            this.numUtilityE2.TabIndex = 4;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = global::SoG_SGreader.Properties.Resources.icon_protect_clover;
            this.pictureBox32.Location = new System.Drawing.Point(406, 29);
            this.pictureBox32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(69, 71);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 5;
            this.pictureBox32.TabStop = false;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.numUtilityD0);
            this.groupBox17.Controls.Add(this.pictureBox27);
            this.groupBox17.Controls.Add(this.numUtilityD1);
            this.groupBox17.Controls.Add(this.pictureBox28);
            this.groupBox17.Controls.Add(this.numUtilityD2);
            this.groupBox17.Controls.Add(this.pictureBox29);
            this.groupBox17.Location = new System.Drawing.Point(9, 195);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox17.Size = new System.Drawing.Size(638, 186);
            this.groupBox17.TabIndex = 22;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Defensive";
            // 
            // numUtilityD0
            // 
            this.numUtilityD0.Location = new System.Drawing.Point(135, 105);
            this.numUtilityD0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityD0.Name = "numUtilityD0";
            this.numUtilityD0.Size = new System.Drawing.Size(118, 26);
            this.numUtilityD0.TabIndex = 0;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::SoG_SGreader.Properties.Resources.icon_utility_blink;
            this.pictureBox27.Location = new System.Drawing.Point(160, 29);
            this.pictureBox27.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(69, 71);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 1;
            this.pictureBox27.TabStop = false;
            // 
            // numUtilityD1
            // 
            this.numUtilityD1.Location = new System.Drawing.Point(262, 105);
            this.numUtilityD1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityD1.Name = "numUtilityD1";
            this.numUtilityD1.Size = new System.Drawing.Size(118, 26);
            this.numUtilityD1.TabIndex = 2;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = global::SoG_SGreader.Properties.Resources.icon_utility_focus;
            this.pictureBox28.Location = new System.Drawing.Point(288, 29);
            this.pictureBox28.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(69, 71);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 3;
            this.pictureBox28.TabStop = false;
            // 
            // numUtilityD2
            // 
            this.numUtilityD2.Location = new System.Drawing.Point(381, 105);
            this.numUtilityD2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityD2.Name = "numUtilityD2";
            this.numUtilityD2.Size = new System.Drawing.Size(118, 26);
            this.numUtilityD2.TabIndex = 4;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = global::SoG_SGreader.Properties.Resources.icon_utility_barrier;
            this.pictureBox29.Location = new System.Drawing.Point(406, 29);
            this.pictureBox29.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(69, 71);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox29.TabIndex = 5;
            this.pictureBox29.TabStop = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.numUtilityO0);
            this.groupBox16.Controls.Add(this.pictureBox24);
            this.groupBox16.Controls.Add(this.numUtilityO1);
            this.groupBox16.Controls.Add(this.pictureBox25);
            this.groupBox16.Controls.Add(this.numUtilityO2);
            this.groupBox16.Controls.Add(this.pictureBox26);
            this.groupBox16.Location = new System.Drawing.Point(9, 9);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox16.Size = new System.Drawing.Size(638, 186);
            this.groupBox16.TabIndex = 21;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Offensive";
            // 
            // numUtilityO0
            // 
            this.numUtilityO0.Location = new System.Drawing.Point(135, 105);
            this.numUtilityO0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityO0.Name = "numUtilityO0";
            this.numUtilityO0.Size = new System.Drawing.Size(118, 26);
            this.numUtilityO0.TabIndex = 0;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::SoG_SGreader.Properties.Resources.icon_utility_deathmark;
            this.pictureBox24.Location = new System.Drawing.Point(160, 29);
            this.pictureBox24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(69, 71);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 1;
            this.pictureBox24.TabStop = false;
            // 
            // numUtilityO1
            // 
            this.numUtilityO1.Location = new System.Drawing.Point(262, 105);
            this.numUtilityO1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityO1.Name = "numUtilityO1";
            this.numUtilityO1.Size = new System.Drawing.Size(118, 26);
            this.numUtilityO1.TabIndex = 2;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = global::SoG_SGreader.Properties.Resources.icon_utility_sleep;
            this.pictureBox25.Location = new System.Drawing.Point(288, 29);
            this.pictureBox25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(69, 71);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 3;
            this.pictureBox25.TabStop = false;
            // 
            // numUtilityO2
            // 
            this.numUtilityO2.Location = new System.Drawing.Point(381, 105);
            this.numUtilityO2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUtilityO2.Name = "numUtilityO2";
            this.numUtilityO2.Size = new System.Drawing.Size(118, 26);
            this.numUtilityO2.TabIndex = 4;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::SoG_SGreader.Properties.Resources.icon_utility_taunt;
            this.pictureBox26.Location = new System.Drawing.Point(406, 29);
            this.pictureBox26.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(69, 71);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 5;
            this.pictureBox26.TabStop = false;
            // 
            // tabTalentsMelee
            // 
            this.tabTalentsMelee.Controls.Add(this.groupBox3);
            this.tabTalentsMelee.Location = new System.Drawing.Point(104, 4);
            this.tabTalentsMelee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTalentsMelee.Name = "tabTalentsMelee";
            this.tabTalentsMelee.Size = new System.Drawing.Size(710, 554);
            this.tabTalentsMelee.TabIndex = 3;
            this.tabTalentsMelee.Text = "Talents: Melee";
            this.tabTalentsMelee.UseVisualStyleBackColor = true;
            // 
            // tabTalentsMagic
            // 
            this.tabTalentsMagic.Controls.Add(this.groupBox4);
            this.tabTalentsMagic.Location = new System.Drawing.Point(104, 4);
            this.tabTalentsMagic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTalentsMagic.Name = "tabTalentsMagic";
            this.tabTalentsMagic.Size = new System.Drawing.Size(710, 554);
            this.tabTalentsMagic.TabIndex = 4;
            this.tabTalentsMagic.Text = "Talents: Magic";
            this.tabTalentsMagic.UseVisualStyleBackColor = true;
            // 
            // tabTalentsGeneral
            // 
            this.tabTalentsGeneral.Controls.Add(this.groupBox5);
            this.tabTalentsGeneral.Location = new System.Drawing.Point(104, 4);
            this.tabTalentsGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTalentsGeneral.Name = "tabTalentsGeneral";
            this.tabTalentsGeneral.Size = new System.Drawing.Size(710, 554);
            this.tabTalentsGeneral.TabIndex = 5;
            this.tabTalentsGeneral.Text = "Talents: General";
            this.tabTalentsGeneral.UseVisualStyleBackColor = true;
            // 
            // tabCards
            // 
            this.tabCards.Controls.Add(this.grpCards);
            this.tabCards.Controls.Add(this.cblstCards);
            this.tabCards.Location = new System.Drawing.Point(4, 29);
            this.tabCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCards.Name = "tabCards";
            this.tabCards.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCards.Size = new System.Drawing.Size(842, 616);
            this.tabCards.TabIndex = 5;
            this.tabCards.Text = "Cards";
            this.tabCards.UseVisualStyleBackColor = true;
            // 
            // grpCards
            // 
            this.grpCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCards.Controls.Add(this.lblCardsNullWarning);
            this.grpCards.Controls.Add(this.btnSelectAllCards);
            this.grpCards.Controls.Add(this.btnResetCards);
            this.grpCards.Controls.Add(this.btnDeselectAllCards);
            this.grpCards.Location = new System.Drawing.Point(681, 9);
            this.grpCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCards.Name = "grpCards";
            this.grpCards.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCards.Size = new System.Drawing.Size(146, 583);
            this.grpCards.TabIndex = 6;
            this.grpCards.TabStop = false;
            this.grpCards.Text = "Cards";
            // 
            // lblCardsNullWarning
            // 
            this.lblCardsNullWarning.AutoSize = true;
            this.lblCardsNullWarning.Location = new System.Drawing.Point(9, 114);
            this.lblCardsNullWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardsNullWarning.Name = "lblCardsNullWarning";
            this.lblCardsNullWarning.Size = new System.Drawing.Size(106, 80);
            this.lblCardsNullWarning.TabIndex = 7;
            this.lblCardsNullWarning.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllCards
            // 
            this.btnSelectAllCards.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllCards.Name = "btnSelectAllCards";
            this.btnSelectAllCards.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllCards.TabIndex = 3;
            this.btnSelectAllCards.Text = "Select all";
            this.btnSelectAllCards.UseVisualStyleBackColor = true;
            this.btnSelectAllCards.Click += new System.EventHandler(this.btnSelectAllCards_Click);
            // 
            // btnResetCards
            // 
            this.btnResetCards.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetCards.Location = new System.Drawing.Point(9, 538);
            this.btnResetCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetCards.Name = "btnResetCards";
            this.btnResetCards.Size = new System.Drawing.Size(130, 35);
            this.btnResetCards.TabIndex = 5;
            this.btnResetCards.Text = "Reset";
            this.btnResetCards.UseVisualStyleBackColor = true;
            this.btnResetCards.Click += new System.EventHandler(this.btnResetCards_Click);
            // 
            // btnDeselectAllCards
            // 
            this.btnDeselectAllCards.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllCards.Name = "btnDeselectAllCards";
            this.btnDeselectAllCards.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllCards.TabIndex = 4;
            this.btnDeselectAllCards.Text = "Deselect all";
            this.btnDeselectAllCards.UseVisualStyleBackColor = true;
            this.btnDeselectAllCards.Click += new System.EventHandler(this.btnDeselectAllCards_Click);
            // 
            // cblstCards
            // 
            this.cblstCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstCards.FormattingEnabled = true;
            this.cblstCards.Location = new System.Drawing.Point(9, 9);
            this.cblstCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstCards.Name = "cblstCards";
            this.cblstCards.Size = new System.Drawing.Size(661, 579);
            this.cblstCards.TabIndex = 2;
            // 
            // tabMaps
            // 
            this.tabMaps.Controls.Add(this.grpMaps);
            this.tabMaps.Controls.Add(this.cblstMaps);
            this.tabMaps.Location = new System.Drawing.Point(4, 29);
            this.tabMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMaps.Name = "tabMaps";
            this.tabMaps.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMaps.Size = new System.Drawing.Size(842, 616);
            this.tabMaps.TabIndex = 10;
            this.tabMaps.Text = "Maps";
            this.tabMaps.UseVisualStyleBackColor = true;
            // 
            // grpMaps
            // 
            this.grpMaps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaps.Controls.Add(this.lblMapsNullWarning);
            this.grpMaps.Controls.Add(this.btnSelectAllMaps);
            this.grpMaps.Controls.Add(this.btnResetMaps);
            this.grpMaps.Controls.Add(this.btnDeselectAllMaps);
            this.grpMaps.Location = new System.Drawing.Point(681, 9);
            this.grpMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMaps.Name = "grpMaps";
            this.grpMaps.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMaps.Size = new System.Drawing.Size(146, 583);
            this.grpMaps.TabIndex = 8;
            this.grpMaps.TabStop = false;
            this.grpMaps.Text = "Maps";
            // 
            // lblMapsNullWarning
            // 
            this.lblMapsNullWarning.AutoSize = true;
            this.lblMapsNullWarning.Location = new System.Drawing.Point(9, 114);
            this.lblMapsNullWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMapsNullWarning.Name = "lblMapsNullWarning";
            this.lblMapsNullWarning.Size = new System.Drawing.Size(106, 80);
            this.lblMapsNullWarning.TabIndex = 8;
            this.lblMapsNullWarning.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllMaps
            // 
            this.btnSelectAllMaps.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllMaps.Name = "btnSelectAllMaps";
            this.btnSelectAllMaps.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllMaps.TabIndex = 3;
            this.btnSelectAllMaps.Text = "Select all";
            this.btnSelectAllMaps.UseVisualStyleBackColor = true;
            this.btnSelectAllMaps.Click += new System.EventHandler(this.btnSelectAllMaps_Click);
            // 
            // btnResetMaps
            // 
            this.btnResetMaps.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetMaps.Location = new System.Drawing.Point(9, 538);
            this.btnResetMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetMaps.Name = "btnResetMaps";
            this.btnResetMaps.Size = new System.Drawing.Size(130, 35);
            this.btnResetMaps.TabIndex = 5;
            this.btnResetMaps.Text = "Reset";
            this.btnResetMaps.UseVisualStyleBackColor = true;
            this.btnResetMaps.Click += new System.EventHandler(this.btnResetMaps_Click);
            // 
            // btnDeselectAllMaps
            // 
            this.btnDeselectAllMaps.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllMaps.Name = "btnDeselectAllMaps";
            this.btnDeselectAllMaps.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllMaps.TabIndex = 4;
            this.btnDeselectAllMaps.Text = "Deselect all";
            this.btnDeselectAllMaps.UseVisualStyleBackColor = true;
            this.btnDeselectAllMaps.Click += new System.EventHandler(this.btnDeselectAllMaps_Click);
            // 
            // cblstMaps
            // 
            this.cblstMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstMaps.FormattingEnabled = true;
            this.cblstMaps.Location = new System.Drawing.Point(9, 9);
            this.cblstMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstMaps.Name = "cblstMaps";
            this.cblstMaps.Size = new System.Drawing.Size(661, 579);
            this.cblstMaps.TabIndex = 7;
            // 
            // tabQuests
            // 
            this.tabQuests.Controls.Add(this.grpQuests);
            this.tabQuests.Controls.Add(this.cblstQuests);
            this.tabQuests.Location = new System.Drawing.Point(4, 29);
            this.tabQuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuests.Name = "tabQuests";
            this.tabQuests.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuests.Size = new System.Drawing.Size(842, 616);
            this.tabQuests.TabIndex = 9;
            this.tabQuests.Text = "Quests";
            this.tabQuests.UseVisualStyleBackColor = true;
            // 
            // grpQuests
            // 
            this.grpQuests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuests.Controls.Add(this.lblQuestsChaningNoEffect);
            this.grpQuests.Controls.Add(this.lblQuestsNullWarning);
            this.grpQuests.Controls.Add(this.btnSelectAllQuests);
            this.grpQuests.Controls.Add(this.btnResetQuests);
            this.grpQuests.Controls.Add(this.btnDeselectAllQuests);
            this.grpQuests.Location = new System.Drawing.Point(681, 9);
            this.grpQuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpQuests.Name = "grpQuests";
            this.grpQuests.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpQuests.Size = new System.Drawing.Size(146, 583);
            this.grpQuests.TabIndex = 8;
            this.grpQuests.TabStop = false;
            this.grpQuests.Text = "Quests";
            // 
            // lblQuestsChaningNoEffect
            // 
            this.lblQuestsChaningNoEffect.AutoSize = true;
            this.lblQuestsChaningNoEffect.Location = new System.Drawing.Point(9, 286);
            this.lblQuestsChaningNoEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestsChaningNoEffect.Name = "lblQuestsChaningNoEffect";
            this.lblQuestsChaningNoEffect.Size = new System.Drawing.Size(132, 160);
            this.lblQuestsChaningNoEffect.TabIndex = 10;
            this.lblQuestsChaningNoEffect.Text = "Changing Quests\r\nmay have no \r\neffect on your\r\ngame since\r\nthese are addi-\r\ntiona" +
    "lly saved\r\nin the World \r\nfiles.";
            // 
            // lblQuestsNullWarning
            // 
            this.lblQuestsNullWarning.AutoSize = true;
            this.lblQuestsNullWarning.Location = new System.Drawing.Point(9, 114);
            this.lblQuestsNullWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestsNullWarning.Name = "lblQuestsNullWarning";
            this.lblQuestsNullWarning.Size = new System.Drawing.Size(106, 80);
            this.lblQuestsNullWarning.TabIndex = 8;
            this.lblQuestsNullWarning.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllQuests
            // 
            this.btnSelectAllQuests.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllQuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllQuests.Name = "btnSelectAllQuests";
            this.btnSelectAllQuests.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllQuests.TabIndex = 3;
            this.btnSelectAllQuests.Text = "Select all";
            this.btnSelectAllQuests.UseVisualStyleBackColor = true;
            this.btnSelectAllQuests.Click += new System.EventHandler(this.btnSelectAllQuests_Click);
            // 
            // btnResetQuests
            // 
            this.btnResetQuests.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetQuests.Location = new System.Drawing.Point(9, 538);
            this.btnResetQuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetQuests.Name = "btnResetQuests";
            this.btnResetQuests.Size = new System.Drawing.Size(130, 35);
            this.btnResetQuests.TabIndex = 5;
            this.btnResetQuests.Text = "Reset";
            this.btnResetQuests.UseVisualStyleBackColor = true;
            this.btnResetQuests.Click += new System.EventHandler(this.btnResetQuests_Click);
            // 
            // btnDeselectAllQuests
            // 
            this.btnDeselectAllQuests.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllQuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllQuests.Name = "btnDeselectAllQuests";
            this.btnDeselectAllQuests.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllQuests.TabIndex = 4;
            this.btnDeselectAllQuests.Text = "Deselect all";
            this.btnDeselectAllQuests.UseVisualStyleBackColor = true;
            this.btnDeselectAllQuests.Click += new System.EventHandler(this.btnDeselectAllQuests_Click);
            // 
            // cblstQuests
            // 
            this.cblstQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstQuests.FormattingEnabled = true;
            this.cblstQuests.Location = new System.Drawing.Point(9, 9);
            this.cblstQuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstQuests.Name = "cblstQuests";
            this.cblstQuests.Size = new System.Drawing.Size(661, 579);
            this.cblstQuests.TabIndex = 7;
            // 
            // tabFlags
            // 
            this.tabFlags.Controls.Add(this.cblstFlagsChecked);
            this.tabFlags.Controls.Add(this.grpFlags);
            this.tabFlags.Controls.Add(this.cblstFlags);
            this.tabFlags.Location = new System.Drawing.Point(4, 29);
            this.tabFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFlags.Name = "tabFlags";
            this.tabFlags.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFlags.Size = new System.Drawing.Size(842, 616);
            this.tabFlags.TabIndex = 6;
            this.tabFlags.Text = "Flags";
            this.tabFlags.UseVisualStyleBackColor = true;
            // 
            // cblstFlagsChecked
            // 
            this.cblstFlagsChecked.Enabled = false;
            this.cblstFlagsChecked.FormattingEnabled = true;
            this.cblstFlagsChecked.Location = new System.Drawing.Point(12, 375);
            this.cblstFlagsChecked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstFlagsChecked.Name = "cblstFlagsChecked";
            this.cblstFlagsChecked.Size = new System.Drawing.Size(658, 211);
            this.cblstFlagsChecked.TabIndex = 11;
            this.cblstFlagsChecked.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblstFlagsChecked_ItemCheck);
            // 
            // grpFlags
            // 
            this.grpFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFlags.Controls.Add(this.lblFlagsChaningNoEffect);
            this.grpFlags.Controls.Add(this.label41);
            this.grpFlags.Controls.Add(this.btnSelectAllFlags);
            this.grpFlags.Controls.Add(this.btnResetFlags);
            this.grpFlags.Controls.Add(this.btnDeselectAllFlags);
            this.grpFlags.Location = new System.Drawing.Point(681, 9);
            this.grpFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlags.Size = new System.Drawing.Size(146, 583);
            this.grpFlags.TabIndex = 10;
            this.grpFlags.TabStop = false;
            this.grpFlags.Text = "Flags";
            // 
            // lblFlagsChaningNoEffect
            // 
            this.lblFlagsChaningNoEffect.AutoSize = true;
            this.lblFlagsChaningNoEffect.Location = new System.Drawing.Point(9, 286);
            this.lblFlagsChaningNoEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlagsChaningNoEffect.Name = "lblFlagsChaningNoEffect";
            this.lblFlagsChaningNoEffect.Size = new System.Drawing.Size(120, 160);
            this.lblFlagsChaningNoEffect.TabIndex = 9;
            this.lblFlagsChaningNoEffect.Text = "Changing Flags\r\nmay have no \r\neffect on your\r\ngame since\r\nthese are addi-\r\ntional" +
    "ly saved\r\nin the World \r\nfiles.";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 114);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(106, 80);
            this.label41.TabIndex = 8;
            this.label41.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllFlags
            // 
            this.btnSelectAllFlags.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllFlags.Name = "btnSelectAllFlags";
            this.btnSelectAllFlags.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllFlags.TabIndex = 3;
            this.btnSelectAllFlags.Text = "Select all";
            this.btnSelectAllFlags.UseVisualStyleBackColor = true;
            this.btnSelectAllFlags.Click += new System.EventHandler(this.btnSelectAllFlags_Click);
            // 
            // btnResetFlags
            // 
            this.btnResetFlags.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetFlags.Location = new System.Drawing.Point(9, 538);
            this.btnResetFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetFlags.Name = "btnResetFlags";
            this.btnResetFlags.Size = new System.Drawing.Size(130, 35);
            this.btnResetFlags.TabIndex = 5;
            this.btnResetFlags.Text = "Reset";
            this.btnResetFlags.UseVisualStyleBackColor = true;
            this.btnResetFlags.Click += new System.EventHandler(this.btnResetFlags_Click);
            // 
            // btnDeselectAllFlags
            // 
            this.btnDeselectAllFlags.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllFlags.Name = "btnDeselectAllFlags";
            this.btnDeselectAllFlags.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllFlags.TabIndex = 4;
            this.btnDeselectAllFlags.Text = "Deselect all";
            this.btnDeselectAllFlags.UseVisualStyleBackColor = true;
            this.btnDeselectAllFlags.Click += new System.EventHandler(this.btnDeselectAllFlags_Click);
            // 
            // cblstFlags
            // 
            this.cblstFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstFlags.FormattingEnabled = true;
            this.cblstFlags.Location = new System.Drawing.Point(9, 9);
            this.cblstFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstFlags.Name = "cblstFlags";
            this.cblstFlags.Size = new System.Drawing.Size(661, 349);
            this.cblstFlags.TabIndex = 9;
            this.cblstFlags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblstFlags_ItemCheck);
            // 
            // tabTrophies
            // 
            this.tabTrophies.Controls.Add(this.grpTrophies);
            this.tabTrophies.Controls.Add(this.cblstTrophies);
            this.tabTrophies.Location = new System.Drawing.Point(4, 29);
            this.tabTrophies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTrophies.Name = "tabTrophies";
            this.tabTrophies.Size = new System.Drawing.Size(842, 616);
            this.tabTrophies.TabIndex = 11;
            this.tabTrophies.Text = "Trophies";
            this.tabTrophies.UseVisualStyleBackColor = true;
            // 
            // grpTrophies
            // 
            this.grpTrophies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTrophies.Controls.Add(this.label59);
            this.grpTrophies.Controls.Add(this.btnSelectAllTrophies);
            this.grpTrophies.Controls.Add(this.btnResetTrophies);
            this.grpTrophies.Controls.Add(this.btnDeselectAllTrophies);
            this.grpTrophies.Location = new System.Drawing.Point(681, 9);
            this.grpTrophies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTrophies.Name = "grpTrophies";
            this.grpTrophies.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTrophies.Size = new System.Drawing.Size(146, 583);
            this.grpTrophies.TabIndex = 12;
            this.grpTrophies.TabStop = false;
            this.grpTrophies.Text = "Trophies";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(9, 114);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(106, 80);
            this.label59.TabIndex = 8;
            this.label59.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllTrophies
            // 
            this.btnSelectAllTrophies.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllTrophies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllTrophies.Name = "btnSelectAllTrophies";
            this.btnSelectAllTrophies.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllTrophies.TabIndex = 3;
            this.btnSelectAllTrophies.Text = "Select all";
            this.btnSelectAllTrophies.UseVisualStyleBackColor = true;
            this.btnSelectAllTrophies.Click += new System.EventHandler(this.btnSelectAllTrophies_Click);
            // 
            // btnResetTrophies
            // 
            this.btnResetTrophies.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetTrophies.Location = new System.Drawing.Point(9, 538);
            this.btnResetTrophies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetTrophies.Name = "btnResetTrophies";
            this.btnResetTrophies.Size = new System.Drawing.Size(130, 35);
            this.btnResetTrophies.TabIndex = 5;
            this.btnResetTrophies.Text = "Reset";
            this.btnResetTrophies.UseVisualStyleBackColor = true;
            this.btnResetTrophies.Click += new System.EventHandler(this.btnResetTrophies_Click);
            // 
            // btnDeselectAllTrophies
            // 
            this.btnDeselectAllTrophies.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllTrophies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllTrophies.Name = "btnDeselectAllTrophies";
            this.btnDeselectAllTrophies.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllTrophies.TabIndex = 4;
            this.btnDeselectAllTrophies.Text = "Deselect all";
            this.btnDeselectAllTrophies.UseVisualStyleBackColor = true;
            this.btnDeselectAllTrophies.Click += new System.EventHandler(this.btnDeselectAllTrophies_Click);
            // 
            // cblstTrophies
            // 
            this.cblstTrophies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstTrophies.FormattingEnabled = true;
            this.cblstTrophies.Location = new System.Drawing.Point(9, 9);
            this.cblstTrophies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstTrophies.Name = "cblstTrophies";
            this.cblstTrophies.Size = new System.Drawing.Size(661, 579);
            this.cblstTrophies.TabIndex = 11;
            // 
            // tabFishCaught
            // 
            this.tabFishCaught.Controls.Add(this.groupBox2);
            this.tabFishCaught.Controls.Add(this.cblstFishCaught);
            this.tabFishCaught.Location = new System.Drawing.Point(4, 29);
            this.tabFishCaught.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFishCaught.Name = "tabFishCaught";
            this.tabFishCaught.Size = new System.Drawing.Size(842, 616);
            this.tabFishCaught.TabIndex = 14;
            this.tabFishCaught.Text = "Fish Caught";
            this.tabFishCaught.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblFishNullWarning);
            this.groupBox2.Controls.Add(this.btnSelectAllFishCaught);
            this.groupBox2.Controls.Add(this.btnResetFishCaught);
            this.groupBox2.Controls.Add(this.btnDeselectAllFishCaught);
            this.groupBox2.Location = new System.Drawing.Point(681, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(146, 583);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fish Caught";
            // 
            // lblFishNullWarning
            // 
            this.lblFishNullWarning.AutoSize = true;
            this.lblFishNullWarning.Location = new System.Drawing.Point(9, 114);
            this.lblFishNullWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFishNullWarning.Name = "lblFishNullWarning";
            this.lblFishNullWarning.Size = new System.Drawing.Size(106, 80);
            this.lblFishNullWarning.TabIndex = 8;
            this.lblFishNullWarning.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllFishCaught
            // 
            this.btnSelectAllFishCaught.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllFishCaught.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllFishCaught.Name = "btnSelectAllFishCaught";
            this.btnSelectAllFishCaught.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllFishCaught.TabIndex = 3;
            this.btnSelectAllFishCaught.Text = "Select all";
            this.btnSelectAllFishCaught.UseVisualStyleBackColor = true;
            this.btnSelectAllFishCaught.Click += new System.EventHandler(this.btnSelectAllFishCaught_Click);
            // 
            // btnResetFishCaught
            // 
            this.btnResetFishCaught.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetFishCaught.Location = new System.Drawing.Point(9, 538);
            this.btnResetFishCaught.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetFishCaught.Name = "btnResetFishCaught";
            this.btnResetFishCaught.Size = new System.Drawing.Size(130, 35);
            this.btnResetFishCaught.TabIndex = 5;
            this.btnResetFishCaught.Text = "Reset";
            this.btnResetFishCaught.UseVisualStyleBackColor = true;
            this.btnResetFishCaught.Click += new System.EventHandler(this.btnResetFishCaught_Click);
            // 
            // btnDeselectAllFishCaught
            // 
            this.btnDeselectAllFishCaught.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllFishCaught.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllFishCaught.Name = "btnDeselectAllFishCaught";
            this.btnDeselectAllFishCaught.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllFishCaught.TabIndex = 4;
            this.btnDeselectAllFishCaught.Text = "Deselect all";
            this.btnDeselectAllFishCaught.UseVisualStyleBackColor = true;
            this.btnDeselectAllFishCaught.Click += new System.EventHandler(this.btnDeselectAllFishCaught_Click);
            // 
            // cblstFishCaught
            // 
            this.cblstFishCaught.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstFishCaught.FormattingEnabled = true;
            this.cblstFishCaught.Location = new System.Drawing.Point(9, 9);
            this.cblstFishCaught.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstFishCaught.Name = "cblstFishCaught";
            this.cblstFishCaught.Size = new System.Drawing.Size(661, 579);
            this.cblstFishCaught.TabIndex = 17;
            // 
            // tabEnemiesSeen
            // 
            this.tabEnemiesSeen.Controls.Add(this.grpEnemiesSeen);
            this.tabEnemiesSeen.Controls.Add(this.cblstEnemiesSeens);
            this.tabEnemiesSeen.Location = new System.Drawing.Point(4, 29);
            this.tabEnemiesSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEnemiesSeen.Name = "tabEnemiesSeen";
            this.tabEnemiesSeen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEnemiesSeen.Size = new System.Drawing.Size(842, 616);
            this.tabEnemiesSeen.TabIndex = 4;
            this.tabEnemiesSeen.Text = "Enemies seen";
            this.tabEnemiesSeen.UseVisualStyleBackColor = true;
            // 
            // grpEnemiesSeen
            // 
            this.grpEnemiesSeen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEnemiesSeen.Controls.Add(this.lblEnemiesSeenNullWarning);
            this.grpEnemiesSeen.Controls.Add(this.btnSelectAllEnemiesSeen);
            this.grpEnemiesSeen.Controls.Add(this.btnResetEnemiesSeen);
            this.grpEnemiesSeen.Controls.Add(this.btnDeselectAllEnemiesSeen);
            this.grpEnemiesSeen.Location = new System.Drawing.Point(681, 9);
            this.grpEnemiesSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnemiesSeen.Name = "grpEnemiesSeen";
            this.grpEnemiesSeen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnemiesSeen.Size = new System.Drawing.Size(146, 583);
            this.grpEnemiesSeen.TabIndex = 10;
            this.grpEnemiesSeen.TabStop = false;
            this.grpEnemiesSeen.Text = "Enemies seen";
            // 
            // lblEnemiesSeenNullWarning
            // 
            this.lblEnemiesSeenNullWarning.AutoSize = true;
            this.lblEnemiesSeenNullWarning.Location = new System.Drawing.Point(9, 114);
            this.lblEnemiesSeenNullWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemiesSeenNullWarning.Name = "lblEnemiesSeenNullWarning";
            this.lblEnemiesSeenNullWarning.Size = new System.Drawing.Size(106, 80);
            this.lblEnemiesSeenNullWarning.TabIndex = 8;
            this.lblEnemiesSeenNullWarning.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllEnemiesSeen
            // 
            this.btnSelectAllEnemiesSeen.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllEnemiesSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllEnemiesSeen.Name = "btnSelectAllEnemiesSeen";
            this.btnSelectAllEnemiesSeen.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllEnemiesSeen.TabIndex = 3;
            this.btnSelectAllEnemiesSeen.Text = "Select all";
            this.btnSelectAllEnemiesSeen.UseVisualStyleBackColor = true;
            this.btnSelectAllEnemiesSeen.Click += new System.EventHandler(this.btnSelectAllEnemiesSeen_Click);
            // 
            // btnResetEnemiesSeen
            // 
            this.btnResetEnemiesSeen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetEnemiesSeen.Location = new System.Drawing.Point(9, 538);
            this.btnResetEnemiesSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetEnemiesSeen.Name = "btnResetEnemiesSeen";
            this.btnResetEnemiesSeen.Size = new System.Drawing.Size(130, 35);
            this.btnResetEnemiesSeen.TabIndex = 5;
            this.btnResetEnemiesSeen.Text = "Reset";
            this.btnResetEnemiesSeen.UseVisualStyleBackColor = true;
            this.btnResetEnemiesSeen.Click += new System.EventHandler(this.btnResetEnemiesSeen_Click);
            // 
            // btnDeselectAllEnemiesSeen
            // 
            this.btnDeselectAllEnemiesSeen.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllEnemiesSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllEnemiesSeen.Name = "btnDeselectAllEnemiesSeen";
            this.btnDeselectAllEnemiesSeen.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllEnemiesSeen.TabIndex = 4;
            this.btnDeselectAllEnemiesSeen.Text = "Deselect all";
            this.btnDeselectAllEnemiesSeen.UseVisualStyleBackColor = true;
            this.btnDeselectAllEnemiesSeen.Click += new System.EventHandler(this.btnDeselectAllEnemiesSeen_Click);
            // 
            // cblstEnemiesSeens
            // 
            this.cblstEnemiesSeens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstEnemiesSeens.FormattingEnabled = true;
            this.cblstEnemiesSeens.Location = new System.Drawing.Point(9, 9);
            this.cblstEnemiesSeens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstEnemiesSeens.Name = "cblstEnemiesSeens";
            this.cblstEnemiesSeens.Size = new System.Drawing.Size(661, 579);
            this.cblstEnemiesSeens.TabIndex = 9;
            // 
            // tabItemsSeen
            // 
            this.tabItemsSeen.Controls.Add(this.grpItemsSeen);
            this.tabItemsSeen.Controls.Add(this.cblstItemsSeen);
            this.tabItemsSeen.Location = new System.Drawing.Point(4, 29);
            this.tabItemsSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabItemsSeen.Name = "tabItemsSeen";
            this.tabItemsSeen.Size = new System.Drawing.Size(842, 616);
            this.tabItemsSeen.TabIndex = 12;
            this.tabItemsSeen.Text = "Items Seen";
            this.tabItemsSeen.UseVisualStyleBackColor = true;
            // 
            // grpItemsSeen
            // 
            this.grpItemsSeen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpItemsSeen.Controls.Add(this.lblItemsSeenNullWarning);
            this.grpItemsSeen.Controls.Add(this.btnSelectAllItemsSeen);
            this.grpItemsSeen.Controls.Add(this.btnResetItemsSeen);
            this.grpItemsSeen.Controls.Add(this.btnDeselectAllItemsSeen);
            this.grpItemsSeen.Location = new System.Drawing.Point(681, 9);
            this.grpItemsSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpItemsSeen.Name = "grpItemsSeen";
            this.grpItemsSeen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpItemsSeen.Size = new System.Drawing.Size(146, 583);
            this.grpItemsSeen.TabIndex = 14;
            this.grpItemsSeen.TabStop = false;
            this.grpItemsSeen.Text = "Items Seen";
            // 
            // lblItemsSeenNullWarning
            // 
            this.lblItemsSeenNullWarning.AutoSize = true;
            this.lblItemsSeenNullWarning.Location = new System.Drawing.Point(9, 114);
            this.lblItemsSeenNullWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsSeenNullWarning.Name = "lblItemsSeenNullWarning";
            this.lblItemsSeenNullWarning.Size = new System.Drawing.Size(106, 80);
            this.lblItemsSeenNullWarning.TabIndex = 8;
            this.lblItemsSeenNullWarning.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllItemsSeen
            // 
            this.btnSelectAllItemsSeen.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllItemsSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllItemsSeen.Name = "btnSelectAllItemsSeen";
            this.btnSelectAllItemsSeen.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllItemsSeen.TabIndex = 3;
            this.btnSelectAllItemsSeen.Text = "Select all";
            this.btnSelectAllItemsSeen.UseVisualStyleBackColor = true;
            this.btnSelectAllItemsSeen.Click += new System.EventHandler(this.btnSelectAllItemsSeen_Click);
            // 
            // btnResetItemsSeen
            // 
            this.btnResetItemsSeen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetItemsSeen.Location = new System.Drawing.Point(9, 538);
            this.btnResetItemsSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetItemsSeen.Name = "btnResetItemsSeen";
            this.btnResetItemsSeen.Size = new System.Drawing.Size(130, 35);
            this.btnResetItemsSeen.TabIndex = 5;
            this.btnResetItemsSeen.Text = "Reset";
            this.btnResetItemsSeen.UseVisualStyleBackColor = true;
            this.btnResetItemsSeen.Click += new System.EventHandler(this.btnResetItemsSeen_Click);
            // 
            // btnDeselectAllItemsSeen
            // 
            this.btnDeselectAllItemsSeen.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllItemsSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllItemsSeen.Name = "btnDeselectAllItemsSeen";
            this.btnDeselectAllItemsSeen.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllItemsSeen.TabIndex = 4;
            this.btnDeselectAllItemsSeen.Text = "Deselect all";
            this.btnDeselectAllItemsSeen.UseVisualStyleBackColor = true;
            this.btnDeselectAllItemsSeen.Click += new System.EventHandler(this.btnDeselectAllItemsSeen_Click);
            // 
            // cblstItemsSeen
            // 
            this.cblstItemsSeen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstItemsSeen.FormattingEnabled = true;
            this.cblstItemsSeen.Location = new System.Drawing.Point(9, 9);
            this.cblstItemsSeen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstItemsSeen.Name = "cblstItemsSeen";
            this.cblstItemsSeen.Size = new System.Drawing.Size(661, 579);
            this.cblstItemsSeen.TabIndex = 13;
            // 
            // tabItemsCrafted
            // 
            this.tabItemsCrafted.Controls.Add(this.groupBox1);
            this.tabItemsCrafted.Controls.Add(this.cblstItemsCrafted);
            this.tabItemsCrafted.Location = new System.Drawing.Point(4, 29);
            this.tabItemsCrafted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabItemsCrafted.Name = "tabItemsCrafted";
            this.tabItemsCrafted.Size = new System.Drawing.Size(842, 616);
            this.tabItemsCrafted.TabIndex = 13;
            this.tabItemsCrafted.Text = "Items Crafted";
            this.tabItemsCrafted.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblItemsCraftedNullWarning);
            this.groupBox1.Controls.Add(this.btnSelectAllItemsCrafted);
            this.groupBox1.Controls.Add(this.btnResetItemsCrafted);
            this.groupBox1.Controls.Add(this.btnDeselectAllItemsCrafted);
            this.groupBox1.Location = new System.Drawing.Point(681, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(146, 583);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items Crafted";
            // 
            // lblItemsCraftedNullWarning
            // 
            this.lblItemsCraftedNullWarning.AutoSize = true;
            this.lblItemsCraftedNullWarning.Location = new System.Drawing.Point(9, 114);
            this.lblItemsCraftedNullWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsCraftedNullWarning.Name = "lblItemsCraftedNullWarning";
            this.lblItemsCraftedNullWarning.Size = new System.Drawing.Size(106, 80);
            this.lblItemsCraftedNullWarning.TabIndex = 8;
            this.lblItemsCraftedNullWarning.Text = "Selecting the \r\n\'null\'-Value \r\ncould lead \r\nto issues";
            // 
            // btnSelectAllItemsCrafted
            // 
            this.btnSelectAllItemsCrafted.Location = new System.Drawing.Point(9, 29);
            this.btnSelectAllItemsCrafted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAllItemsCrafted.Name = "btnSelectAllItemsCrafted";
            this.btnSelectAllItemsCrafted.Size = new System.Drawing.Size(130, 35);
            this.btnSelectAllItemsCrafted.TabIndex = 3;
            this.btnSelectAllItemsCrafted.Text = "Select all";
            this.btnSelectAllItemsCrafted.UseVisualStyleBackColor = true;
            this.btnSelectAllItemsCrafted.Click += new System.EventHandler(this.btnSelectAllItemsCrafted_Click);
            // 
            // btnResetItemsCrafted
            // 
            this.btnResetItemsCrafted.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetItemsCrafted.Location = new System.Drawing.Point(9, 538);
            this.btnResetItemsCrafted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetItemsCrafted.Name = "btnResetItemsCrafted";
            this.btnResetItemsCrafted.Size = new System.Drawing.Size(130, 35);
            this.btnResetItemsCrafted.TabIndex = 5;
            this.btnResetItemsCrafted.Text = "Reset";
            this.btnResetItemsCrafted.UseVisualStyleBackColor = true;
            this.btnResetItemsCrafted.Click += new System.EventHandler(this.btnResetItemsCrafted_Click);
            // 
            // btnDeselectAllItemsCrafted
            // 
            this.btnDeselectAllItemsCrafted.Location = new System.Drawing.Point(9, 74);
            this.btnDeselectAllItemsCrafted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselectAllItemsCrafted.Name = "btnDeselectAllItemsCrafted";
            this.btnDeselectAllItemsCrafted.Size = new System.Drawing.Size(130, 35);
            this.btnDeselectAllItemsCrafted.TabIndex = 4;
            this.btnDeselectAllItemsCrafted.Text = "Deselect all";
            this.btnDeselectAllItemsCrafted.UseVisualStyleBackColor = true;
            this.btnDeselectAllItemsCrafted.Click += new System.EventHandler(this.btnDeselectAllItemsCrafted_Click);
            // 
            // cblstItemsCrafted
            // 
            this.cblstItemsCrafted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblstItemsCrafted.FormattingEnabled = true;
            this.cblstItemsCrafted.Location = new System.Drawing.Point(9, 9);
            this.cblstItemsCrafted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblstItemsCrafted.Name = "cblstItemsCrafted";
            this.cblstItemsCrafted.Size = new System.Drawing.Size(661, 579);
            this.cblstItemsCrafted.TabIndex = 15;
            // 
            // tabQuickslots
            // 
            this.tabQuickslots.Controls.Add(this.label57);
            this.tabQuickslots.Controls.Add(this.grpQuickslots);
            this.tabQuickslots.Location = new System.Drawing.Point(4, 29);
            this.tabQuickslots.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuickslots.Name = "tabQuickslots";
            this.tabQuickslots.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuickslots.Size = new System.Drawing.Size(842, 616);
            this.tabQuickslots.TabIndex = 1;
            this.tabQuickslots.Text = "*Quickslots";
            this.tabQuickslots.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label57.Location = new System.Drawing.Point(9, 466);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(578, 20);
            this.label57.TabIndex = 32;
            this.label57.Text = "* = support for this function was removed due to the risk of losing your save gam" +
    "e";
            // 
            // grpQuickslots
            // 
            this.grpQuickslots.Controls.Add(this.label22);
            this.grpQuickslots.Controls.Add(this.label21);
            this.grpQuickslots.Controls.Add(this.label18);
            this.grpQuickslots.Controls.Add(this.label19);
            this.grpQuickslots.Controls.Add(this.label20);
            this.grpQuickslots.Controls.Add(this.label23);
            this.grpQuickslots.Controls.Add(this.label24);
            this.grpQuickslots.Controls.Add(this.label25);
            this.grpQuickslots.Controls.Add(this.label26);
            this.grpQuickslots.Controls.Add(this.label27);
            this.grpQuickslots.Location = new System.Drawing.Point(9, 9);
            this.grpQuickslots.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpQuickslots.Name = "grpQuickslots";
            this.grpQuickslots.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpQuickslots.Size = new System.Drawing.Size(512, 452);
            this.grpQuickslots.TabIndex = 29;
            this.grpQuickslots.TabStop = false;
            this.grpQuickslots.Text = "Quckslots";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 34);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 20);
            this.label22.TabIndex = 26;
            this.label22.Text = "Quckslot 0 (C):";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 408);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 20);
            this.label21.TabIndex = 24;
            this.label21.Text = "Quckslot 9 (R):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 366);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Quckslot 8 (E):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 325);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Quckslot 7 (W):";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 283);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Quckslot 6 (Q):";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 242);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 20);
            this.label23.TabIndex = 19;
            this.label23.Text = "Quckslot 5 (F):";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 200);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(113, 20);
            this.label24.TabIndex = 18;
            this.label24.Text = "Quckslot 4 (V):";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 158);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 20);
            this.label25.TabIndex = 17;
            this.label25.Text = "Quckslot 3 (D):";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 117);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 20);
            this.label26.TabIndex = 16;
            this.label26.Text = "Quckslot 2 (S):";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 75);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 20);
            this.label27.TabIndex = 15;
            this.label27.Text = "Quckslot 1 (A):";
            // 
            // msMenu
            // 
            this.msMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.msMenu.Size = new System.Drawing.Size(850, 35);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "msMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportAsToolStripMenuItem,
            this.openSavegameFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem});
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.exportAsToolStripMenuItem.Text = "Export as...";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.JSONToolStripMenuItem_Click);
            // 
            // openSavegameFolderToolStripMenuItem
            // 
            this.openSavegameFolderToolStripMenuItem.Name = "openSavegameFolderToolStripMenuItem";
            this.openSavegameFolderToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.openSavegameFolderToolStripMenuItem.Text = "Open Savegame Location...";
            this.openSavegameFolderToolStripMenuItem.Click += new System.EventHandler(this.openSavegameFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsole.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtConsole.Location = new System.Drawing.Point(0, 680);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(850, 197);
            this.txtConsole.TabIndex = 28;
            this.txtConsole.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox3.Location = new System.Drawing.Point(820, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numTalentMelee13);
            this.groupBox3.Controls.Add(this.numTalentMelee8);
            this.groupBox3.Controls.Add(this.pictureBox43);
            this.groupBox3.Controls.Add(this.pictureBox36);
            this.groupBox3.Controls.Add(this.numTalentMelee14);
            this.groupBox3.Controls.Add(this.numTalentMelee9);
            this.groupBox3.Controls.Add(this.pictureBox44);
            this.groupBox3.Controls.Add(this.pictureBox39);
            this.groupBox3.Controls.Add(this.numTalentMelee10);
            this.groupBox3.Controls.Add(this.numTalentMelee5);
            this.groupBox3.Controls.Add(this.pictureBox45);
            this.groupBox3.Controls.Add(this.pictureBox40);
            this.groupBox3.Controls.Add(this.numTalentMelee11);
            this.groupBox3.Controls.Add(this.numTalentMelee6);
            this.groupBox3.Controls.Add(this.pictureBox46);
            this.groupBox3.Controls.Add(this.pictureBox41);
            this.groupBox3.Controls.Add(this.numTalentMelee12);
            this.groupBox3.Controls.Add(this.numTalentMelee7);
            this.groupBox3.Controls.Add(this.pictureBox47);
            this.groupBox3.Controls.Add(this.pictureBox42);
            this.groupBox3.Controls.Add(this.numTalentMelee3);
            this.groupBox3.Controls.Add(this.pictureBox37);
            this.groupBox3.Controls.Add(this.numTalentMelee4);
            this.groupBox3.Controls.Add(this.pictureBox38);
            this.groupBox3.Controls.Add(this.numTalentMelee0);
            this.groupBox3.Controls.Add(this.pictureBox33);
            this.groupBox3.Controls.Add(this.numTalentMelee1);
            this.groupBox3.Controls.Add(this.pictureBox34);
            this.groupBox3.Controls.Add(this.numTalentMelee2);
            this.groupBox3.Controls.Add(this.pictureBox35);
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(693, 432);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Melee";
            // 
            // numTalentMelee13
            // 
            this.numTalentMelee13.Location = new System.Drawing.Point(416, 373);
            this.numTalentMelee13.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee13.Name = "numTalentMelee13";
            this.numTalentMelee13.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee13.TabIndex = 67;
            // 
            // numTalentMelee8
            // 
            this.numTalentMelee8.Location = new System.Drawing.Point(416, 239);
            this.numTalentMelee8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee8.Name = "numTalentMelee8";
            this.numTalentMelee8.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee8.TabIndex = 57;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox43.Location = new System.Drawing.Point(442, 297);
            this.pictureBox43.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(69, 71);
            this.pictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox43.TabIndex = 68;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox36.Location = new System.Drawing.Point(442, 163);
            this.pictureBox36.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(69, 71);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox36.TabIndex = 58;
            this.pictureBox36.TabStop = false;
            // 
            // numTalentMelee14
            // 
            this.numTalentMelee14.Location = new System.Drawing.Point(535, 373);
            this.numTalentMelee14.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee14.Name = "numTalentMelee14";
            this.numTalentMelee14.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee14.TabIndex = 69;
            // 
            // numTalentMelee9
            // 
            this.numTalentMelee9.Location = new System.Drawing.Point(535, 239);
            this.numTalentMelee9.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee9.Name = "numTalentMelee9";
            this.numTalentMelee9.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee9.TabIndex = 59;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox44.Location = new System.Drawing.Point(560, 297);
            this.pictureBox44.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(69, 71);
            this.pictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox44.TabIndex = 70;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox39.Location = new System.Drawing.Point(560, 163);
            this.pictureBox39.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(69, 71);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox39.TabIndex = 60;
            this.pictureBox39.TabStop = false;
            // 
            // numTalentMelee10
            // 
            this.numTalentMelee10.Location = new System.Drawing.Point(43, 373);
            this.numTalentMelee10.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee10.Name = "numTalentMelee10";
            this.numTalentMelee10.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee10.TabIndex = 61;
            // 
            // numTalentMelee5
            // 
            this.numTalentMelee5.Location = new System.Drawing.Point(43, 239);
            this.numTalentMelee5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee5.Name = "numTalentMelee5";
            this.numTalentMelee5.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee5.TabIndex = 51;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox45.Location = new System.Drawing.Point(68, 297);
            this.pictureBox45.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(69, 71);
            this.pictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox45.TabIndex = 62;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox40.Location = new System.Drawing.Point(68, 163);
            this.pictureBox40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(69, 71);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox40.TabIndex = 52;
            this.pictureBox40.TabStop = false;
            // 
            // numTalentMelee11
            // 
            this.numTalentMelee11.Location = new System.Drawing.Point(170, 373);
            this.numTalentMelee11.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee11.Name = "numTalentMelee11";
            this.numTalentMelee11.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee11.TabIndex = 63;
            // 
            // numTalentMelee6
            // 
            this.numTalentMelee6.Location = new System.Drawing.Point(170, 239);
            this.numTalentMelee6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee6.Name = "numTalentMelee6";
            this.numTalentMelee6.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee6.TabIndex = 53;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox46.Location = new System.Drawing.Point(196, 297);
            this.pictureBox46.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(69, 71);
            this.pictureBox46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox46.TabIndex = 64;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox41.Location = new System.Drawing.Point(196, 163);
            this.pictureBox41.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(69, 71);
            this.pictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox41.TabIndex = 54;
            this.pictureBox41.TabStop = false;
            // 
            // numTalentMelee12
            // 
            this.numTalentMelee12.Location = new System.Drawing.Point(289, 373);
            this.numTalentMelee12.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee12.Name = "numTalentMelee12";
            this.numTalentMelee12.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee12.TabIndex = 65;
            // 
            // numTalentMelee7
            // 
            this.numTalentMelee7.Location = new System.Drawing.Point(289, 239);
            this.numTalentMelee7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee7.Name = "numTalentMelee7";
            this.numTalentMelee7.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee7.TabIndex = 55;
            // 
            // pictureBox47
            // 
            this.pictureBox47.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox47.Location = new System.Drawing.Point(314, 297);
            this.pictureBox47.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(69, 71);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox47.TabIndex = 66;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox42.Location = new System.Drawing.Point(314, 163);
            this.pictureBox42.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(69, 71);
            this.pictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox42.TabIndex = 56;
            this.pictureBox42.TabStop = false;
            // 
            // numTalentMelee3
            // 
            this.numTalentMelee3.Location = new System.Drawing.Point(416, 103);
            this.numTalentMelee3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee3.Name = "numTalentMelee3";
            this.numTalentMelee3.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee3.TabIndex = 47;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox37.Location = new System.Drawing.Point(442, 27);
            this.pictureBox37.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(69, 71);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 48;
            this.pictureBox37.TabStop = false;
            // 
            // numTalentMelee4
            // 
            this.numTalentMelee4.Location = new System.Drawing.Point(535, 103);
            this.numTalentMelee4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee4.Name = "numTalentMelee4";
            this.numTalentMelee4.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee4.TabIndex = 49;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox38.Location = new System.Drawing.Point(560, 27);
            this.pictureBox38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(69, 71);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox38.TabIndex = 50;
            this.pictureBox38.TabStop = false;
            // 
            // numTalentMelee0
            // 
            this.numTalentMelee0.Location = new System.Drawing.Point(43, 103);
            this.numTalentMelee0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee0.Name = "numTalentMelee0";
            this.numTalentMelee0.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee0.TabIndex = 41;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox33.Location = new System.Drawing.Point(68, 27);
            this.pictureBox33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(69, 71);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 42;
            this.pictureBox33.TabStop = false;
            // 
            // numTalentMelee1
            // 
            this.numTalentMelee1.Location = new System.Drawing.Point(170, 103);
            this.numTalentMelee1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee1.Name = "numTalentMelee1";
            this.numTalentMelee1.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee1.TabIndex = 43;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox34.Location = new System.Drawing.Point(196, 27);
            this.pictureBox34.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(69, 71);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox34.TabIndex = 44;
            this.pictureBox34.TabStop = false;
            // 
            // numTalentMelee2
            // 
            this.numTalentMelee2.Location = new System.Drawing.Point(289, 103);
            this.numTalentMelee2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMelee2.Name = "numTalentMelee2";
            this.numTalentMelee2.Size = new System.Drawing.Size(118, 26);
            this.numTalentMelee2.TabIndex = 45;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox35.Location = new System.Drawing.Point(314, 27);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(69, 71);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox35.TabIndex = 46;
            this.pictureBox35.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numTalentMagic13);
            this.groupBox4.Controls.Add(this.numTalentMagic8);
            this.groupBox4.Controls.Add(this.pictureBox48);
            this.groupBox4.Controls.Add(this.pictureBox49);
            this.groupBox4.Controls.Add(this.numTalentMagic14);
            this.groupBox4.Controls.Add(this.numTalentMagic9);
            this.groupBox4.Controls.Add(this.pictureBox50);
            this.groupBox4.Controls.Add(this.pictureBox51);
            this.groupBox4.Controls.Add(this.numTalentMagic10);
            this.groupBox4.Controls.Add(this.numTalentMagic5);
            this.groupBox4.Controls.Add(this.pictureBox52);
            this.groupBox4.Controls.Add(this.pictureBox53);
            this.groupBox4.Controls.Add(this.numTalentMagic11);
            this.groupBox4.Controls.Add(this.numTalentMagic6);
            this.groupBox4.Controls.Add(this.pictureBox54);
            this.groupBox4.Controls.Add(this.pictureBox55);
            this.groupBox4.Controls.Add(this.numTalentMagic12);
            this.groupBox4.Controls.Add(this.numTalentMagic7);
            this.groupBox4.Controls.Add(this.pictureBox56);
            this.groupBox4.Controls.Add(this.pictureBox57);
            this.groupBox4.Controls.Add(this.numTalentMagic3);
            this.groupBox4.Controls.Add(this.pictureBox58);
            this.groupBox4.Controls.Add(this.numTalentMagic4);
            this.groupBox4.Controls.Add(this.pictureBox59);
            this.groupBox4.Controls.Add(this.numTalentMagic0);
            this.groupBox4.Controls.Add(this.pictureBox60);
            this.groupBox4.Controls.Add(this.numTalentMagic1);
            this.groupBox4.Controls.Add(this.pictureBox61);
            this.groupBox4.Controls.Add(this.numTalentMagic2);
            this.groupBox4.Controls.Add(this.pictureBox62);
            this.groupBox4.Location = new System.Drawing.Point(9, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(693, 432);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Magic";
            // 
            // numTalentMagic13
            // 
            this.numTalentMagic13.Location = new System.Drawing.Point(416, 373);
            this.numTalentMagic13.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic13.Name = "numTalentMagic13";
            this.numTalentMagic13.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic13.TabIndex = 67;
            // 
            // numTalentMagic8
            // 
            this.numTalentMagic8.Location = new System.Drawing.Point(416, 239);
            this.numTalentMagic8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic8.Name = "numTalentMagic8";
            this.numTalentMagic8.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic8.TabIndex = 57;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox48.Location = new System.Drawing.Point(442, 297);
            this.pictureBox48.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(69, 71);
            this.pictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox48.TabIndex = 68;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox49.Location = new System.Drawing.Point(442, 163);
            this.pictureBox49.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(69, 71);
            this.pictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox49.TabIndex = 58;
            this.pictureBox49.TabStop = false;
            // 
            // numTalentMagic14
            // 
            this.numTalentMagic14.Location = new System.Drawing.Point(535, 373);
            this.numTalentMagic14.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic14.Name = "numTalentMagic14";
            this.numTalentMagic14.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic14.TabIndex = 69;
            // 
            // numTalentMagic9
            // 
            this.numTalentMagic9.Location = new System.Drawing.Point(535, 239);
            this.numTalentMagic9.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic9.Name = "numTalentMagic9";
            this.numTalentMagic9.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic9.TabIndex = 59;
            // 
            // pictureBox50
            // 
            this.pictureBox50.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox50.Location = new System.Drawing.Point(560, 297);
            this.pictureBox50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(69, 71);
            this.pictureBox50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox50.TabIndex = 70;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox51.Location = new System.Drawing.Point(560, 163);
            this.pictureBox51.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(69, 71);
            this.pictureBox51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox51.TabIndex = 60;
            this.pictureBox51.TabStop = false;
            // 
            // numTalentMagic10
            // 
            this.numTalentMagic10.Location = new System.Drawing.Point(43, 373);
            this.numTalentMagic10.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic10.Name = "numTalentMagic10";
            this.numTalentMagic10.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic10.TabIndex = 61;
            // 
            // numTalentMagic5
            // 
            this.numTalentMagic5.Location = new System.Drawing.Point(43, 239);
            this.numTalentMagic5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic5.Name = "numTalentMagic5";
            this.numTalentMagic5.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic5.TabIndex = 51;
            // 
            // pictureBox52
            // 
            this.pictureBox52.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox52.Location = new System.Drawing.Point(68, 297);
            this.pictureBox52.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(69, 71);
            this.pictureBox52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox52.TabIndex = 62;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox53.Location = new System.Drawing.Point(68, 163);
            this.pictureBox53.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(69, 71);
            this.pictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox53.TabIndex = 52;
            this.pictureBox53.TabStop = false;
            // 
            // numTalentMagic11
            // 
            this.numTalentMagic11.Location = new System.Drawing.Point(170, 373);
            this.numTalentMagic11.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic11.Name = "numTalentMagic11";
            this.numTalentMagic11.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic11.TabIndex = 63;
            // 
            // numTalentMagic6
            // 
            this.numTalentMagic6.Location = new System.Drawing.Point(170, 239);
            this.numTalentMagic6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic6.Name = "numTalentMagic6";
            this.numTalentMagic6.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic6.TabIndex = 53;
            // 
            // pictureBox54
            // 
            this.pictureBox54.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox54.Location = new System.Drawing.Point(196, 297);
            this.pictureBox54.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(69, 71);
            this.pictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox54.TabIndex = 64;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox55.Location = new System.Drawing.Point(196, 163);
            this.pictureBox55.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(69, 71);
            this.pictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox55.TabIndex = 54;
            this.pictureBox55.TabStop = false;
            // 
            // numTalentMagic12
            // 
            this.numTalentMagic12.Location = new System.Drawing.Point(289, 373);
            this.numTalentMagic12.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic12.Name = "numTalentMagic12";
            this.numTalentMagic12.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic12.TabIndex = 65;
            // 
            // numTalentMagic7
            // 
            this.numTalentMagic7.Location = new System.Drawing.Point(289, 239);
            this.numTalentMagic7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic7.Name = "numTalentMagic7";
            this.numTalentMagic7.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic7.TabIndex = 55;
            // 
            // pictureBox56
            // 
            this.pictureBox56.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox56.Location = new System.Drawing.Point(314, 297);
            this.pictureBox56.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(69, 71);
            this.pictureBox56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox56.TabIndex = 66;
            this.pictureBox56.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox57.Location = new System.Drawing.Point(314, 163);
            this.pictureBox57.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(69, 71);
            this.pictureBox57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox57.TabIndex = 56;
            this.pictureBox57.TabStop = false;
            // 
            // numTalentMagic3
            // 
            this.numTalentMagic3.Location = new System.Drawing.Point(416, 103);
            this.numTalentMagic3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic3.Name = "numTalentMagic3";
            this.numTalentMagic3.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic3.TabIndex = 47;
            // 
            // pictureBox58
            // 
            this.pictureBox58.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox58.Location = new System.Drawing.Point(442, 27);
            this.pictureBox58.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(69, 71);
            this.pictureBox58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox58.TabIndex = 48;
            this.pictureBox58.TabStop = false;
            // 
            // numTalentMagic4
            // 
            this.numTalentMagic4.Location = new System.Drawing.Point(535, 103);
            this.numTalentMagic4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic4.Name = "numTalentMagic4";
            this.numTalentMagic4.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic4.TabIndex = 49;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox59.Location = new System.Drawing.Point(560, 27);
            this.pictureBox59.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(69, 71);
            this.pictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox59.TabIndex = 50;
            this.pictureBox59.TabStop = false;
            // 
            // numTalentMagic0
            // 
            this.numTalentMagic0.Location = new System.Drawing.Point(43, 103);
            this.numTalentMagic0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic0.Name = "numTalentMagic0";
            this.numTalentMagic0.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic0.TabIndex = 41;
            // 
            // pictureBox60
            // 
            this.pictureBox60.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox60.Location = new System.Drawing.Point(68, 27);
            this.pictureBox60.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(69, 71);
            this.pictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox60.TabIndex = 42;
            this.pictureBox60.TabStop = false;
            // 
            // numTalentMagic1
            // 
            this.numTalentMagic1.Location = new System.Drawing.Point(170, 103);
            this.numTalentMagic1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic1.Name = "numTalentMagic1";
            this.numTalentMagic1.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic1.TabIndex = 43;
            // 
            // pictureBox61
            // 
            this.pictureBox61.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox61.Location = new System.Drawing.Point(196, 27);
            this.pictureBox61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(69, 71);
            this.pictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox61.TabIndex = 44;
            this.pictureBox61.TabStop = false;
            // 
            // numTalentMagic2
            // 
            this.numTalentMagic2.Location = new System.Drawing.Point(289, 103);
            this.numTalentMagic2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentMagic2.Name = "numTalentMagic2";
            this.numTalentMagic2.Size = new System.Drawing.Size(118, 26);
            this.numTalentMagic2.TabIndex = 45;
            // 
            // pictureBox62
            // 
            this.pictureBox62.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox62.Location = new System.Drawing.Point(314, 27);
            this.pictureBox62.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(69, 71);
            this.pictureBox62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox62.TabIndex = 46;
            this.pictureBox62.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numTalentGeneral20);
            this.groupBox5.Controls.Add(this.pictureBox78);
            this.groupBox5.Controls.Add(this.numTalentGeneral19);
            this.groupBox5.Controls.Add(this.pictureBox79);
            this.groupBox5.Controls.Add(this.numTalentGeneral18);
            this.groupBox5.Controls.Add(this.pictureBox80);
            this.groupBox5.Controls.Add(this.numTalentGeneral17);
            this.groupBox5.Controls.Add(this.pictureBox81);
            this.groupBox5.Controls.Add(this.numTalentGeneral16);
            this.groupBox5.Controls.Add(this.pictureBox82);
            this.groupBox5.Controls.Add(this.numTalentGeneral15);
            this.groupBox5.Controls.Add(this.pictureBox83);
            this.groupBox5.Controls.Add(this.numTalentGeneral13);
            this.groupBox5.Controls.Add(this.numTalentGeneral6);
            this.groupBox5.Controls.Add(this.pictureBox65);
            this.groupBox5.Controls.Add(this.pictureBox72);
            this.groupBox5.Controls.Add(this.numTalentGeneral12);
            this.groupBox5.Controls.Add(this.numTalentGeneral5);
            this.groupBox5.Controls.Add(this.pictureBox66);
            this.groupBox5.Controls.Add(this.pictureBox69);
            this.groupBox5.Controls.Add(this.numTalentGeneral11);
            this.groupBox5.Controls.Add(this.numTalentGeneral4);
            this.groupBox5.Controls.Add(this.pictureBox73);
            this.groupBox5.Controls.Add(this.pictureBox70);
            this.groupBox5.Controls.Add(this.numTalentGeneral10);
            this.groupBox5.Controls.Add(this.numTalentGeneral3);
            this.groupBox5.Controls.Add(this.pictureBox74);
            this.groupBox5.Controls.Add(this.pictureBox71);
            this.groupBox5.Controls.Add(this.numTalentGeneral9);
            this.groupBox5.Controls.Add(this.numTalentGeneral2);
            this.groupBox5.Controls.Add(this.pictureBox76);
            this.groupBox5.Controls.Add(this.pictureBox64);
            this.groupBox5.Controls.Add(this.numTalentGeneral8);
            this.groupBox5.Controls.Add(this.numTalentGeneral1);
            this.groupBox5.Controls.Add(this.pictureBox77);
            this.groupBox5.Controls.Add(this.pictureBox63);
            this.groupBox5.Controls.Add(this.numTalentGeneral14);
            this.groupBox5.Controls.Add(this.numTalentGeneral7);
            this.groupBox5.Controls.Add(this.pictureBox67);
            this.groupBox5.Controls.Add(this.pictureBox68);
            this.groupBox5.Controls.Add(this.numTalentGeneral0);
            this.groupBox5.Controls.Add(this.pictureBox75);
            this.groupBox5.Location = new System.Drawing.Point(9, 9);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(693, 432);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "General";
            // 
            // numTalentGeneral0
            // 
            this.numTalentGeneral0.Location = new System.Drawing.Point(42, 103);
            this.numTalentGeneral0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral0.Name = "numTalentGeneral0";
            this.numTalentGeneral0.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral0.TabIndex = 41;
            // 
            // pictureBox75
            // 
            this.pictureBox75.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox75.Location = new System.Drawing.Point(42, 27);
            this.pictureBox75.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(69, 71);
            this.pictureBox75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox75.TabIndex = 42;
            this.pictureBox75.TabStop = false;
            // 
            // numTalentGeneral1
            // 
            this.numTalentGeneral1.Location = new System.Drawing.Point(132, 103);
            this.numTalentGeneral1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral1.Name = "numTalentGeneral1";
            this.numTalentGeneral1.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral1.TabIndex = 76;
            // 
            // pictureBox63
            // 
            this.pictureBox63.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox63.Location = new System.Drawing.Point(132, 27);
            this.pictureBox63.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(69, 71);
            this.pictureBox63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox63.TabIndex = 77;
            this.pictureBox63.TabStop = false;
            // 
            // numTalentGeneral2
            // 
            this.numTalentGeneral2.Location = new System.Drawing.Point(222, 103);
            this.numTalentGeneral2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral2.Name = "numTalentGeneral2";
            this.numTalentGeneral2.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral2.TabIndex = 78;
            // 
            // pictureBox64
            // 
            this.pictureBox64.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox64.Location = new System.Drawing.Point(222, 27);
            this.pictureBox64.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(69, 71);
            this.pictureBox64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox64.TabIndex = 79;
            this.pictureBox64.TabStop = false;
            // 
            // numTalentGeneral5
            // 
            this.numTalentGeneral5.Location = new System.Drawing.Point(492, 103);
            this.numTalentGeneral5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral5.Name = "numTalentGeneral5";
            this.numTalentGeneral5.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral5.TabIndex = 84;
            // 
            // pictureBox69
            // 
            this.pictureBox69.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox69.Location = new System.Drawing.Point(492, 27);
            this.pictureBox69.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(69, 71);
            this.pictureBox69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox69.TabIndex = 85;
            this.pictureBox69.TabStop = false;
            // 
            // numTalentGeneral4
            // 
            this.numTalentGeneral4.Location = new System.Drawing.Point(402, 103);
            this.numTalentGeneral4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral4.Name = "numTalentGeneral4";
            this.numTalentGeneral4.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral4.TabIndex = 82;
            // 
            // pictureBox70
            // 
            this.pictureBox70.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox70.Location = new System.Drawing.Point(402, 27);
            this.pictureBox70.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(69, 71);
            this.pictureBox70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox70.TabIndex = 83;
            this.pictureBox70.TabStop = false;
            // 
            // numTalentGeneral3
            // 
            this.numTalentGeneral3.Location = new System.Drawing.Point(312, 103);
            this.numTalentGeneral3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral3.Name = "numTalentGeneral3";
            this.numTalentGeneral3.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral3.TabIndex = 80;
            // 
            // pictureBox71
            // 
            this.pictureBox71.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox71.Location = new System.Drawing.Point(312, 27);
            this.pictureBox71.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(69, 71);
            this.pictureBox71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox71.TabIndex = 81;
            this.pictureBox71.TabStop = false;
            // 
            // numTalentGeneral6
            // 
            this.numTalentGeneral6.Location = new System.Drawing.Point(582, 103);
            this.numTalentGeneral6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral6.Name = "numTalentGeneral6";
            this.numTalentGeneral6.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral6.TabIndex = 88;
            // 
            // pictureBox72
            // 
            this.pictureBox72.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox72.Location = new System.Drawing.Point(582, 27);
            this.pictureBox72.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(69, 71);
            this.pictureBox72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox72.TabIndex = 89;
            this.pictureBox72.TabStop = false;
            // 
            // numTalentGeneral14
            // 
            this.numTalentGeneral14.Location = new System.Drawing.Point(42, 376);
            this.numTalentGeneral14.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral14.Name = "numTalentGeneral14";
            this.numTalentGeneral14.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral14.TabIndex = 72;
            // 
            // pictureBox67
            // 
            this.pictureBox67.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox67.Location = new System.Drawing.Point(42, 297);
            this.pictureBox67.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(69, 71);
            this.pictureBox67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox67.TabIndex = 62;
            this.pictureBox67.TabStop = false;
            // 
            // numTalentGeneral7
            // 
            this.numTalentGeneral7.Location = new System.Drawing.Point(42, 243);
            this.numTalentGeneral7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral7.Name = "numTalentGeneral7";
            this.numTalentGeneral7.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral7.TabIndex = 71;
            // 
            // pictureBox68
            // 
            this.pictureBox68.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox68.Location = new System.Drawing.Point(42, 169);
            this.pictureBox68.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(69, 71);
            this.pictureBox68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox68.TabIndex = 52;
            this.pictureBox68.TabStop = false;
            // 
            // numTalentGeneral13
            // 
            this.numTalentGeneral13.Location = new System.Drawing.Point(582, 243);
            this.numTalentGeneral13.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral13.Name = "numTalentGeneral13";
            this.numTalentGeneral13.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral13.TabIndex = 102;
            // 
            // pictureBox65
            // 
            this.pictureBox65.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox65.Location = new System.Drawing.Point(582, 169);
            this.pictureBox65.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(69, 71);
            this.pictureBox65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox65.TabIndex = 103;
            this.pictureBox65.TabStop = false;
            // 
            // numTalentGeneral12
            // 
            this.numTalentGeneral12.Location = new System.Drawing.Point(492, 243);
            this.numTalentGeneral12.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral12.Name = "numTalentGeneral12";
            this.numTalentGeneral12.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral12.TabIndex = 100;
            // 
            // pictureBox66
            // 
            this.pictureBox66.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox66.Location = new System.Drawing.Point(492, 169);
            this.pictureBox66.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(69, 71);
            this.pictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox66.TabIndex = 101;
            this.pictureBox66.TabStop = false;
            // 
            // numTalentGeneral11
            // 
            this.numTalentGeneral11.Location = new System.Drawing.Point(402, 243);
            this.numTalentGeneral11.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral11.Name = "numTalentGeneral11";
            this.numTalentGeneral11.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral11.TabIndex = 98;
            // 
            // pictureBox73
            // 
            this.pictureBox73.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox73.Location = new System.Drawing.Point(402, 169);
            this.pictureBox73.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(69, 71);
            this.pictureBox73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox73.TabIndex = 99;
            this.pictureBox73.TabStop = false;
            // 
            // numTalentGeneral10
            // 
            this.numTalentGeneral10.Location = new System.Drawing.Point(312, 243);
            this.numTalentGeneral10.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral10.Name = "numTalentGeneral10";
            this.numTalentGeneral10.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral10.TabIndex = 96;
            // 
            // pictureBox74
            // 
            this.pictureBox74.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox74.Location = new System.Drawing.Point(312, 169);
            this.pictureBox74.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(69, 71);
            this.pictureBox74.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox74.TabIndex = 97;
            this.pictureBox74.TabStop = false;
            // 
            // numTalentGeneral9
            // 
            this.numTalentGeneral9.Location = new System.Drawing.Point(222, 243);
            this.numTalentGeneral9.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral9.Name = "numTalentGeneral9";
            this.numTalentGeneral9.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral9.TabIndex = 94;
            // 
            // pictureBox76
            // 
            this.pictureBox76.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox76.Location = new System.Drawing.Point(222, 169);
            this.pictureBox76.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(69, 71);
            this.pictureBox76.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox76.TabIndex = 95;
            this.pictureBox76.TabStop = false;
            // 
            // numTalentGeneral8
            // 
            this.numTalentGeneral8.Location = new System.Drawing.Point(132, 243);
            this.numTalentGeneral8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral8.Name = "numTalentGeneral8";
            this.numTalentGeneral8.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral8.TabIndex = 92;
            // 
            // pictureBox77
            // 
            this.pictureBox77.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox77.Location = new System.Drawing.Point(132, 169);
            this.pictureBox77.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox77.Name = "pictureBox77";
            this.pictureBox77.Size = new System.Drawing.Size(69, 71);
            this.pictureBox77.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox77.TabIndex = 93;
            this.pictureBox77.TabStop = false;
            // 
            // numTalentGeneral20
            // 
            this.numTalentGeneral20.Location = new System.Drawing.Point(582, 376);
            this.numTalentGeneral20.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral20.Name = "numTalentGeneral20";
            this.numTalentGeneral20.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral20.TabIndex = 116;
            // 
            // pictureBox78
            // 
            this.pictureBox78.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox78.Location = new System.Drawing.Point(582, 297);
            this.pictureBox78.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(69, 71);
            this.pictureBox78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox78.TabIndex = 117;
            this.pictureBox78.TabStop = false;
            // 
            // numTalentGeneral19
            // 
            this.numTalentGeneral19.Location = new System.Drawing.Point(492, 376);
            this.numTalentGeneral19.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral19.Name = "numTalentGeneral19";
            this.numTalentGeneral19.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral19.TabIndex = 114;
            // 
            // pictureBox79
            // 
            this.pictureBox79.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox79.Location = new System.Drawing.Point(492, 297);
            this.pictureBox79.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(69, 71);
            this.pictureBox79.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox79.TabIndex = 115;
            this.pictureBox79.TabStop = false;
            // 
            // numTalentGeneral18
            // 
            this.numTalentGeneral18.Location = new System.Drawing.Point(402, 376);
            this.numTalentGeneral18.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral18.Name = "numTalentGeneral18";
            this.numTalentGeneral18.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral18.TabIndex = 112;
            // 
            // pictureBox80
            // 
            this.pictureBox80.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox80.Location = new System.Drawing.Point(402, 297);
            this.pictureBox80.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(69, 71);
            this.pictureBox80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox80.TabIndex = 113;
            this.pictureBox80.TabStop = false;
            // 
            // numTalentGeneral17
            // 
            this.numTalentGeneral17.Location = new System.Drawing.Point(312, 376);
            this.numTalentGeneral17.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral17.Name = "numTalentGeneral17";
            this.numTalentGeneral17.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral17.TabIndex = 110;
            // 
            // pictureBox81
            // 
            this.pictureBox81.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox81.Location = new System.Drawing.Point(312, 297);
            this.pictureBox81.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(69, 71);
            this.pictureBox81.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox81.TabIndex = 111;
            this.pictureBox81.TabStop = false;
            // 
            // numTalentGeneral16
            // 
            this.numTalentGeneral16.Location = new System.Drawing.Point(222, 376);
            this.numTalentGeneral16.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral16.Name = "numTalentGeneral16";
            this.numTalentGeneral16.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral16.TabIndex = 108;
            // 
            // pictureBox82
            // 
            this.pictureBox82.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox82.Location = new System.Drawing.Point(222, 297);
            this.pictureBox82.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(69, 71);
            this.pictureBox82.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox82.TabIndex = 109;
            this.pictureBox82.TabStop = false;
            // 
            // numTalentGeneral15
            // 
            this.numTalentGeneral15.Location = new System.Drawing.Point(132, 376);
            this.numTalentGeneral15.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTalentGeneral15.Name = "numTalentGeneral15";
            this.numTalentGeneral15.Size = new System.Drawing.Size(69, 26);
            this.numTalentGeneral15.TabIndex = 106;
            // 
            // pictureBox83
            // 
            this.pictureBox83.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox83.Location = new System.Drawing.Point(132, 297);
            this.pictureBox83.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(69, 71);
            this.pictureBox83.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox83.TabIndex = 107;
            this.pictureBox83.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(850, 877);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblTrophiesNullWarning);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "SoG: Savegame Editor v16.9.30803.129 by tolik518";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.lblTrophiesNullWarning.ResumeLayout(false);
            this.tabChar.ResumeLayout(false);
            this.tabChar.PerformLayout();
            this.grpPatch.ResumeLayout(false);
            this.grpPatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirtdayMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthdayDay)).EndInit();
            this.grpEquipped.ResumeLayout(false);
            this.grpEquipped.PerformLayout();
            this.grpEquippedStyle.ResumeLayout(false);
            this.grpEquippedStyle.PerformLayout();
            this.grpSkillpoints.ResumeLayout(false);
            this.grpSkillpoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTalentPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillSilverPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillGoldPoints)).EndInit();
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEXPUnknown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEXPUnknown0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEXPcurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGold)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).EndInit();
            this.tabPets.ResumeLayout(false);
            this.grpPet.ResumeLayout(false);
            this.grpPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPetLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPetHP)).EndInit();
            this.tabSkills.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSkillsMelee.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee2h0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMelee1h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabSkillsMagic.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicA0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicE0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicI0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillMagicF0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.tabSkillsUtility.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityE0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityD0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityO0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUtilityO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            this.tabTalentsMelee.ResumeLayout(false);
            this.tabTalentsMagic.ResumeLayout(false);
            this.tabTalentsGeneral.ResumeLayout(false);
            this.tabCards.ResumeLayout(false);
            this.grpCards.ResumeLayout(false);
            this.grpCards.PerformLayout();
            this.tabMaps.ResumeLayout(false);
            this.grpMaps.ResumeLayout(false);
            this.grpMaps.PerformLayout();
            this.tabQuests.ResumeLayout(false);
            this.grpQuests.ResumeLayout(false);
            this.grpQuests.PerformLayout();
            this.tabFlags.ResumeLayout(false);
            this.grpFlags.ResumeLayout(false);
            this.grpFlags.PerformLayout();
            this.tabTrophies.ResumeLayout(false);
            this.grpTrophies.ResumeLayout(false);
            this.grpTrophies.PerformLayout();
            this.tabFishCaught.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabEnemiesSeen.ResumeLayout(false);
            this.grpEnemiesSeen.ResumeLayout(false);
            this.grpEnemiesSeen.PerformLayout();
            this.tabItemsSeen.ResumeLayout(false);
            this.grpItemsSeen.ResumeLayout(false);
            this.grpItemsSeen.PerformLayout();
            this.tabItemsCrafted.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabQuickslots.ResumeLayout(false);
            this.tabQuickslots.PerformLayout();
            this.grpQuickslots.ResumeLayout(false);
            this.grpQuickslots.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMelee2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentMagic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTalentGeneral15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl lblTrophiesNullWarning;
        private System.Windows.Forms.TabPage tabQuickslots;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpQuickslots;



        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.ListView lstInventory;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.NumericUpDown numItemCount;
        private System.Windows.Forms.ComboBox cbSelectedItem;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TabPage tabChar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.Label lblPants;
        private System.Windows.Forms.Label lblShirt;
        private System.Windows.Forms.Label lblPoncho;
        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.Button btnPantsColor;
        private System.Windows.Forms.Button btnShirtColor;
        private System.Windows.Forms.Button btnPonchoColor;
        private System.Windows.Forms.Button btnSkinColor;
        private System.Windows.Forms.Button btnHairColor;
        private System.Windows.Forms.Label lblHair;
        private System.Windows.Forms.TabPage tabEnemiesSeen;
        private System.Windows.Forms.TabPage tabCards;
        private System.Windows.Forms.TabPage tabFlags;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.Label lblExpUnknown1;
        private System.Windows.Forms.Label lblExpUnknown0;
        private System.Windows.Forms.Label lblCurrectExp;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.NumericUpDown numEXPUnknown1;
        private System.Windows.Forms.NumericUpDown numEXPUnknown0;
        private System.Windows.Forms.NumericUpDown numEXPcurrent;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.GroupBox grpSkillpoints;
        private System.Windows.Forms.Label lblGoldPoints;
        private System.Windows.Forms.Label lblSilverPoints;
        private System.Windows.Forms.Label lblTalentPoints;
        private System.Windows.Forms.NumericUpDown numSkillTalentPoints;
        private System.Windows.Forms.NumericUpDown numSkillSilverPoints;
        private System.Windows.Forms.NumericUpDown numSkillGoldPoints;
        private System.Windows.Forms.ToolTip Tooltips;
        private System.Windows.Forms.GroupBox grpEquipped;
        private System.Windows.Forms.Label lblAccessory2;
        private System.Windows.Forms.Label lblAccessory1;
        private System.Windows.Forms.Label lblShoes;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblShield;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Label lblFacegear;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.ComboBox cbAccessory2;
        private System.Windows.Forms.ComboBox cbAccessory1;
        private System.Windows.Forms.ComboBox cbShoes;
        private System.Windows.Forms.ComboBox cbArmor;
        private System.Windows.Forms.ComboBox cbShield;
        private System.Windows.Forms.ComboBox cbWeapon;
        private System.Windows.Forms.ComboBox cbFacegear;
        private System.Windows.Forms.ComboBox cbHat;
        private System.Windows.Forms.GroupBox grpEquippedStyle;
        private System.Windows.Forms.Label lblEqShield;
        private System.Windows.Forms.ComboBox cbStyleShield;
        private System.Windows.Forms.Label lblEqWeapon;
        private System.Windows.Forms.ComboBox cbStyleHat;
        private System.Windows.Forms.Label lblEqFacegear;
        private System.Windows.Forms.ComboBox cbStyleFacegear;
        private System.Windows.Forms.Label lblEqHat;
        private System.Windows.Forms.ComboBox cbStyleWeapon;
        private System.Windows.Forms.TabPage tabPets;
        private System.Windows.Forms.ListView lstPets;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Nickname;
        private System.Windows.Forms.ColumnHeader HP;
        private System.Windows.Forms.ColumnHeader SP;
        private System.Windows.Forms.ColumnHeader Dmg;
        private System.Windows.Forms.ColumnHeader Crit;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.GroupBox grpPet;
        private System.Windows.Forms.Label lblPetSpeed;
        private System.Windows.Forms.Label lblPetCrit;
        private System.Windows.Forms.Label lblPetDamage;
        private System.Windows.Forms.Label lblPetEnergy;
        private System.Windows.Forms.Label lblPetHealth;
        private System.Windows.Forms.NumericUpDown numPetSpeed;
        private System.Windows.Forms.NumericUpDown numPetCrit;
        private System.Windows.Forms.NumericUpDown numPetDamage;
        private System.Windows.Forms.TextBox txtPetNickname;
        private System.Windows.Forms.NumericUpDown numPetEnergy;
        private System.Windows.Forms.Label lblPetNickname;
        private System.Windows.Forms.NumericUpDown numPetHP;
        private System.Windows.Forms.NumericUpDown numPetLevel;
        private System.Windows.Forms.Label lblPetLevel;
        private System.Windows.Forms.Button btnDeleteSelectedItem;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TabPage tabQuests;
        private System.Windows.Forms.Label lblTimePlayed;
        private System.Windows.Forms.ComboBox cbPetType;
        private System.Windows.Forms.Label lblPetType;
        private System.Windows.Forms.TextBox txtTimePlayed;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.NumericUpDown numBirtdayMonth;
        private System.Windows.Forms.NumericUpDown numBirthdayDay;
        private System.Windows.Forms.GroupBox grpPatch;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblCollectorId;
        private System.Windows.Forms.NumericUpDown numGold;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSkillsMelee;
        private System.Windows.Forms.TabPage tabSkillsMagic;
        private System.Windows.Forms.TabPage tabSkillsUtility;
        private System.Windows.Forms.TabPage tabTalentsMelee;
        private System.Windows.Forms.TabPage tabTalentsMagic;
        private System.Windows.Forms.TabPage tabTalentsGeneral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private Label lblGamePatch;
        private CheckedListBox cblstCards;
        private Button btnResetCards;
        private Button btnDeselectAllCards;
        private Button btnSelectAllCards;
        private GroupBox grpCards;
        private GroupBox grpQuests;
        private Button btnSelectAllQuests;
        private Button btnResetQuests;
        private Button btnDeselectAllQuests;
        private CheckedListBox cblstQuests;
        private ToolStripMenuItem openSavegameFolderToolStripMenuItem;
        private GroupBox grpEnemiesSeen;
        private Button btnSelectAllEnemiesSeen;
        private Button btnResetEnemiesSeen;
        private Button btnDeselectAllEnemiesSeen;
        private CheckedListBox cblstEnemiesSeens;
        private GroupBox grpFlags;
        private Button btnSelectAllFlags;
        private Button btnResetFlags;
        private Button btnDeselectAllFlags;
        private CheckedListBox cblstFlags;
        private TabPage tabMaps;
        private GroupBox grpMaps;
        private Button btnSelectAllMaps;
        private Button btnResetMaps;
        private Button btnDeselectAllMaps;
        private CheckedListBox cblstMaps;
        private Label lblCardsNullWarning;
        private Label lblMapsNullWarning;
        private Label lblQuestsNullWarning;
        private Label label41;
        private Label lblEnemiesSeenNullWarning;
        private TabPage tabTrophies;
        private GroupBox grpTrophies;
        private Label label59;
        private Button btnSelectAllTrophies;
        private Button btnResetTrophies;
        private Button btnDeselectAllTrophies;
        private CheckedListBox cblstTrophies;
        private TabPage tabItemsSeen;
        private GroupBox grpItemsSeen;
        private Label lblItemsSeenNullWarning;
        private Button btnSelectAllItemsSeen;
        private Button btnResetItemsSeen;
        private Button btnDeselectAllItemsSeen;
        private CheckedListBox cblstItemsSeen;
        private TabPage tabItemsCrafted;
        private GroupBox groupBox1;
        private Label lblItemsCraftedNullWarning;
        private Button btnSelectAllItemsCrafted;
        private Button btnResetItemsCrafted;
        private Button btnDeselectAllItemsCrafted;
        private CheckedListBox cblstItemsCrafted;
        private TabPage tabFishCaught;
        private GroupBox groupBox2;
        private Label lblFishNullWarning;
        private Button btnSelectAllFishCaught;
        private Button btnResetFishCaught;
        private Button btnDeselectAllFishCaught;
        private CheckedListBox cblstFishCaught;
        private CheckedListBox cblstFlagsChecked;
        private Label lblFlagsChaningNoEffect;
        private Label lblQuestsChaningNoEffect;
        private NumericUpDown numSkillMelee1h0;
        private NumericUpDown numSkillMelee1h1;
        private NumericUpDown numSkillMelee2h0;
        private NumericUpDown numSkillMelee1h2;
        private NumericUpDown numSkillMelee1h3;
        private NumericUpDown numSkillMelee1h4;
        private NumericUpDown numSkillMagicA2;
        private NumericUpDown numSkillMagicA1;
        private NumericUpDown numSkillMagicA0;
        private NumericUpDown numSkillMagicE2;
        private NumericUpDown numSkillMagicE1;
        private NumericUpDown numSkillMagicE0;
        private NumericUpDown numSkillMagicI2;
        private NumericUpDown numSkillMagicI1;
        private NumericUpDown numSkillMagicI0;
        private NumericUpDown numSkillMagicF2;
        private NumericUpDown numSkillMagicF1;
        private NumericUpDown numSkillMagicF0;
        private NumericUpDown numUtilityE0;
        private NumericUpDown numUtilityE1;
        private NumericUpDown numUtilityE2;
        private NumericUpDown numUtilityD0;
        private NumericUpDown numUtilityD1;
        private NumericUpDown numUtilityD2;
        private NumericUpDown numUtilityO0;
        private NumericUpDown numUtilityO1;
        private NumericUpDown numUtilityO2;
        private NumericUpDown numSkillMelee2h4;
        private NumericUpDown numSkillMelee2h3;
        private NumericUpDown numSkillMelee2h2;
        private NumericUpDown numSkillMelee2h1;
        private GroupBox groupBox3;
        private NumericUpDown numTalentMelee13;
        private NumericUpDown numTalentMelee8;
        private PictureBox pictureBox43;
        private PictureBox pictureBox36;
        private NumericUpDown numTalentMelee14;
        private NumericUpDown numTalentMelee9;
        private PictureBox pictureBox44;
        private PictureBox pictureBox39;
        private NumericUpDown numTalentMelee10;
        private NumericUpDown numTalentMelee5;
        private PictureBox pictureBox45;
        private PictureBox pictureBox40;
        private NumericUpDown numTalentMelee11;
        private NumericUpDown numTalentMelee6;
        private PictureBox pictureBox46;
        private PictureBox pictureBox41;
        private NumericUpDown numTalentMelee12;
        private NumericUpDown numTalentMelee7;
        private PictureBox pictureBox47;
        private PictureBox pictureBox42;
        private NumericUpDown numTalentMelee3;
        private PictureBox pictureBox37;
        private NumericUpDown numTalentMelee4;
        private PictureBox pictureBox38;
        private NumericUpDown numTalentMelee0;
        private PictureBox pictureBox33;
        private NumericUpDown numTalentMelee1;
        private PictureBox pictureBox34;
        private NumericUpDown numTalentMelee2;
        private PictureBox pictureBox35;
        private GroupBox groupBox4;
        private NumericUpDown numTalentMagic13;
        private NumericUpDown numTalentMagic8;
        private PictureBox pictureBox48;
        private PictureBox pictureBox49;
        private NumericUpDown numTalentMagic14;
        private NumericUpDown numTalentMagic9;
        private PictureBox pictureBox50;
        private PictureBox pictureBox51;
        private NumericUpDown numTalentMagic10;
        private NumericUpDown numTalentMagic5;
        private PictureBox pictureBox52;
        private PictureBox pictureBox53;
        private NumericUpDown numTalentMagic11;
        private NumericUpDown numTalentMagic6;
        private PictureBox pictureBox54;
        private PictureBox pictureBox55;
        private NumericUpDown numTalentMagic12;
        private NumericUpDown numTalentMagic7;
        private PictureBox pictureBox56;
        private PictureBox pictureBox57;
        private NumericUpDown numTalentMagic3;
        private PictureBox pictureBox58;
        private NumericUpDown numTalentMagic4;
        private PictureBox pictureBox59;
        private NumericUpDown numTalentMagic0;
        private PictureBox pictureBox60;
        private NumericUpDown numTalentMagic1;
        private PictureBox pictureBox61;
        private NumericUpDown numTalentMagic2;
        private PictureBox pictureBox62;
        private GroupBox groupBox5;
        private NumericUpDown numTalentGeneral20;
        private PictureBox pictureBox78;
        private NumericUpDown numTalentGeneral19;
        private PictureBox pictureBox79;
        private NumericUpDown numTalentGeneral18;
        private PictureBox pictureBox80;
        private NumericUpDown numTalentGeneral17;
        private PictureBox pictureBox81;
        private NumericUpDown numTalentGeneral16;
        private PictureBox pictureBox82;
        private NumericUpDown numTalentGeneral15;
        private PictureBox pictureBox83;
        private NumericUpDown numTalentGeneral13;
        private NumericUpDown numTalentGeneral6;
        private PictureBox pictureBox65;
        private PictureBox pictureBox72;
        private NumericUpDown numTalentGeneral12;
        private NumericUpDown numTalentGeneral5;
        private PictureBox pictureBox66;
        private PictureBox pictureBox69;
        private NumericUpDown numTalentGeneral11;
        private NumericUpDown numTalentGeneral4;
        private PictureBox pictureBox73;
        private PictureBox pictureBox70;
        private NumericUpDown numTalentGeneral10;
        private NumericUpDown numTalentGeneral3;
        private PictureBox pictureBox74;
        private PictureBox pictureBox71;
        private NumericUpDown numTalentGeneral9;
        private NumericUpDown numTalentGeneral2;
        private PictureBox pictureBox76;
        private PictureBox pictureBox64;
        private NumericUpDown numTalentGeneral8;
        private NumericUpDown numTalentGeneral1;
        private PictureBox pictureBox77;
        private PictureBox pictureBox63;
        private NumericUpDown numTalentGeneral14;
        private NumericUpDown numTalentGeneral7;
        private PictureBox pictureBox67;
        private PictureBox pictureBox68;
        private NumericUpDown numTalentGeneral0;
        private PictureBox pictureBox75;
    }
}
