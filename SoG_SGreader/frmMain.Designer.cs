
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabEquip = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.gbColors = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbStyleShield = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbStyleHat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbStyleFacegear = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbStyleWeapon = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.numItemCount = new System.Windows.Forms.NumericUpDown();
            this.cbSelectedItem = new System.Windows.Forms.ComboBox();
            this.lstInventory = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabContainer.SuspendLayout();
            this.tabEquip.SuspendLayout();
            this.gbColors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Controls.Add(this.tabEquip);
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Location = new System.Drawing.Point(12, 27);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(720, 413);
            this.tabContainer.TabIndex = 0;
            // 
            // tabEquip
            // 
            this.tabEquip.Controls.Add(this.label29);
            this.tabEquip.Controls.Add(this.txtNickname);
            this.tabEquip.Controls.Add(this.gbColors);
            this.tabEquip.Controls.Add(this.groupBox1);
            this.tabEquip.Controls.Add(this.groupBox2);
            this.tabEquip.Controls.Add(this.groupBox3);
            this.tabEquip.Location = new System.Drawing.Point(4, 22);
            this.tabEquip.Name = "tabEquip";
            this.tabEquip.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquip.Size = new System.Drawing.Size(712, 387);
            this.tabEquip.TabIndex = 1;
            this.tabEquip.Text = "Equip";
            this.tabEquip.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Nickname:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(9, 32);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(101, 20);
            this.txtNickname.TabIndex = 31;
            // 
            // gbColors
            // 
            this.gbColors.Controls.Add(this.label5);
            this.gbColors.Controls.Add(this.label4);
            this.gbColors.Controls.Add(this.label3);
            this.gbColors.Controls.Add(this.label2);
            this.gbColors.Controls.Add(this.btnPantsColor);
            this.gbColors.Controls.Add(this.btnShirtColor);
            this.gbColors.Controls.Add(this.btnPonchoColor);
            this.gbColors.Controls.Add(this.btnSkinColor);
            this.gbColors.Controls.Add(this.btnHairColor);
            this.gbColors.Controls.Add(this.label1);
            this.gbColors.Location = new System.Drawing.Point(9, 59);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(101, 149);
            this.gbColors.TabIndex = 30;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "Colors";
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
            this.btnPantsColor.Location = new System.Drawing.Point(61, 118);
            this.btnPantsColor.Name = "btnPantsColor";
            this.btnPantsColor.Size = new System.Drawing.Size(20, 20);
            this.btnPantsColor.TabIndex = 9;
            this.btnPantsColor.UseVisualStyleBackColor = false;
            // 
            // btnShirtColor
            // 
            this.btnShirtColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShirtColor.Location = new System.Drawing.Point(61, 92);
            this.btnShirtColor.Name = "btnShirtColor";
            this.btnShirtColor.Size = new System.Drawing.Size(20, 20);
            this.btnShirtColor.TabIndex = 8;
            this.btnShirtColor.UseVisualStyleBackColor = false;
            // 
            // btnPonchoColor
            // 
            this.btnPonchoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonchoColor.Location = new System.Drawing.Point(61, 66);
            this.btnPonchoColor.Name = "btnPonchoColor";
            this.btnPonchoColor.Size = new System.Drawing.Size(20, 20);
            this.btnPonchoColor.TabIndex = 7;
            this.btnPonchoColor.UseVisualStyleBackColor = false;
            // 
            // btnSkinColor
            // 
            this.btnSkinColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkinColor.Location = new System.Drawing.Point(61, 40);
            this.btnSkinColor.Name = "btnSkinColor";
            this.btnSkinColor.Size = new System.Drawing.Size(20, 20);
            this.btnSkinColor.TabIndex = 6;
            this.btnSkinColor.UseVisualStyleBackColor = false;
            // 
            // btnHairColor
            // 
            this.btnHairColor.BackColor = System.Drawing.Color.White;
            this.btnHairColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHairColor.Location = new System.Drawing.Point(61, 14);
            this.btnHairColor.Name = "btnHairColor";
            this.btnHairColor.Size = new System.Drawing.Size(20, 20);
            this.btnHairColor.TabIndex = 5;
            this.btnHairColor.UseVisualStyleBackColor = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbAccessory2);
            this.groupBox1.Controls.Add(this.cbAccessory1);
            this.groupBox1.Controls.Add(this.cbShoes);
            this.groupBox1.Controls.Add(this.cbArmor);
            this.groupBox1.Controls.Add(this.cbShield);
            this.groupBox1.Controls.Add(this.cbWeapon);
            this.groupBox1.Controls.Add(this.cbFacegear);
            this.groupBox1.Controls.Add(this.cbHat);
            this.groupBox1.Location = new System.Drawing.Point(116, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 239);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipped Gear";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Accessory 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Accessory 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Shoes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Armor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Shield:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Weapon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Facegear:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 22);
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
            this.cbAccessory2.Size = new System.Drawing.Size(152, 21);
            this.cbAccessory2.TabIndex = 14;
            // 
            // cbAccessory1
            // 
            this.cbAccessory1.FormattingEnabled = true;
            this.cbAccessory1.Location = new System.Drawing.Point(79, 181);
            this.cbAccessory1.Name = "cbAccessory1";
            this.cbAccessory1.Size = new System.Drawing.Size(152, 21);
            this.cbAccessory1.TabIndex = 13;
            // 
            // cbShoes
            // 
            this.cbShoes.FormattingEnabled = true;
            this.cbShoes.Location = new System.Drawing.Point(79, 154);
            this.cbShoes.Name = "cbShoes";
            this.cbShoes.Size = new System.Drawing.Size(152, 21);
            this.cbShoes.TabIndex = 12;
            // 
            // cbArmor
            // 
            this.cbArmor.FormattingEnabled = true;
            this.cbArmor.Location = new System.Drawing.Point(79, 127);
            this.cbArmor.Name = "cbArmor";
            this.cbArmor.Size = new System.Drawing.Size(152, 21);
            this.cbArmor.TabIndex = 11;
            // 
            // cbShield
            // 
            this.cbShield.FormattingEnabled = true;
            this.cbShield.Location = new System.Drawing.Point(79, 100);
            this.cbShield.Name = "cbShield";
            this.cbShield.Size = new System.Drawing.Size(152, 21);
            this.cbShield.TabIndex = 10;
            // 
            // cbWeapon
            // 
            this.cbWeapon.FormattingEnabled = true;
            this.cbWeapon.Location = new System.Drawing.Point(79, 73);
            this.cbWeapon.Name = "cbWeapon";
            this.cbWeapon.Size = new System.Drawing.Size(152, 21);
            this.cbWeapon.TabIndex = 9;
            // 
            // cbFacegear
            // 
            this.cbFacegear.FormattingEnabled = true;
            this.cbFacegear.Location = new System.Drawing.Point(79, 46);
            this.cbFacegear.Name = "cbFacegear";
            this.cbFacegear.Size = new System.Drawing.Size(152, 21);
            this.cbFacegear.TabIndex = 8;
            // 
            // cbHat
            // 
            this.cbHat.FormattingEnabled = true;
            this.cbHat.Location = new System.Drawing.Point(79, 19);
            this.cbHat.Name = "cbHat";
            this.cbHat.Size = new System.Drawing.Size(152, 21);
            this.cbHat.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbStyleShield);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbStyleHat);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbStyleFacegear);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cbStyleWeapon);
            this.groupBox2.Location = new System.Drawing.Point(116, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 129);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipped Style";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 103);
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
            this.cbStyleShield.Size = new System.Drawing.Size(152, 21);
            this.cbStyleShield.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 76);
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
            this.cbStyleHat.Size = new System.Drawing.Size(152, 21);
            this.cbStyleHat.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 49);
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
            this.cbStyleFacegear.Size = new System.Drawing.Size(152, 21);
            this.cbStyleFacegear.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 22);
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
            this.cbStyleWeapon.Size = new System.Drawing.Size(152, 21);
            this.cbStyleWeapon.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(363, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 294);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quckslots";
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.lstInventory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 387);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddItem);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.numItemCount);
            this.groupBox4.Controls.Add(this.cbSelectedItem);
            this.groupBox4.Location = new System.Drawing.Point(6, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 79);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(263, 17);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(39, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 48);
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
            this.numItemCount.Size = new System.Drawing.Size(81, 20);
            this.numItemCount.TabIndex = 1;
            this.numItemCount.ValueChanged += new System.EventHandler(this.NumItemCount_ValueChanged);
            // 
            // cbSelectedItem
            // 
            this.cbSelectedItem.FormattingEnabled = true;
            this.cbSelectedItem.Location = new System.Drawing.Point(6, 19);
            this.cbSelectedItem.Name = "cbSelectedItem";
            this.cbSelectedItem.Size = new System.Drawing.Size(251, 21);
            this.cbSelectedItem.TabIndex = 0;
            // 
            // lstInventory
            // 
            this.lstInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Count,
            this.Position});
            this.lstInventory.HideSelection = false;
            this.lstInventory.LabelWrap = false;
            this.lstInventory.Location = new System.Drawing.Point(12, 11);
            this.lstInventory.MultiSelect = false;
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(480, 285);
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
            // msMenu
            // 
            this.msMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(744, 24);
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
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.exportAsToolStripMenuItem.Enabled = false;
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exportAsToolStripMenuItem.Text = "Export as...";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
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
            this.txtConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsole.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtConsole.Location = new System.Drawing.Point(0, 451);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(744, 74);
            this.txtConsole.TabIndex = 28;
            this.txtConsole.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 441);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(744, 10);
            this.splitter1.TabIndex = 29;
            this.splitter1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 525);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmMain";
            this.Text = "SoG: Savegame Reader v0.2 by TOLIK518";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabContainer.ResumeLayout(false);
            this.tabEquip.ResumeLayout(false);
            this.tabEquip.PerformLayout();
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabEquip;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbStyleShield;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbStyleHat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbStyleFacegear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbStyleWeapon;
        private System.Windows.Forms.GroupBox groupBox3;

       

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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstInventory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numItemCount;
        private System.Windows.Forms.ComboBox cbSelectedItem;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.GroupBox gbColors;
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
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Button btnAddItem;
    }
}

