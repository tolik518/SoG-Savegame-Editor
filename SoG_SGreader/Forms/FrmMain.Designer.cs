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
            this.grpEnemiesSeen = new System.Windows.Forms.TabControl();
            this.tabChar = new System.Windows.Forms.TabPage();
            this.grpPatch = new System.Windows.Forms.GroupBox();
            this.lblGamePatch = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label51 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.numBirtdayMonth = new System.Windows.Forms.NumericUpDown();
            this.numBirthdayDay = new System.Windows.Forms.NumericUpDown();
            this.txtTimePlayed = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.grpEquipped = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbAccessory2 = new System.Windows.Forms.ComboBox();
            this.cbAccessory1 = new System.Windows.Forms.ComboBox();
            this.cbShoes = new System.Windows.Forms.ComboBox();
            this.cbArmor = new System.Windows.Forms.ComboBox();
            this.cbShield = new System.Windows.Forms.ComboBox();
            this.cbWeapon = new System.Windows.Forms.ComboBox();
            this.cbFacegear = new System.Windows.Forms.ComboBox();
            this.cbHat = new System.Windows.Forms.ComboBox();
            this.grpEquippedStyle = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbStyleShield = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbStyleHat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbStyleFacegear = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbStyleWeapon = new System.Windows.Forms.ComboBox();
            this.grpSkillpoints = new System.Windows.Forms.GroupBox();
            this.numSkillTalentPoints = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.numSkillSilverPoints = new System.Windows.Forms.NumericUpDown();
            this.numSkillGoldPoints = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.numEXPUnknown1 = new System.Windows.Forms.NumericUpDown();
            this.numEXPUnknown0 = new System.Windows.Forms.NumericUpDown();
            this.numEXPcurrent = new System.Windows.Forms.NumericUpDown();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPantsColor = new System.Windows.Forms.Button();
            this.btnShirtColor = new System.Windows.Forms.Button();
            this.btnPonchoColor = new System.Windows.Forms.Button();
            this.btnSkinColor = new System.Windows.Forms.Button();
            this.btnHairColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.numGold = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectedItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
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
            this.label52 = new System.Windows.Forms.Label();
            this.numPetLevel = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtPetNickname = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.numPetSpeed = new System.Windows.Forms.NumericUpDown();
            this.numPetCrit = new System.Windows.Forms.NumericUpDown();
            this.numPetDamage = new System.Windows.Forms.NumericUpDown();
            this.numPetEnergy = new System.Windows.Forms.NumericUpDown();
            this.numPetHP = new System.Windows.Forms.NumericUpDown();
            this.tabCards = new System.Windows.Forms.TabPage();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.btnSelectAllCards = new System.Windows.Forms.Button();
            this.btnResetCards = new System.Windows.Forms.Button();
            this.btnDeselectAllCards = new System.Windows.Forms.Button();
            this.cblstCards = new System.Windows.Forms.CheckedListBox();
            this.tabQuests = new System.Windows.Forms.TabPage();
            this.grpQuests = new System.Windows.Forms.GroupBox();
            this.btnSelectAllQuests = new System.Windows.Forms.Button();
            this.btnResetQuests = new System.Windows.Forms.Button();
            this.btnDeselectAllQuests = new System.Windows.Forms.Button();
            this.cblstQuests = new System.Windows.Forms.CheckedListBox();
            this.tabEnemiesSeen = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectAllEnemiesSeen = new System.Windows.Forms.Button();
            this.btnResetEnemiesSeen = new System.Windows.Forms.Button();
            this.btnDeselectAllEnemiesSeen = new System.Windows.Forms.Button();
            this.cblstEnemiesSeens = new System.Windows.Forms.CheckedListBox();
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
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSkillsMelee = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.sliderSkillMelee2h4 = new System.Windows.Forms.TrackBar();
            this.sliderSkillMelee2h0 = new System.Windows.Forms.TrackBar();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMelee2h1 = new System.Windows.Forms.TrackBar();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMelee2h3 = new System.Windows.Forms.TrackBar();
            this.sliderSkillMelee2h2 = new System.Windows.Forms.TrackBar();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.sliderSkillMelee1h0 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMelee1h1 = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMelee1h2 = new System.Windows.Forms.TrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMelee1h3 = new System.Windows.Forms.TrackBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMelee1h4 = new System.Windows.Forms.TrackBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabSkillsMagic = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.sliderSkillMagicA2 = new System.Windows.Forms.TrackBar();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicA1 = new System.Windows.Forms.TrackBar();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicA0 = new System.Windows.Forms.TrackBar();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.sliderSkillMagicE2 = new System.Windows.Forms.TrackBar();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicE1 = new System.Windows.Forms.TrackBar();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicE0 = new System.Windows.Forms.TrackBar();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.sliderSkillMagicI2 = new System.Windows.Forms.TrackBar();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicI1 = new System.Windows.Forms.TrackBar();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicI0 = new System.Windows.Forms.TrackBar();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.sliderSkillMagicF2 = new System.Windows.Forms.TrackBar();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicF1 = new System.Windows.Forms.TrackBar();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.sliderSkillMagicF0 = new System.Windows.Forms.TrackBar();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.tabSkillsUtility = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.sliderUtilityE0 = new System.Windows.Forms.TrackBar();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.sliderUtilityE1 = new System.Windows.Forms.TrackBar();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.sliderUtilityE2 = new System.Windows.Forms.TrackBar();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.sliderUtilityD0 = new System.Windows.Forms.TrackBar();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.sliderUtilityD1 = new System.Windows.Forms.TrackBar();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.sliderUtilityD2 = new System.Windows.Forms.TrackBar();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.sliderUtilityO0 = new System.Windows.Forms.TrackBar();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.sliderUtilityO1 = new System.Windows.Forms.TrackBar();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.sliderUtilityO2 = new System.Windows.Forms.TrackBar();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.tabTalentsGeneral = new System.Windows.Forms.TabPage();
            this.tabTalentsMelee = new System.Windows.Forms.TabPage();
            this.tabTalentsMagic = new System.Windows.Forms.TabPage();
            this.tabTreasureMaps = new System.Windows.Forms.TabPage();
            this.label41 = new System.Windows.Forms.Label();
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
            this.grpEnemiesSeen.SuspendLayout();
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
            this.tabCards.SuspendLayout();
            this.grpCards.SuspendLayout();
            this.tabQuests.SuspendLayout();
            this.grpQuests.SuspendLayout();
            this.tabEnemiesSeen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabQuickslots.SuspendLayout();
            this.grpQuickslots.SuspendLayout();
            this.tabSkills.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSkillsMelee.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabSkillsMagic.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicA0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicE0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicI0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicF0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.tabSkillsUtility.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityE0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityD0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityO0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            this.tabTreasureMaps.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEnemiesSeen
            // 
            this.grpEnemiesSeen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEnemiesSeen.Controls.Add(this.tabChar);
            this.grpEnemiesSeen.Controls.Add(this.tabInventory);
            this.grpEnemiesSeen.Controls.Add(this.tabPets);
            this.grpEnemiesSeen.Controls.Add(this.tabCards);
            this.grpEnemiesSeen.Controls.Add(this.tabQuests);
            this.grpEnemiesSeen.Controls.Add(this.tabEnemiesSeen);
            this.grpEnemiesSeen.Controls.Add(this.tabQuickslots);
            this.grpEnemiesSeen.Controls.Add(this.tabSkills);
            this.grpEnemiesSeen.Controls.Add(this.tabTreasureMaps);
            this.grpEnemiesSeen.Location = new System.Drawing.Point(0, 24);
            this.grpEnemiesSeen.Name = "grpEnemiesSeen";
            this.grpEnemiesSeen.SelectedIndex = 0;
            this.grpEnemiesSeen.Size = new System.Drawing.Size(567, 422);
            this.grpEnemiesSeen.TabIndex = 0;
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
            this.tabChar.Location = new System.Drawing.Point(4, 22);
            this.tabChar.Name = "tabChar";
            this.tabChar.Padding = new System.Windows.Forms.Padding(3);
            this.tabChar.Size = new System.Drawing.Size(559, 396);
            this.tabChar.TabIndex = 3;
            this.tabChar.Text = "Character / Equip";
            this.tabChar.UseVisualStyleBackColor = true;
            // 
            // grpPatch
            // 
            this.grpPatch.BackColor = System.Drawing.Color.Transparent;
            this.grpPatch.Controls.Add(this.lblGamePatch);
            this.grpPatch.Controls.Add(this.label55);
            this.grpPatch.Location = new System.Drawing.Point(169, 158);
            this.grpPatch.Name = "grpPatch";
            this.grpPatch.Size = new System.Drawing.Size(105, 230);
            this.grpPatch.TabIndex = 54;
            this.grpPatch.TabStop = false;
            // 
            // lblGamePatch
            // 
            this.lblGamePatch.AutoSize = true;
            this.lblGamePatch.Location = new System.Drawing.Point(13, 116);
            this.lblGamePatch.Name = "lblGamePatch";
            this.lblGamePatch.Size = new System.Drawing.Size(77, 13);
            this.lblGamePatch.TabIndex = 1;
            this.lblGamePatch.Text = "[Game 0.000a]";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(13, 99);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(71, 13);
            this.label55.TabIndex = 0;
            this.label55.Text = "[Patch 0.99g]";
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(79, 49);
            this.numID.Maximum = new decimal(new int[] {
            -2,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(75, 20);
            this.numID.TabIndex = 53;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.rbFemale);
            this.grpGeneral.Controls.Add(this.lblGender);
            this.grpGeneral.Controls.Add(this.rbMale);
            this.grpGeneral.Controls.Add(this.label51);
            this.grpGeneral.Controls.Add(this.label54);
            this.grpGeneral.Controls.Add(this.txtNickname);
            this.grpGeneral.Controls.Add(this.label29);
            this.grpGeneral.Controls.Add(this.label53);
            this.grpGeneral.Controls.Add(this.numBirtdayMonth);
            this.grpGeneral.Controls.Add(this.numBirthdayDay);
            this.grpGeneral.Controls.Add(this.txtTimePlayed);
            this.grpGeneral.Location = new System.Drawing.Point(6, 4);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(157, 148);
            this.grpGeneral.TabIndex = 52;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(108, 127);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(34, 17);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "♀";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(5, 126);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 52;
            this.lblGender.Text = "Gender:";
            this.Tooltips.SetToolTip(this.lblGender, "Day / Month");
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(73, 127);
            this.rbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(35, 17);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "♂";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(5, 75);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(67, 13);
            this.label51.TabIndex = 44;
            this.label51.Text = "Time played:";
            this.Tooltips.SetToolTip(this.label51, "D:HH:MM:SS");
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(5, 48);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 13);
            this.label54.TabIndex = 51;
            this.label54.Text = "Collector ID:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(47, 19);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(101, 20);
            this.txtNickname.TabIndex = 34;
            this.txtNickname.Text = "tolik518";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 13);
            this.label29.TabIndex = 35;
            this.label29.Text = "Name:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(5, 100);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(48, 13);
            this.label53.TabIndex = 49;
            this.label53.Text = "Birthday:";
            this.Tooltips.SetToolTip(this.label53, "Day / Month");
            // 
            // numBirtdayMonth
            // 
            this.numBirtdayMonth.Location = new System.Drawing.Point(113, 98);
            this.numBirtdayMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numBirtdayMonth.Name = "numBirtdayMonth";
            this.numBirtdayMonth.Size = new System.Drawing.Size(35, 20);
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
            this.numBirthdayDay.Location = new System.Drawing.Point(73, 98);
            this.numBirthdayDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numBirthdayDay.Name = "numBirthdayDay";
            this.numBirthdayDay.Size = new System.Drawing.Size(35, 20);
            this.numBirthdayDay.TabIndex = 46;
            this.numBirthdayDay.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // txtTimePlayed
            // 
            this.txtTimePlayed.Location = new System.Drawing.Point(73, 72);
            this.txtTimePlayed.MaxLength = 13;
            this.txtTimePlayed.Name = "txtTimePlayed";
            this.txtTimePlayed.Size = new System.Drawing.Size(75, 20);
            this.txtTimePlayed.TabIndex = 45;
            this.Tooltips.SetToolTip(this.txtTimePlayed, "D:HH:MM:SS");
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(435, 378);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(116, 13);
            this.label49.TabIndex = 42;
            this.label49.Text = "↑ ↑ ↓ ↓ ← → ← → B A";
            // 
            // grpEquipped
            // 
            this.grpEquipped.Controls.Add(this.label10);
            this.grpEquipped.Controls.Add(this.label9);
            this.grpEquipped.Controls.Add(this.label8);
            this.grpEquipped.Controls.Add(this.label7);
            this.grpEquipped.Controls.Add(this.label6);
            this.grpEquipped.Controls.Add(this.label11);
            this.grpEquipped.Controls.Add(this.label12);
            this.grpEquipped.Controls.Add(this.label13);
            this.grpEquipped.Controls.Add(this.cbAccessory2);
            this.grpEquipped.Controls.Add(this.cbAccessory1);
            this.grpEquipped.Controls.Add(this.cbShoes);
            this.grpEquipped.Controls.Add(this.cbArmor);
            this.grpEquipped.Controls.Add(this.cbShield);
            this.grpEquipped.Controls.Add(this.cbWeapon);
            this.grpEquipped.Controls.Add(this.cbFacegear);
            this.grpEquipped.Controls.Add(this.cbHat);
            this.grpEquipped.Location = new System.Drawing.Point(280, 4);
            this.grpEquipped.Name = "grpEquipped";
            this.grpEquipped.Size = new System.Drawing.Size(271, 239);
            this.grpEquipped.TabIndex = 40;
            this.grpEquipped.TabStop = false;
            this.grpEquipped.Text = "Equipped Gear";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Accessory 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Accessory 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Shoes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Armor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Shield:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Weapon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Facegear:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Hat:";
            // 
            // cbAccessory2
            // 
            this.cbAccessory2.FormattingEnabled = true;
            this.cbAccessory2.Location = new System.Drawing.Point(79, 208);
            this.cbAccessory2.Name = "cbAccessory2";
            this.cbAccessory2.Size = new System.Drawing.Size(186, 21);
            this.cbAccessory2.TabIndex = 14;
            // 
            // cbAccessory1
            // 
            this.cbAccessory1.FormattingEnabled = true;
            this.cbAccessory1.Location = new System.Drawing.Point(79, 181);
            this.cbAccessory1.Name = "cbAccessory1";
            this.cbAccessory1.Size = new System.Drawing.Size(186, 21);
            this.cbAccessory1.TabIndex = 13;
            // 
            // cbShoes
            // 
            this.cbShoes.FormattingEnabled = true;
            this.cbShoes.Location = new System.Drawing.Point(79, 154);
            this.cbShoes.Name = "cbShoes";
            this.cbShoes.Size = new System.Drawing.Size(186, 21);
            this.cbShoes.TabIndex = 12;
            // 
            // cbArmor
            // 
            this.cbArmor.FormattingEnabled = true;
            this.cbArmor.Location = new System.Drawing.Point(79, 127);
            this.cbArmor.Name = "cbArmor";
            this.cbArmor.Size = new System.Drawing.Size(186, 21);
            this.cbArmor.TabIndex = 11;
            // 
            // cbShield
            // 
            this.cbShield.FormattingEnabled = true;
            this.cbShield.Location = new System.Drawing.Point(79, 100);
            this.cbShield.Name = "cbShield";
            this.cbShield.Size = new System.Drawing.Size(186, 21);
            this.cbShield.TabIndex = 10;
            // 
            // cbWeapon
            // 
            this.cbWeapon.FormattingEnabled = true;
            this.cbWeapon.Location = new System.Drawing.Point(79, 73);
            this.cbWeapon.Name = "cbWeapon";
            this.cbWeapon.Size = new System.Drawing.Size(186, 21);
            this.cbWeapon.TabIndex = 9;
            // 
            // cbFacegear
            // 
            this.cbFacegear.FormattingEnabled = true;
            this.cbFacegear.Location = new System.Drawing.Point(79, 46);
            this.cbFacegear.Name = "cbFacegear";
            this.cbFacegear.Size = new System.Drawing.Size(186, 21);
            this.cbFacegear.TabIndex = 8;
            // 
            // cbHat
            // 
            this.cbHat.FormattingEnabled = true;
            this.cbHat.Location = new System.Drawing.Point(79, 19);
            this.cbHat.Name = "cbHat";
            this.cbHat.Size = new System.Drawing.Size(186, 21);
            this.cbHat.TabIndex = 7;
            // 
            // grpEquippedStyle
            // 
            this.grpEquippedStyle.Controls.Add(this.label14);
            this.grpEquippedStyle.Controls.Add(this.cbStyleShield);
            this.grpEquippedStyle.Controls.Add(this.label15);
            this.grpEquippedStyle.Controls.Add(this.cbStyleHat);
            this.grpEquippedStyle.Controls.Add(this.label16);
            this.grpEquippedStyle.Controls.Add(this.cbStyleFacegear);
            this.grpEquippedStyle.Controls.Add(this.label17);
            this.grpEquippedStyle.Controls.Add(this.cbStyleWeapon);
            this.grpEquippedStyle.Location = new System.Drawing.Point(280, 249);
            this.grpEquippedStyle.Name = "grpEquippedStyle";
            this.grpEquippedStyle.Size = new System.Drawing.Size(271, 129);
            this.grpEquippedStyle.TabIndex = 41;
            this.grpEquippedStyle.TabStop = false;
            this.grpEquippedStyle.Text = "Equipped Style";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Shield:";
            // 
            // cbStyleShield
            // 
            this.cbStyleShield.FormattingEnabled = true;
            this.cbStyleShield.Location = new System.Drawing.Point(79, 100);
            this.cbStyleShield.Name = "cbStyleShield";
            this.cbStyleShield.Size = new System.Drawing.Size(186, 21);
            this.cbStyleShield.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Weapon:";
            // 
            // cbStyleHat
            // 
            this.cbStyleHat.FormattingEnabled = true;
            this.cbStyleHat.Location = new System.Drawing.Point(79, 19);
            this.cbStyleHat.Name = "cbStyleHat";
            this.cbStyleHat.Size = new System.Drawing.Size(186, 21);
            this.cbStyleHat.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Facegear:";
            // 
            // cbStyleFacegear
            // 
            this.cbStyleFacegear.FormattingEnabled = true;
            this.cbStyleFacegear.Location = new System.Drawing.Point(79, 46);
            this.cbStyleFacegear.Name = "cbStyleFacegear";
            this.cbStyleFacegear.Size = new System.Drawing.Size(186, 21);
            this.cbStyleFacegear.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Hat:";
            // 
            // cbStyleWeapon
            // 
            this.cbStyleWeapon.FormattingEnabled = true;
            this.cbStyleWeapon.Location = new System.Drawing.Point(79, 73);
            this.cbStyleWeapon.Name = "cbStyleWeapon";
            this.cbStyleWeapon.Size = new System.Drawing.Size(186, 21);
            this.cbStyleWeapon.TabIndex = 25;
            // 
            // grpSkillpoints
            // 
            this.grpSkillpoints.Controls.Add(this.numSkillTalentPoints);
            this.grpSkillpoints.Controls.Add(this.label36);
            this.grpSkillpoints.Controls.Add(this.numSkillSilverPoints);
            this.grpSkillpoints.Controls.Add(this.numSkillGoldPoints);
            this.grpSkillpoints.Controls.Add(this.label35);
            this.grpSkillpoints.Controls.Add(this.label34);
            this.grpSkillpoints.Location = new System.Drawing.Point(6, 288);
            this.grpSkillpoints.Name = "grpSkillpoints";
            this.grpSkillpoints.Size = new System.Drawing.Size(157, 100);
            this.grpSkillpoints.TabIndex = 37;
            this.grpSkillpoints.TabStop = false;
            this.grpSkillpoints.Text = "Skill Points";
            // 
            // numSkillTalentPoints
            // 
            this.numSkillTalentPoints.Location = new System.Drawing.Point(95, 20);
            this.numSkillTalentPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numSkillTalentPoints.Name = "numSkillTalentPoints";
            this.numSkillTalentPoints.Size = new System.Drawing.Size(51, 20);
            this.numSkillTalentPoints.TabIndex = 3;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(5, 74);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 13);
            this.label36.TabIndex = 2;
            this.label36.Text = "Gold Skill Point:";
            // 
            // numSkillSilverPoints
            // 
            this.numSkillSilverPoints.Location = new System.Drawing.Point(95, 46);
            this.numSkillSilverPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numSkillSilverPoints.Name = "numSkillSilverPoints";
            this.numSkillSilverPoints.Size = new System.Drawing.Size(51, 20);
            this.numSkillSilverPoints.TabIndex = 4;
            // 
            // numSkillGoldPoints
            // 
            this.numSkillGoldPoints.Location = new System.Drawing.Point(95, 72);
            this.numSkillGoldPoints.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numSkillGoldPoints.Name = "numSkillGoldPoints";
            this.numSkillGoldPoints.Size = new System.Drawing.Size(51, 20);
            this.numSkillGoldPoints.TabIndex = 5;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 48);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(85, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Silver Skill Point:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(5, 22);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(72, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Talent Points:";
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.label33);
            this.grpLevel.Controls.Add(this.label32);
            this.grpLevel.Controls.Add(this.label31);
            this.grpLevel.Controls.Add(this.label30);
            this.grpLevel.Controls.Add(this.numEXPUnknown1);
            this.grpLevel.Controls.Add(this.numEXPUnknown0);
            this.grpLevel.Controls.Add(this.numEXPcurrent);
            this.grpLevel.Controls.Add(this.numLevel);
            this.grpLevel.Location = new System.Drawing.Point(6, 158);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(157, 126);
            this.grpLevel.TabIndex = 36;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "Level";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(5, 99);
            this.label33.Name = "label33";
            this.label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label33.Size = new System.Drawing.Size(89, 13);
            this.label33.TabIndex = 7;
            this.label33.Text = "[EXPUnknown1]:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(5, 73);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 13);
            this.label32.TabIndex = 6;
            this.label32.Text = "[EXPUnknown0]:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 47);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 13);
            this.label31.TabIndex = 5;
            this.label31.Text = "Current EXP:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Level:";
            // 
            // numEXPUnknown1
            // 
            this.numEXPUnknown1.Location = new System.Drawing.Point(96, 97);
            this.numEXPUnknown1.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numEXPUnknown1.Name = "numEXPUnknown1";
            this.numEXPUnknown1.Size = new System.Drawing.Size(51, 20);
            this.numEXPUnknown1.TabIndex = 3;
            this.Tooltips.SetToolTip(this.numEXPUnknown1, "idk? probably the exp you need to level up?");
            // 
            // numEXPUnknown0
            // 
            this.numEXPUnknown0.Location = new System.Drawing.Point(96, 71);
            this.numEXPUnknown0.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numEXPUnknown0.Name = "numEXPUnknown0";
            this.numEXPUnknown0.Size = new System.Drawing.Size(51, 20);
            this.numEXPUnknown0.TabIndex = 2;
            this.Tooltips.SetToolTip(this.numEXPUnknown0, "idk");
            // 
            // numEXPcurrent
            // 
            this.numEXPcurrent.Location = new System.Drawing.Point(96, 45);
            this.numEXPcurrent.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numEXPcurrent.Name = "numEXPcurrent";
            this.numEXPcurrent.Size = new System.Drawing.Size(51, 20);
            this.numEXPcurrent.TabIndex = 1;
            this.Tooltips.SetToolTip(this.numEXPcurrent, "Seit it to 9999 to level up after next kill");
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(108, 19);
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
            this.numLevel.Size = new System.Drawing.Size(39, 20);
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
            this.grpColors.Controls.Add(this.label5);
            this.grpColors.Controls.Add(this.label4);
            this.grpColors.Controls.Add(this.label3);
            this.grpColors.Controls.Add(this.label2);
            this.grpColors.Controls.Add(this.btnPantsColor);
            this.grpColors.Controls.Add(this.btnShirtColor);
            this.grpColors.Controls.Add(this.btnPonchoColor);
            this.grpColors.Controls.Add(this.btnSkinColor);
            this.grpColors.Controls.Add(this.btnHairColor);
            this.grpColors.Controls.Add(this.label1);
            this.grpColors.Location = new System.Drawing.Point(169, 4);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(105, 148);
            this.grpColors.TabIndex = 33;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Colors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pants:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Shirt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Poncho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Skin:";
            // 
            // btnPantsColor
            // 
            this.btnPantsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantsColor.Location = new System.Drawing.Point(74, 118);
            this.btnPantsColor.Name = "btnPantsColor";
            this.btnPantsColor.Size = new System.Drawing.Size(20, 20);
            this.btnPantsColor.TabIndex = 9;
            this.btnPantsColor.TabStop = false;
            this.btnPantsColor.UseVisualStyleBackColor = false;
            this.btnPantsColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // btnShirtColor
            // 
            this.btnShirtColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShirtColor.Location = new System.Drawing.Point(74, 92);
            this.btnShirtColor.Name = "btnShirtColor";
            this.btnShirtColor.Size = new System.Drawing.Size(20, 20);
            this.btnShirtColor.TabIndex = 8;
            this.btnShirtColor.TabStop = false;
            this.btnShirtColor.UseVisualStyleBackColor = false;
            this.btnShirtColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // btnPonchoColor
            // 
            this.btnPonchoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonchoColor.Location = new System.Drawing.Point(74, 66);
            this.btnPonchoColor.Name = "btnPonchoColor";
            this.btnPonchoColor.Size = new System.Drawing.Size(20, 20);
            this.btnPonchoColor.TabIndex = 7;
            this.btnPonchoColor.TabStop = false;
            this.btnPonchoColor.UseVisualStyleBackColor = false;
            this.btnPonchoColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // btnSkinColor
            // 
            this.btnSkinColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkinColor.Location = new System.Drawing.Point(74, 40);
            this.btnSkinColor.Name = "btnSkinColor";
            this.btnSkinColor.Size = new System.Drawing.Size(20, 20);
            this.btnSkinColor.TabIndex = 6;
            this.btnSkinColor.TabStop = false;
            this.Tooltips.SetToolTip(this.btnSkinColor, "Not implemented yet");
            this.btnSkinColor.UseVisualStyleBackColor = false;
            // 
            // btnHairColor
            // 
            this.btnHairColor.BackColor = System.Drawing.Color.White;
            this.btnHairColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHairColor.Location = new System.Drawing.Point(74, 14);
            this.btnHairColor.Name = "btnHairColor";
            this.btnHairColor.Size = new System.Drawing.Size(20, 20);
            this.btnHairColor.TabIndex = 5;
            this.btnHairColor.TabStop = false;
            this.btnHairColor.UseVisualStyleBackColor = false;
            this.btnHairColor.Click += new System.EventHandler(this.ClothingColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hair:";
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.numGold);
            this.tabInventory.Controls.Add(this.label37);
            this.tabInventory.Controls.Add(this.grpItem);
            this.tabInventory.Controls.Add(this.lstInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(559, 396);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // numGold
            // 
            this.numGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numGold.Location = new System.Drawing.Point(450, 361);
            this.numGold.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numGold.Name = "numGold";
            this.numGold.Size = new System.Drawing.Size(101, 20);
            this.numGold.TabIndex = 40;
            this.Tooltips.SetToolTip(this.numGold, "Money/Papes/Cheddar/Mulla/Dollar/Coins/Green Faces/Loochies/Bread/Dosh");
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(447, 345);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(32, 13);
            this.label37.TabIndex = 41;
            this.label37.Text = "Gold:";
            // 
            // grpItem
            // 
            this.grpItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpItem.Controls.Add(this.btnDeleteSelectedItem);
            this.grpItem.Controls.Add(this.btnAddItem);
            this.grpItem.Controls.Add(this.label28);
            this.grpItem.Controls.Add(this.numItemCount);
            this.grpItem.Controls.Add(this.cbSelectedItem);
            this.grpItem.Location = new System.Drawing.Point(3, 315);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(319, 74);
            this.grpItem.TabIndex = 1;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            // 
            // btnDeleteSelectedItem
            // 
            this.btnDeleteSelectedItem.Location = new System.Drawing.Point(253, 43);
            this.btnDeleteSelectedItem.Name = "btnDeleteSelectedItem";
            this.btnDeleteSelectedItem.Size = new System.Drawing.Size(60, 23);
            this.btnDeleteSelectedItem.TabIndex = 2;
            this.btnDeleteSelectedItem.Text = "Remove";
            this.btnDeleteSelectedItem.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedItem.Click += new System.EventHandler(this.BtnDeleteSelectedItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(253, 17);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(60, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.Tooltips.SetToolTip(this.btnAddItem, "Some Items COULD potentially break your game");
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(132, 48);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Count:";
            // 
            // numItemCount
            // 
            this.numItemCount.Location = new System.Drawing.Point(176, 46);
            this.numItemCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numItemCount.Name = "numItemCount";
            this.numItemCount.Size = new System.Drawing.Size(71, 20);
            this.numItemCount.TabIndex = 1;
            this.numItemCount.ValueChanged += new System.EventHandler(this.NumItemCount_ValueChanged);
            // 
            // cbSelectedItem
            // 
            this.cbSelectedItem.FormattingEnabled = true;
            this.cbSelectedItem.Location = new System.Drawing.Point(6, 19);
            this.cbSelectedItem.Name = "cbSelectedItem";
            this.cbSelectedItem.Size = new System.Drawing.Size(241, 21);
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
            this.lstInventory.Location = new System.Drawing.Point(6, 6);
            this.lstInventory.MultiSelect = false;
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(547, 303);
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
            this.tabPets.Location = new System.Drawing.Point(4, 22);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(559, 396);
            this.tabPets.TabIndex = 8;
            this.tabPets.Text = "Pets";
            this.tabPets.UseVisualStyleBackColor = true;
            // 
            // lstPets
            // 
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
            this.lstPets.Location = new System.Drawing.Point(6, 6);
            this.lstPets.MultiSelect = false;
            this.lstPets.Name = "lstPets";
            this.lstPets.Size = new System.Drawing.Size(368, 383);
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
            this.grpPet.Controls.Add(this.cbPetType);
            this.grpPet.Controls.Add(this.label52);
            this.grpPet.Controls.Add(this.numPetLevel);
            this.grpPet.Controls.Add(this.label48);
            this.grpPet.Controls.Add(this.label47);
            this.grpPet.Controls.Add(this.label46);
            this.grpPet.Controls.Add(this.label45);
            this.grpPet.Controls.Add(this.label44);
            this.grpPet.Controls.Add(this.label42);
            this.grpPet.Controls.Add(this.txtPetNickname);
            this.grpPet.Controls.Add(this.label43);
            this.grpPet.Controls.Add(this.numPetSpeed);
            this.grpPet.Controls.Add(this.numPetCrit);
            this.grpPet.Controls.Add(this.numPetDamage);
            this.grpPet.Controls.Add(this.numPetEnergy);
            this.grpPet.Controls.Add(this.numPetHP);
            this.grpPet.Location = new System.Drawing.Point(380, 6);
            this.grpPet.Name = "grpPet";
            this.grpPet.Size = new System.Drawing.Size(171, 227);
            this.grpPet.TabIndex = 0;
            this.grpPet.TabStop = false;
            this.grpPet.Text = "Pet";
            // 
            // cbPetType
            // 
            this.cbPetType.Enabled = false;
            this.cbPetType.FormattingEnabled = true;
            this.cbPetType.Location = new System.Drawing.Point(73, 46);
            this.cbPetType.Name = "cbPetType";
            this.cbPetType.Size = new System.Drawing.Size(93, 21);
            this.cbPetType.TabIndex = 2;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 49);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(26, 13);
            this.label52.TabIndex = 15;
            this.label52.Text = "Pet:";
            // 
            // numPetLevel
            // 
            this.numPetLevel.Location = new System.Drawing.Point(111, 72);
            this.numPetLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPetLevel.Name = "numPetLevel";
            this.numPetLevel.Size = new System.Drawing.Size(55, 20);
            this.numPetLevel.TabIndex = 14;
            this.numPetLevel.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 74);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(51, 13);
            this.label48.TabIndex = 13;
            this.label48.Text = "Pet level:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 199);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(66, 13);
            this.label47.TabIndex = 12;
            this.label47.Text = "Speed level:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 174);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(50, 13);
            this.label46.TabIndex = 11;
            this.label46.Text = "Crit level:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 149);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(75, 13);
            this.label45.TabIndex = 10;
            this.label45.Text = "Damage level:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 124);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 13);
            this.label44.TabIndex = 9;
            this.label44.Text = "Energy level:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 24);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(58, 13);
            this.label42.TabIndex = 2;
            this.label42.Text = "Nickname:";
            // 
            // txtPetNickname
            // 
            this.txtPetNickname.Location = new System.Drawing.Point(73, 21);
            this.txtPetNickname.Name = "txtPetNickname";
            this.txtPetNickname.Size = new System.Drawing.Size(93, 20);
            this.txtPetNickname.TabIndex = 1;
            this.txtPetNickname.TextChanged += new System.EventHandler(this.TxtPetNickname_TextChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 99);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(66, 13);
            this.label43.TabIndex = 8;
            this.label43.Text = "Health level:";
            // 
            // numPetSpeed
            // 
            this.numPetSpeed.Location = new System.Drawing.Point(111, 197);
            this.numPetSpeed.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetSpeed.Name = "numPetSpeed";
            this.numPetSpeed.Size = new System.Drawing.Size(55, 20);
            this.numPetSpeed.TabIndex = 7;
            this.numPetSpeed.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetCrit
            // 
            this.numPetCrit.Location = new System.Drawing.Point(111, 172);
            this.numPetCrit.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetCrit.Name = "numPetCrit";
            this.numPetCrit.Size = new System.Drawing.Size(55, 20);
            this.numPetCrit.TabIndex = 6;
            this.numPetCrit.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetDamage
            // 
            this.numPetDamage.Location = new System.Drawing.Point(111, 147);
            this.numPetDamage.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetDamage.Name = "numPetDamage";
            this.numPetDamage.Size = new System.Drawing.Size(55, 20);
            this.numPetDamage.TabIndex = 5;
            this.numPetDamage.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetEnergy
            // 
            this.numPetEnergy.Location = new System.Drawing.Point(111, 122);
            this.numPetEnergy.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetEnergy.Name = "numPetEnergy";
            this.numPetEnergy.Size = new System.Drawing.Size(55, 20);
            this.numPetEnergy.TabIndex = 4;
            this.numPetEnergy.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // numPetHP
            // 
            this.numPetHP.Location = new System.Drawing.Point(111, 97);
            this.numPetHP.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPetHP.Name = "numPetHP";
            this.numPetHP.Size = new System.Drawing.Size(55, 20);
            this.numPetHP.TabIndex = 3;
            this.numPetHP.ValueChanged += new System.EventHandler(this.NumPetStat_ValueChanged);
            // 
            // tabCards
            // 
            this.tabCards.Controls.Add(this.grpCards);
            this.tabCards.Controls.Add(this.cblstCards);
            this.tabCards.Location = new System.Drawing.Point(4, 22);
            this.tabCards.Name = "tabCards";
            this.tabCards.Padding = new System.Windows.Forms.Padding(3);
            this.tabCards.Size = new System.Drawing.Size(559, 396);
            this.tabCards.TabIndex = 5;
            this.tabCards.Text = "Cards";
            this.tabCards.UseVisualStyleBackColor = true;
            // 
            // grpCards
            // 
            this.grpCards.Controls.Add(this.btnSelectAllCards);
            this.grpCards.Controls.Add(this.btnResetCards);
            this.grpCards.Controls.Add(this.btnDeselectAllCards);
            this.grpCards.Location = new System.Drawing.Point(454, 6);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(97, 379);
            this.grpCards.TabIndex = 6;
            this.grpCards.TabStop = false;
            this.grpCards.Text = "Cards";
            // 
            // btnSelectAllCards
            // 
            this.btnSelectAllCards.Location = new System.Drawing.Point(6, 19);
            this.btnSelectAllCards.Name = "btnSelectAllCards";
            this.btnSelectAllCards.Size = new System.Drawing.Size(87, 23);
            this.btnSelectAllCards.TabIndex = 3;
            this.btnSelectAllCards.Text = "Select all";
            this.btnSelectAllCards.UseVisualStyleBackColor = true;
            this.btnSelectAllCards.Click += new System.EventHandler(this.btnSelectAllCards_Click);
            // 
            // btnResetCards
            // 
            this.btnResetCards.Location = new System.Drawing.Point(6, 350);
            this.btnResetCards.Name = "btnResetCards";
            this.btnResetCards.Size = new System.Drawing.Size(87, 23);
            this.btnResetCards.TabIndex = 5;
            this.btnResetCards.Text = "Reset";
            this.btnResetCards.UseVisualStyleBackColor = true;
            this.btnResetCards.Click += new System.EventHandler(this.btnResetCards_Click);
            // 
            // btnDeselectAllCards
            // 
            this.btnDeselectAllCards.Location = new System.Drawing.Point(6, 48);
            this.btnDeselectAllCards.Name = "btnDeselectAllCards";
            this.btnDeselectAllCards.Size = new System.Drawing.Size(87, 23);
            this.btnDeselectAllCards.TabIndex = 4;
            this.btnDeselectAllCards.Text = "Deselect all";
            this.btnDeselectAllCards.UseVisualStyleBackColor = true;
            this.btnDeselectAllCards.Click += new System.EventHandler(this.btnDeselectAllCards_Click);
            // 
            // cblstCards
            // 
            this.cblstCards.FormattingEnabled = true;
            this.cblstCards.Location = new System.Drawing.Point(6, 6);
            this.cblstCards.Name = "cblstCards";
            this.cblstCards.Size = new System.Drawing.Size(442, 379);
            this.cblstCards.TabIndex = 2;
            // 
            // tabQuests
            // 
            this.tabQuests.Controls.Add(this.grpQuests);
            this.tabQuests.Controls.Add(this.cblstQuests);
            this.tabQuests.Location = new System.Drawing.Point(4, 22);
            this.tabQuests.Name = "tabQuests";
            this.tabQuests.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuests.Size = new System.Drawing.Size(559, 396);
            this.tabQuests.TabIndex = 9;
            this.tabQuests.Text = "Quests";
            this.tabQuests.UseVisualStyleBackColor = true;
            // 
            // grpQuests
            // 
            this.grpQuests.Controls.Add(this.btnSelectAllQuests);
            this.grpQuests.Controls.Add(this.btnResetQuests);
            this.grpQuests.Controls.Add(this.btnDeselectAllQuests);
            this.grpQuests.Location = new System.Drawing.Point(454, 6);
            this.grpQuests.Name = "grpQuests";
            this.grpQuests.Size = new System.Drawing.Size(97, 379);
            this.grpQuests.TabIndex = 8;
            this.grpQuests.TabStop = false;
            this.grpQuests.Text = "Quests";
            // 
            // btnSelectAllQuests
            // 
            this.btnSelectAllQuests.Location = new System.Drawing.Point(6, 19);
            this.btnSelectAllQuests.Name = "btnSelectAllQuests";
            this.btnSelectAllQuests.Size = new System.Drawing.Size(87, 23);
            this.btnSelectAllQuests.TabIndex = 3;
            this.btnSelectAllQuests.Text = "Select all";
            this.btnSelectAllQuests.UseVisualStyleBackColor = true;
            this.btnSelectAllQuests.Click += new System.EventHandler(this.btnSelectAllQuests_Click);
            // 
            // btnResetQuests
            // 
            this.btnResetQuests.Location = new System.Drawing.Point(6, 350);
            this.btnResetQuests.Name = "btnResetQuests";
            this.btnResetQuests.Size = new System.Drawing.Size(87, 23);
            this.btnResetQuests.TabIndex = 5;
            this.btnResetQuests.Text = "Reset";
            this.btnResetQuests.UseVisualStyleBackColor = true;
            this.btnResetQuests.Click += new System.EventHandler(this.btnResetQuests_Click);
            // 
            // btnDeselectAllQuests
            // 
            this.btnDeselectAllQuests.Location = new System.Drawing.Point(6, 48);
            this.btnDeselectAllQuests.Name = "btnDeselectAllQuests";
            this.btnDeselectAllQuests.Size = new System.Drawing.Size(87, 23);
            this.btnDeselectAllQuests.TabIndex = 4;
            this.btnDeselectAllQuests.Text = "Deselect all";
            this.btnDeselectAllQuests.UseVisualStyleBackColor = true;
            this.btnDeselectAllQuests.Click += new System.EventHandler(this.btnDeselectAllQuests_Click);
            // 
            // cblstQuests
            // 
            this.cblstQuests.FormattingEnabled = true;
            this.cblstQuests.Location = new System.Drawing.Point(6, 6);
            this.cblstQuests.Name = "cblstQuests";
            this.cblstQuests.Size = new System.Drawing.Size(442, 379);
            this.cblstQuests.TabIndex = 7;
            // 
            // tabEnemiesSeen
            // 
            this.tabEnemiesSeen.Controls.Add(this.groupBox1);
            this.tabEnemiesSeen.Controls.Add(this.cblstEnemiesSeens);
            this.tabEnemiesSeen.Location = new System.Drawing.Point(4, 22);
            this.tabEnemiesSeen.Name = "tabEnemiesSeen";
            this.tabEnemiesSeen.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnemiesSeen.Size = new System.Drawing.Size(559, 396);
            this.tabEnemiesSeen.TabIndex = 4;
            this.tabEnemiesSeen.Text = "Enemies seen";
            this.tabEnemiesSeen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectAllEnemiesSeen);
            this.groupBox1.Controls.Add(this.btnResetEnemiesSeen);
            this.groupBox1.Controls.Add(this.btnDeselectAllEnemiesSeen);
            this.groupBox1.Location = new System.Drawing.Point(454, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 379);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enemies seen";
            // 
            // btnSelectAllEnemiesSeen
            // 
            this.btnSelectAllEnemiesSeen.Location = new System.Drawing.Point(6, 19);
            this.btnSelectAllEnemiesSeen.Name = "btnSelectAllEnemiesSeen";
            this.btnSelectAllEnemiesSeen.Size = new System.Drawing.Size(87, 23);
            this.btnSelectAllEnemiesSeen.TabIndex = 3;
            this.btnSelectAllEnemiesSeen.Text = "Select all";
            this.btnSelectAllEnemiesSeen.UseVisualStyleBackColor = true;
            this.btnSelectAllEnemiesSeen.Click += new System.EventHandler(this.btnSelectAllEnemiesSeen_Click);
            // 
            // btnResetEnemiesSeen
            // 
            this.btnResetEnemiesSeen.Location = new System.Drawing.Point(6, 350);
            this.btnResetEnemiesSeen.Name = "btnResetEnemiesSeen";
            this.btnResetEnemiesSeen.Size = new System.Drawing.Size(87, 23);
            this.btnResetEnemiesSeen.TabIndex = 5;
            this.btnResetEnemiesSeen.Text = "Reset";
            this.btnResetEnemiesSeen.UseVisualStyleBackColor = true;
            this.btnResetEnemiesSeen.Click += new System.EventHandler(this.btnResetEnemiesSeen_Click);
            // 
            // btnDeselectAllEnemiesSeen
            // 
            this.btnDeselectAllEnemiesSeen.Location = new System.Drawing.Point(6, 48);
            this.btnDeselectAllEnemiesSeen.Name = "btnDeselectAllEnemiesSeen";
            this.btnDeselectAllEnemiesSeen.Size = new System.Drawing.Size(87, 23);
            this.btnDeselectAllEnemiesSeen.TabIndex = 4;
            this.btnDeselectAllEnemiesSeen.Text = "Deselect all";
            this.btnDeselectAllEnemiesSeen.UseVisualStyleBackColor = true;
            this.btnDeselectAllEnemiesSeen.Click += new System.EventHandler(this.btnDeselectAllEnemiesSeen_Click);
            // 
            // cblstEnemiesSeens
            // 
            this.cblstEnemiesSeens.FormattingEnabled = true;
            this.cblstEnemiesSeens.Location = new System.Drawing.Point(6, 6);
            this.cblstEnemiesSeens.Name = "cblstEnemiesSeens";
            this.cblstEnemiesSeens.Size = new System.Drawing.Size(442, 379);
            this.cblstEnemiesSeens.TabIndex = 9;
            // 
            // tabQuickslots
            // 
            this.tabQuickslots.Controls.Add(this.label57);
            this.tabQuickslots.Controls.Add(this.grpQuickslots);
            this.tabQuickslots.Location = new System.Drawing.Point(4, 22);
            this.tabQuickslots.Name = "tabQuickslots";
            this.tabQuickslots.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuickslots.Size = new System.Drawing.Size(559, 396);
            this.tabQuickslots.TabIndex = 1;
            this.tabQuickslots.Text = "*Quickslots";
            this.tabQuickslots.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label57.Location = new System.Drawing.Point(6, 303);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(389, 13);
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
            this.grpQuickslots.Location = new System.Drawing.Point(6, 6);
            this.grpQuickslots.Name = "grpQuickslots";
            this.grpQuickslots.Size = new System.Drawing.Size(341, 294);
            this.grpQuickslots.TabIndex = 29;
            this.grpQuickslots.TabStop = false;
            this.grpQuickslots.Text = "Quckslots";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Quckslot 0 (C):";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 265);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Quckslot 9 (R):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Quckslot 8 (E):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Quckslot 7 (W):";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Quckslot 6 (Q):";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "Quckslot 5 (F):";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 130);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Quckslot 4 (V):";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 17;
            this.label25.Text = "Quckslot 3 (D):";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "Quckslot 2 (S):";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "Quckslot 1 (A):";
            // 
            // tabSkills
            // 
            this.tabSkills.BackColor = System.Drawing.Color.Transparent;
            this.tabSkills.Controls.Add(this.tabControl1);
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(559, 396);
            this.tabSkills.TabIndex = 7;
            this.tabSkills.Text = "*Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabSkillsMelee);
            this.tabControl1.Controls.Add(this.tabSkillsMagic);
            this.tabControl1.Controls.Add(this.tabSkillsUtility);
            this.tabControl1.Controls.Add(this.tabTalentsGeneral);
            this.tabControl1.Controls.Add(this.tabTalentsMelee);
            this.tabControl1.Controls.Add(this.tabTalentsMagic);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 100);
            this.tabControl1.Location = new System.Drawing.Point(8, 6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 365);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 32;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem);
            // 
            // tabSkillsMelee
            // 
            this.tabSkillsMelee.Controls.Add(this.groupBox11);
            this.tabSkillsMelee.Controls.Add(this.groupBox10);
            this.tabSkillsMelee.Location = new System.Drawing.Point(104, 4);
            this.tabSkillsMelee.Name = "tabSkillsMelee";
            this.tabSkillsMelee.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkillsMelee.Size = new System.Drawing.Size(437, 357);
            this.tabSkillsMelee.TabIndex = 0;
            this.tabSkillsMelee.Text = "Skills: Melee";
            this.tabSkillsMelee.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.sliderSkillMelee2h4);
            this.groupBox11.Controls.Add(this.sliderSkillMelee2h0);
            this.groupBox11.Controls.Add(this.pictureBox7);
            this.groupBox11.Controls.Add(this.pictureBox11);
            this.groupBox11.Controls.Add(this.sliderSkillMelee2h1);
            this.groupBox11.Controls.Add(this.pictureBox8);
            this.groupBox11.Controls.Add(this.pictureBox10);
            this.groupBox11.Controls.Add(this.sliderSkillMelee2h3);
            this.groupBox11.Controls.Add(this.sliderSkillMelee2h2);
            this.groupBox11.Controls.Add(this.pictureBox9);
            this.groupBox11.Location = new System.Drawing.Point(6, 170);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(425, 136);
            this.groupBox11.TabIndex = 21;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Two Handed";
            // 
            // sliderSkillMelee2h4
            // 
            this.sliderSkillMelee2h4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee2h4.Location = new System.Drawing.Point(338, 86);
            this.sliderSkillMelee2h4.Name = "sliderSkillMelee2h4";
            this.sliderSkillMelee2h4.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee2h4.TabIndex = 18;
            this.sliderSkillMelee2h4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee2h4.Value = 10;
            // 
            // sliderSkillMelee2h0
            // 
            this.sliderSkillMelee2h0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee2h0.Location = new System.Drawing.Point(10, 86);
            this.sliderSkillMelee2h0.Name = "sliderSkillMelee2h0";
            this.sliderSkillMelee2h0.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee2h0.TabIndex = 10;
            this.sliderSkillMelee2h0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee2h0.Value = 10;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SoG_SGreader.Properties.Resources.icon_berserk;
            this.pictureBox7.Location = new System.Drawing.Point(355, 34);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 46);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::SoG_SGreader.Properties.Resources.icon_overhead;
            this.pictureBox11.Location = new System.Drawing.Point(27, 34);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(46, 46);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // sliderSkillMelee2h1
            // 
            this.sliderSkillMelee2h1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee2h1.Location = new System.Drawing.Point(95, 86);
            this.sliderSkillMelee2h1.Name = "sliderSkillMelee2h1";
            this.sliderSkillMelee2h1.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee2h1.TabIndex = 12;
            this.sliderSkillMelee2h1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee2h1.Value = 10;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SoG_SGreader.Properties.Resources.icon_2hsmash;
            this.pictureBox8.Location = new System.Drawing.Point(270, 34);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(46, 46);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SoG_SGreader.Properties.Resources.icon_swirl_clover;
            this.pictureBox10.Location = new System.Drawing.Point(112, 34);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(46, 46);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // sliderSkillMelee2h3
            // 
            this.sliderSkillMelee2h3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee2h3.Location = new System.Drawing.Point(253, 86);
            this.sliderSkillMelee2h3.Name = "sliderSkillMelee2h3";
            this.sliderSkillMelee2h3.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee2h3.TabIndex = 16;
            this.sliderSkillMelee2h3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee2h3.Value = 10;
            // 
            // sliderSkillMelee2h2
            // 
            this.sliderSkillMelee2h2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee2h2.Location = new System.Drawing.Point(174, 86);
            this.sliderSkillMelee2h2.Name = "sliderSkillMelee2h2";
            this.sliderSkillMelee2h2.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee2h2.TabIndex = 14;
            this.sliderSkillMelee2h2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee2h2.Value = 10;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SoG_SGreader.Properties.Resources.icon_2hthrow;
            this.pictureBox9.Location = new System.Drawing.Point(191, 34);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(46, 46);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label56);
            this.groupBox10.Controls.Add(this.label38);
            this.groupBox10.Controls.Add(this.sliderSkillMelee1h0);
            this.groupBox10.Controls.Add(this.pictureBox1);
            this.groupBox10.Controls.Add(this.sliderSkillMelee1h1);
            this.groupBox10.Controls.Add(this.pictureBox2);
            this.groupBox10.Controls.Add(this.sliderSkillMelee1h2);
            this.groupBox10.Controls.Add(this.pictureBox4);
            this.groupBox10.Controls.Add(this.sliderSkillMelee1h3);
            this.groupBox10.Controls.Add(this.pictureBox5);
            this.groupBox10.Controls.Add(this.sliderSkillMelee1h4);
            this.groupBox10.Controls.Add(this.pictureBox6);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(425, 158);
            this.groupBox10.TabIndex = 20;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "One Handed";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(24, 20);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(160, 13);
            this.label56.TabIndex = 11;
            this.label56.Text = "*These values will not be saved.";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(24, 120);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(45, 13);
            this.label38.TabIndex = 10;
            this.label38.Text = "Level: 0";
            // 
            // sliderSkillMelee1h0
            // 
            this.sliderSkillMelee1h0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee1h0.Location = new System.Drawing.Point(10, 88);
            this.sliderSkillMelee1h0.Name = "sliderSkillMelee1h0";
            this.sliderSkillMelee1h0.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee1h0.TabIndex = 0;
            this.sliderSkillMelee1h0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Tooltips.SetToolTip(this.sliderSkillMelee1h0, "{sliderSkillMelee1h0.Value}");
            this.sliderSkillMelee1h0.Value = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoG_SGreader.Properties.Resources.icon_stinger_clover;
            this.pictureBox1.Location = new System.Drawing.Point(27, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sliderSkillMelee1h1
            // 
            this.sliderSkillMelee1h1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee1h1.Location = new System.Drawing.Point(95, 88);
            this.sliderSkillMelee1h1.Name = "sliderSkillMelee1h1";
            this.sliderSkillMelee1h1.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee1h1.TabIndex = 2;
            this.sliderSkillMelee1h1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee1h1.Value = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoG_SGreader.Properties.Resources.icon_millionstabs;
            this.pictureBox2.Location = new System.Drawing.Point(112, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // sliderSkillMelee1h2
            // 
            this.sliderSkillMelee1h2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee1h2.Location = new System.Drawing.Point(174, 88);
            this.sliderSkillMelee1h2.Name = "sliderSkillMelee1h2";
            this.sliderSkillMelee1h2.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee1h2.TabIndex = 4;
            this.sliderSkillMelee1h2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee1h2.Value = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SoG_SGreader.Properties.Resources.icon_soulstrike;
            this.pictureBox4.Location = new System.Drawing.Point(191, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // sliderSkillMelee1h3
            // 
            this.sliderSkillMelee1h3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee1h3.Location = new System.Drawing.Point(253, 88);
            this.sliderSkillMelee1h3.Name = "sliderSkillMelee1h3";
            this.sliderSkillMelee1h3.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee1h3.TabIndex = 6;
            this.sliderSkillMelee1h3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee1h3.Value = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SoG_SGreader.Properties.Resources.icon_shadowclone;
            this.pictureBox5.Location = new System.Drawing.Point(270, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // sliderSkillMelee1h4
            // 
            this.sliderSkillMelee1h4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMelee1h4.Location = new System.Drawing.Point(338, 88);
            this.sliderSkillMelee1h4.Name = "sliderSkillMelee1h4";
            this.sliderSkillMelee1h4.Size = new System.Drawing.Size(79, 45);
            this.sliderSkillMelee1h4.TabIndex = 8;
            this.sliderSkillMelee1h4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMelee1h4.Value = 10;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SoG_SGreader.Properties.Resources.icon_dodgingstrike;
            this.pictureBox6.Location = new System.Drawing.Point(355, 36);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 46);
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
            this.tabSkillsMagic.Name = "tabSkillsMagic";
            this.tabSkillsMagic.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkillsMagic.Size = new System.Drawing.Size(437, 357);
            this.tabSkillsMagic.TabIndex = 1;
            this.tabSkillsMagic.Text = "Skills: Magic";
            this.tabSkillsMagic.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.sliderSkillMagicA2);
            this.groupBox15.Controls.Add(this.pictureBox21);
            this.groupBox15.Controls.Add(this.sliderSkillMagicA1);
            this.groupBox15.Controls.Add(this.pictureBox22);
            this.groupBox15.Controls.Add(this.sliderSkillMagicA0);
            this.groupBox15.Controls.Add(this.pictureBox23);
            this.groupBox15.Location = new System.Drawing.Point(221, 170);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(209, 158);
            this.groupBox15.TabIndex = 22;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Air Magic";
            // 
            // sliderSkillMagicA2
            // 
            this.sliderSkillMagicA2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicA2.Location = new System.Drawing.Point(136, 88);
            this.sliderSkillMagicA2.Name = "sliderSkillMagicA2";
            this.sliderSkillMagicA2.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicA2.TabIndex = 10;
            this.sliderSkillMagicA2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicA2.Value = 10;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::SoG_SGreader.Properties.Resources.icon_statictouch;
            this.pictureBox21.Location = new System.Drawing.Point(146, 36);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(46, 46);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 11;
            this.pictureBox21.TabStop = false;
            // 
            // sliderSkillMagicA1
            // 
            this.sliderSkillMagicA1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicA1.Location = new System.Drawing.Point(73, 88);
            this.sliderSkillMagicA1.Name = "sliderSkillMagicA1";
            this.sliderSkillMagicA1.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicA1.TabIndex = 8;
            this.sliderSkillMagicA1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicA1.Value = 10;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::SoG_SGreader.Properties.Resources.icon_summoncloud;
            this.pictureBox22.Location = new System.Drawing.Point(83, 36);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(46, 46);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 9;
            this.pictureBox22.TabStop = false;
            // 
            // sliderSkillMagicA0
            // 
            this.sliderSkillMagicA0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicA0.Location = new System.Drawing.Point(9, 88);
            this.sliderSkillMagicA0.Name = "sliderSkillMagicA0";
            this.sliderSkillMagicA0.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicA0.TabIndex = 6;
            this.sliderSkillMagicA0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicA0.Value = 10;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::SoG_SGreader.Properties.Resources.icon_chainlightning;
            this.pictureBox23.Location = new System.Drawing.Point(19, 36);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(46, 46);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 7;
            this.pictureBox23.TabStop = false;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.sliderSkillMagicE2);
            this.groupBox14.Controls.Add(this.pictureBox18);
            this.groupBox14.Controls.Add(this.sliderSkillMagicE1);
            this.groupBox14.Controls.Add(this.pictureBox19);
            this.groupBox14.Controls.Add(this.sliderSkillMagicE0);
            this.groupBox14.Controls.Add(this.pictureBox20);
            this.groupBox14.Location = new System.Drawing.Point(6, 170);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(209, 158);
            this.groupBox14.TabIndex = 22;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Earth Magic";
            // 
            // sliderSkillMagicE2
            // 
            this.sliderSkillMagicE2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicE2.Location = new System.Drawing.Point(136, 88);
            this.sliderSkillMagicE2.Name = "sliderSkillMagicE2";
            this.sliderSkillMagicE2.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicE2.TabIndex = 10;
            this.sliderSkillMagicE2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicE2.Value = 10;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::SoG_SGreader.Properties.Resources.icon_swarm;
            this.pictureBox18.Location = new System.Drawing.Point(146, 36);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(46, 46);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 11;
            this.pictureBox18.TabStop = false;
            // 
            // sliderSkillMagicE1
            // 
            this.sliderSkillMagicE1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicE1.Location = new System.Drawing.Point(73, 88);
            this.sliderSkillMagicE1.Name = "sliderSkillMagicE1";
            this.sliderSkillMagicE1.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicE1.TabIndex = 8;
            this.sliderSkillMagicE1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicE1.Value = 10;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::SoG_SGreader.Properties.Resources.icon_plantsummon;
            this.pictureBox19.Location = new System.Drawing.Point(83, 36);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(46, 46);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 9;
            this.pictureBox19.TabStop = false;
            // 
            // sliderSkillMagicE0
            // 
            this.sliderSkillMagicE0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicE0.Location = new System.Drawing.Point(9, 88);
            this.sliderSkillMagicE0.Name = "sliderSkillMagicE0";
            this.sliderSkillMagicE0.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicE0.TabIndex = 6;
            this.sliderSkillMagicE0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicE0.Value = 10;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::SoG_SGreader.Properties.Resources.icon_earthspike;
            this.pictureBox20.Location = new System.Drawing.Point(19, 36);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(46, 46);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 7;
            this.pictureBox20.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.sliderSkillMagicI2);
            this.groupBox13.Controls.Add(this.pictureBox15);
            this.groupBox13.Controls.Add(this.sliderSkillMagicI1);
            this.groupBox13.Controls.Add(this.pictureBox16);
            this.groupBox13.Controls.Add(this.sliderSkillMagicI0);
            this.groupBox13.Controls.Add(this.pictureBox17);
            this.groupBox13.Location = new System.Drawing.Point(221, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(209, 158);
            this.groupBox13.TabIndex = 22;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Ice Magic";
            // 
            // sliderSkillMagicI2
            // 
            this.sliderSkillMagicI2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicI2.Location = new System.Drawing.Point(136, 88);
            this.sliderSkillMagicI2.Name = "sliderSkillMagicI2";
            this.sliderSkillMagicI2.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicI2.TabIndex = 10;
            this.sliderSkillMagicI2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicI2.Value = 10;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::SoG_SGreader.Properties.Resources.icon_frosty;
            this.pictureBox15.Location = new System.Drawing.Point(146, 36);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(46, 46);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 11;
            this.pictureBox15.TabStop = false;
            // 
            // sliderSkillMagicI1
            // 
            this.sliderSkillMagicI1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicI1.Location = new System.Drawing.Point(73, 88);
            this.sliderSkillMagicI1.Name = "sliderSkillMagicI1";
            this.sliderSkillMagicI1.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicI1.TabIndex = 8;
            this.sliderSkillMagicI1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicI1.Value = 10;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::SoG_SGreader.Properties.Resources.icon_frostnova_clover;
            this.pictureBox16.Location = new System.Drawing.Point(83, 36);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(46, 46);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 9;
            this.pictureBox16.TabStop = false;
            // 
            // sliderSkillMagicI0
            // 
            this.sliderSkillMagicI0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicI0.Location = new System.Drawing.Point(9, 88);
            this.sliderSkillMagicI0.Name = "sliderSkillMagicI0";
            this.sliderSkillMagicI0.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicI0.TabIndex = 6;
            this.sliderSkillMagicI0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicI0.Value = 10;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::SoG_SGreader.Properties.Resources.icon_icespikes;
            this.pictureBox17.Location = new System.Drawing.Point(19, 36);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(46, 46);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 7;
            this.pictureBox17.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.sliderSkillMagicF2);
            this.groupBox12.Controls.Add(this.pictureBox14);
            this.groupBox12.Controls.Add(this.sliderSkillMagicF1);
            this.groupBox12.Controls.Add(this.pictureBox13);
            this.groupBox12.Controls.Add(this.sliderSkillMagicF0);
            this.groupBox12.Controls.Add(this.pictureBox12);
            this.groupBox12.Location = new System.Drawing.Point(6, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(209, 158);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Fire Magic";
            // 
            // sliderSkillMagicF2
            // 
            this.sliderSkillMagicF2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicF2.Location = new System.Drawing.Point(136, 88);
            this.sliderSkillMagicF2.Name = "sliderSkillMagicF2";
            this.sliderSkillMagicF2.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicF2.TabIndex = 10;
            this.sliderSkillMagicF2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicF2.Value = 10;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::SoG_SGreader.Properties.Resources.icon_flamethrower;
            this.pictureBox14.Location = new System.Drawing.Point(146, 36);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(46, 46);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 11;
            this.pictureBox14.TabStop = false;
            // 
            // sliderSkillMagicF1
            // 
            this.sliderSkillMagicF1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicF1.Location = new System.Drawing.Point(73, 88);
            this.sliderSkillMagicF1.Name = "sliderSkillMagicF1";
            this.sliderSkillMagicF1.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicF1.TabIndex = 8;
            this.sliderSkillMagicF1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicF1.Value = 10;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::SoG_SGreader.Properties.Resources.icon_meteor;
            this.pictureBox13.Location = new System.Drawing.Point(83, 36);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(46, 46);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 9;
            this.pictureBox13.TabStop = false;
            // 
            // sliderSkillMagicF0
            // 
            this.sliderSkillMagicF0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderSkillMagicF0.Location = new System.Drawing.Point(9, 88);
            this.sliderSkillMagicF0.Name = "sliderSkillMagicF0";
            this.sliderSkillMagicF0.Size = new System.Drawing.Size(67, 45);
            this.sliderSkillMagicF0.TabIndex = 6;
            this.sliderSkillMagicF0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderSkillMagicF0.Value = 10;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::SoG_SGreader.Properties.Resources.icon_fireball;
            this.pictureBox12.Location = new System.Drawing.Point(19, 36);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(46, 46);
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
            this.tabSkillsUtility.Name = "tabSkillsUtility";
            this.tabSkillsUtility.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkillsUtility.Size = new System.Drawing.Size(437, 357);
            this.tabSkillsUtility.TabIndex = 2;
            this.tabSkillsUtility.Text = "Skills: Utility";
            this.tabSkillsUtility.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.sliderUtilityE0);
            this.groupBox18.Controls.Add(this.pictureBox30);
            this.groupBox18.Controls.Add(this.sliderUtilityE1);
            this.groupBox18.Controls.Add(this.pictureBox31);
            this.groupBox18.Controls.Add(this.sliderUtilityE2);
            this.groupBox18.Controls.Add(this.pictureBox32);
            this.groupBox18.Location = new System.Drawing.Point(6, 253);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(425, 121);
            this.groupBox18.TabIndex = 22;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Enhancing";
            // 
            // sliderUtilityE0
            // 
            this.sliderUtilityE0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityE0.Location = new System.Drawing.Point(90, 68);
            this.sliderUtilityE0.Maximum = 3;
            this.sliderUtilityE0.Name = "sliderUtilityE0";
            this.sliderUtilityE0.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityE0.TabIndex = 0;
            this.sliderUtilityE0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityE0.Value = 3;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = global::SoG_SGreader.Properties.Resources.icon_dmgup;
            this.pictureBox30.Location = new System.Drawing.Point(107, 19);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(46, 46);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 1;
            this.pictureBox30.TabStop = false;
            // 
            // sliderUtilityE1
            // 
            this.sliderUtilityE1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityE1.Location = new System.Drawing.Point(175, 68);
            this.sliderUtilityE1.Maximum = 3;
            this.sliderUtilityE1.Name = "sliderUtilityE1";
            this.sliderUtilityE1.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityE1.TabIndex = 2;
            this.sliderUtilityE1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityE1.Value = 3;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = global::SoG_SGreader.Properties.Resources.icon_speedup;
            this.pictureBox31.Location = new System.Drawing.Point(192, 19);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(46, 46);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox31.TabIndex = 3;
            this.pictureBox31.TabStop = false;
            // 
            // sliderUtilityE2
            // 
            this.sliderUtilityE2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityE2.Location = new System.Drawing.Point(254, 68);
            this.sliderUtilityE2.Maximum = 3;
            this.sliderUtilityE2.Name = "sliderUtilityE2";
            this.sliderUtilityE2.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityE2.TabIndex = 4;
            this.sliderUtilityE2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityE2.Value = 3;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = global::SoG_SGreader.Properties.Resources.icon_protect_clover;
            this.pictureBox32.Location = new System.Drawing.Point(271, 19);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(46, 46);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 5;
            this.pictureBox32.TabStop = false;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.sliderUtilityD0);
            this.groupBox17.Controls.Add(this.pictureBox27);
            this.groupBox17.Controls.Add(this.sliderUtilityD1);
            this.groupBox17.Controls.Add(this.pictureBox28);
            this.groupBox17.Controls.Add(this.sliderUtilityD2);
            this.groupBox17.Controls.Add(this.pictureBox29);
            this.groupBox17.Location = new System.Drawing.Point(6, 127);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(425, 121);
            this.groupBox17.TabIndex = 22;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Defensive";
            // 
            // sliderUtilityD0
            // 
            this.sliderUtilityD0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityD0.Location = new System.Drawing.Point(90, 68);
            this.sliderUtilityD0.Maximum = 3;
            this.sliderUtilityD0.Name = "sliderUtilityD0";
            this.sliderUtilityD0.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityD0.TabIndex = 0;
            this.sliderUtilityD0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityD0.Value = 3;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::SoG_SGreader.Properties.Resources.icon_utility_blink;
            this.pictureBox27.Location = new System.Drawing.Point(107, 19);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(46, 46);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 1;
            this.pictureBox27.TabStop = false;
            // 
            // sliderUtilityD1
            // 
            this.sliderUtilityD1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityD1.Location = new System.Drawing.Point(175, 68);
            this.sliderUtilityD1.Maximum = 3;
            this.sliderUtilityD1.Name = "sliderUtilityD1";
            this.sliderUtilityD1.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityD1.TabIndex = 2;
            this.sliderUtilityD1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityD1.Value = 3;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = global::SoG_SGreader.Properties.Resources.icon_utility_focus;
            this.pictureBox28.Location = new System.Drawing.Point(192, 19);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(46, 46);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 3;
            this.pictureBox28.TabStop = false;
            // 
            // sliderUtilityD2
            // 
            this.sliderUtilityD2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityD2.Location = new System.Drawing.Point(254, 68);
            this.sliderUtilityD2.Maximum = 3;
            this.sliderUtilityD2.Name = "sliderUtilityD2";
            this.sliderUtilityD2.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityD2.TabIndex = 4;
            this.sliderUtilityD2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityD2.Value = 3;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = global::SoG_SGreader.Properties.Resources.icon_utility_barrier;
            this.pictureBox29.Location = new System.Drawing.Point(271, 19);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(46, 46);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox29.TabIndex = 5;
            this.pictureBox29.TabStop = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.sliderUtilityO0);
            this.groupBox16.Controls.Add(this.pictureBox24);
            this.groupBox16.Controls.Add(this.sliderUtilityO1);
            this.groupBox16.Controls.Add(this.pictureBox25);
            this.groupBox16.Controls.Add(this.sliderUtilityO2);
            this.groupBox16.Controls.Add(this.pictureBox26);
            this.groupBox16.Location = new System.Drawing.Point(6, 6);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(425, 121);
            this.groupBox16.TabIndex = 21;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Offensive";
            // 
            // sliderUtilityO0
            // 
            this.sliderUtilityO0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityO0.Location = new System.Drawing.Point(90, 68);
            this.sliderUtilityO0.Maximum = 3;
            this.sliderUtilityO0.Name = "sliderUtilityO0";
            this.sliderUtilityO0.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityO0.TabIndex = 0;
            this.sliderUtilityO0.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::SoG_SGreader.Properties.Resources.icon_utility_deathmark;
            this.pictureBox24.Location = new System.Drawing.Point(107, 19);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(46, 46);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 1;
            this.pictureBox24.TabStop = false;
            // 
            // sliderUtilityO1
            // 
            this.sliderUtilityO1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityO1.Location = new System.Drawing.Point(175, 68);
            this.sliderUtilityO1.Maximum = 3;
            this.sliderUtilityO1.Name = "sliderUtilityO1";
            this.sliderUtilityO1.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityO1.TabIndex = 2;
            this.sliderUtilityO1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityO1.Value = 3;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = global::SoG_SGreader.Properties.Resources.icon_utility_sleep;
            this.pictureBox25.Location = new System.Drawing.Point(192, 19);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(46, 46);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 3;
            this.pictureBox25.TabStop = false;
            // 
            // sliderUtilityO2
            // 
            this.sliderUtilityO2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliderUtilityO2.Location = new System.Drawing.Point(254, 68);
            this.sliderUtilityO2.Maximum = 3;
            this.sliderUtilityO2.Name = "sliderUtilityO2";
            this.sliderUtilityO2.Size = new System.Drawing.Size(79, 45);
            this.sliderUtilityO2.TabIndex = 4;
            this.sliderUtilityO2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderUtilityO2.Value = 3;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::SoG_SGreader.Properties.Resources.icon_utility_taunt;
            this.pictureBox26.Location = new System.Drawing.Point(271, 19);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(46, 46);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 5;
            this.pictureBox26.TabStop = false;
            // 
            // tabTalentsGeneral
            // 
            this.tabTalentsGeneral.Location = new System.Drawing.Point(104, 4);
            this.tabTalentsGeneral.Name = "tabTalentsGeneral";
            this.tabTalentsGeneral.Size = new System.Drawing.Size(437, 357);
            this.tabTalentsGeneral.TabIndex = 3;
            this.tabTalentsGeneral.Text = "Talents: General";
            this.tabTalentsGeneral.UseVisualStyleBackColor = true;
            // 
            // tabTalentsMelee
            // 
            this.tabTalentsMelee.Location = new System.Drawing.Point(104, 4);
            this.tabTalentsMelee.Name = "tabTalentsMelee";
            this.tabTalentsMelee.Size = new System.Drawing.Size(437, 357);
            this.tabTalentsMelee.TabIndex = 4;
            this.tabTalentsMelee.Text = "Talents: Melee";
            this.tabTalentsMelee.UseVisualStyleBackColor = true;
            // 
            // tabTalentsMagic
            // 
            this.tabTalentsMagic.Location = new System.Drawing.Point(104, 4);
            this.tabTalentsMagic.Name = "tabTalentsMagic";
            this.tabTalentsMagic.Size = new System.Drawing.Size(437, 357);
            this.tabTalentsMagic.TabIndex = 5;
            this.tabTalentsMagic.Text = "Talents: Magic";
            this.tabTalentsMagic.UseVisualStyleBackColor = true;
            // 
            // tabTreasureMaps
            // 
            this.tabTreasureMaps.Controls.Add(this.label41);
            this.tabTreasureMaps.Location = new System.Drawing.Point(4, 22);
            this.tabTreasureMaps.Name = "tabTreasureMaps";
            this.tabTreasureMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreasureMaps.Size = new System.Drawing.Size(559, 396);
            this.tabTreasureMaps.TabIndex = 6;
            this.tabTreasureMaps.Text = "*Treasure Maps";
            this.tabTreasureMaps.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label41.Location = new System.Drawing.Point(6, 3);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(117, 13);
            this.label41.TabIndex = 31;
            this.label41.Text = "* = not yet implemented";
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(567, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem});
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exportAsToolStripMenuItem.Text = "Export as...";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.JSONToolStripMenuItem_Click);
            // 
            // openSavegameFolderToolStripMenuItem
            // 
            this.openSavegameFolderToolStripMenuItem.Name = "openSavegameFolderToolStripMenuItem";
            this.openSavegameFolderToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openSavegameFolderToolStripMenuItem.Text = "Open Savegame Location...";
            this.openSavegameFolderToolStripMenuItem.Click += new System.EventHandler(this.openSavegameFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsole.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtConsole.Location = new System.Drawing.Point(0, 441);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(567, 129);
            this.txtConsole.TabIndex = 28;
            this.txtConsole.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SoG_SGreader.Properties.Resources.ada21;
            this.pictureBox3.Location = new System.Drawing.Point(547, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(567, 570);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.grpEnemiesSeen);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmMain";
            this.Text = "SoG: Savegame Editor v16.9.30803.129 by tolik518";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpEnemiesSeen.ResumeLayout(false);
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
            this.tabCards.ResumeLayout(false);
            this.grpCards.ResumeLayout(false);
            this.tabQuests.ResumeLayout(false);
            this.grpQuests.ResumeLayout(false);
            this.tabEnemiesSeen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabQuickslots.ResumeLayout(false);
            this.tabQuickslots.PerformLayout();
            this.grpQuickslots.ResumeLayout(false);
            this.grpQuickslots.PerformLayout();
            this.tabSkills.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSkillsMelee.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee2h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMelee1h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabSkillsMagic.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicA0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicE0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicI0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSkillMagicF0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.tabSkillsUtility.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityE0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityD0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityO0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUtilityO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            this.tabTreasureMaps.ResumeLayout(false);
            this.tabTreasureMaps.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl grpEnemiesSeen;
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
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numItemCount;
        private System.Windows.Forms.ComboBox cbSelectedItem;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TabPage tabChar;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPantsColor;
        private System.Windows.Forms.Button btnShirtColor;
        private System.Windows.Forms.Button btnPonchoColor;
        private System.Windows.Forms.Button btnSkinColor;
        private System.Windows.Forms.Button btnHairColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabEnemiesSeen;
        private System.Windows.Forms.TabPage tabCards;
        private System.Windows.Forms.TabPage tabTreasureMaps;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown numEXPUnknown1;
        private System.Windows.Forms.NumericUpDown numEXPUnknown0;
        private System.Windows.Forms.NumericUpDown numEXPcurrent;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.GroupBox grpSkillpoints;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown numSkillTalentPoints;
        private System.Windows.Forms.NumericUpDown numSkillSilverPoints;
        private System.Windows.Forms.NumericUpDown numSkillGoldPoints;
        private System.Windows.Forms.ToolTip Tooltips;
        private System.Windows.Forms.GroupBox grpEquipped;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbAccessory2;
        private System.Windows.Forms.ComboBox cbAccessory1;
        private System.Windows.Forms.ComboBox cbShoes;
        private System.Windows.Forms.ComboBox cbArmor;
        private System.Windows.Forms.ComboBox cbShield;
        private System.Windows.Forms.ComboBox cbWeapon;
        private System.Windows.Forms.ComboBox cbFacegear;
        private System.Windows.Forms.ComboBox cbHat;
        private System.Windows.Forms.GroupBox grpEquippedStyle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbStyleShield;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbStyleHat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbStyleFacegear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbStyleWeapon;
        private System.Windows.Forms.Label label41;
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
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown numPetSpeed;
        private System.Windows.Forms.NumericUpDown numPetCrit;
        private System.Windows.Forms.NumericUpDown numPetDamage;
        private System.Windows.Forms.TextBox txtPetNickname;
        private System.Windows.Forms.NumericUpDown numPetEnergy;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown numPetHP;
        private System.Windows.Forms.NumericUpDown numPetLevel;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btnDeleteSelectedItem;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TabPage tabQuests;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cbPetType;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtTimePlayed;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown numBirtdayMonth;
        private System.Windows.Forms.NumericUpDown numBirthdayDay;
        private System.Windows.Forms.GroupBox grpPatch;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown numGold;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSkillsMelee;
        private System.Windows.Forms.TabPage tabSkillsMagic;
        private System.Windows.Forms.TabPage tabSkillsUtility;
        private System.Windows.Forms.TabPage tabTalentsGeneral;
        private System.Windows.Forms.TabPage tabTalentsMelee;
        private System.Windows.Forms.TabPage tabTalentsMagic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar sliderSkillMelee1h0;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TrackBar sliderSkillMelee2h4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TrackBar sliderSkillMelee2h3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TrackBar sliderSkillMelee2h2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TrackBar sliderSkillMelee2h1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TrackBar sliderSkillMelee2h0;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TrackBar sliderSkillMelee1h4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TrackBar sliderSkillMelee1h3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar sliderSkillMelee1h2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar sliderSkillMelee1h1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TrackBar sliderSkillMagicA2;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.TrackBar sliderSkillMagicA1;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.TrackBar sliderSkillMagicA0;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TrackBar sliderSkillMagicE2;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.TrackBar sliderSkillMagicE1;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.TrackBar sliderSkillMagicE0;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TrackBar sliderSkillMagicI2;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.TrackBar sliderSkillMagicI1;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.TrackBar sliderSkillMagicI0;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TrackBar sliderSkillMagicF2;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.TrackBar sliderSkillMagicF1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.TrackBar sliderSkillMagicF0;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TrackBar sliderUtilityE0;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.TrackBar sliderUtilityE1;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.TrackBar sliderUtilityE2;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TrackBar sliderUtilityD0;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.TrackBar sliderUtilityD1;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.TrackBar sliderUtilityD2;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TrackBar sliderUtilityO0;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.TrackBar sliderUtilityO1;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.TrackBar sliderUtilityO2;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label56;
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
        private GroupBox groupBox1;
        private Button btnSelectAllEnemiesSeen;
        private Button btnResetEnemiesSeen;
        private Button btnDeselectAllEnemiesSeen;
        private CheckedListBox cblstEnemiesSeens;
    }
}
