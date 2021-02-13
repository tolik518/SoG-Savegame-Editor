
namespace Sog_SGreader
{
    partial class FrmLoadSaveGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadSaveGame));
            this.btnLoadSaveGame = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnStartWithoitLoading = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblSaveGameCount = new System.Windows.Forms.Label();
            this.lstvSaveGames = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadSaveGame
            // 
            this.btnLoadSaveGame.Enabled = false;
            this.btnLoadSaveGame.Location = new System.Drawing.Point(210, 102);
            this.btnLoadSaveGame.Name = "btnLoadSaveGame";
            this.btnLoadSaveGame.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSaveGame.TabIndex = 0;
            this.btnLoadSaveGame.Text = "Load...";
            this.btnLoadSaveGame.UseVisualStyleBackColor = true;
            this.btnLoadSaveGame.Click += new System.EventHandler(this.BtnLoadSaveGame_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseFolder.Image")));
            this.btnChooseFolder.Location = new System.Drawing.Point(301, 102);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(25, 23);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
            // 
            // btnStartWithoitLoading
            // 
            this.btnStartWithoitLoading.Location = new System.Drawing.Point(210, 131);
            this.btnStartWithoitLoading.Name = "btnStartWithoitLoading";
            this.btnStartWithoitLoading.Size = new System.Drawing.Size(116, 23);
            this.btnStartWithoitLoading.TabIndex = 3;
            this.btnStartWithoitLoading.Text = "Start without Loading";
            this.btnStartWithoitLoading.UseVisualStyleBackColor = true;
            this.btnStartWithoitLoading.Click += new System.EventHandler(this.BtnStartWithoitLoading_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(10, 161);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(54, 12);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "[lblFilePath]";
            // 
            // lblSaveGameCount
            // 
            this.lblSaveGameCount.AutoSize = true;
            this.lblSaveGameCount.Location = new System.Drawing.Point(188, 86);
            this.lblSaveGameCount.Name = "lblSaveGameCount";
            this.lblSaveGameCount.Size = new System.Drawing.Size(113, 13);
            this.lblSaveGameCount.TabIndex = 5;
            this.lblSaveGameCount.Text = "No Savegames found!";
            this.lblSaveGameCount.Visible = false;
            // 
            // lstvSaveGames
            // 
            this.lstvSaveGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvSaveGames.FullRowSelect = true;
            this.lstvSaveGames.GridLines = true;
            this.lstvSaveGames.HideSelection = false;
            this.lstvSaveGames.Location = new System.Drawing.Point(3, 1);
            this.lstvSaveGames.MultiSelect = false;
            this.lstvSaveGames.Name = "lstvSaveGames";
            this.lstvSaveGames.Size = new System.Drawing.Size(201, 155);
            this.lstvSaveGames.SmallImageList = this.imageList1;
            this.lstvSaveGames.TabIndex = 6;
            this.lstvSaveGames.UseCompatibleStateImageBehavior = false;
            this.lstvSaveGames.View = System.Windows.Forms.View.List;
            this.lstvSaveGames.SelectedIndexChanged += new System.EventHandler(this.lstvSaveGames_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save_small.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // FrmLoadSaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(335, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvSaveGames);
            this.Controls.Add(this.lblSaveGameCount);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnStartWithoitLoading);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnLoadSaveGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoadSaveGame";
            this.Text = "SoG: Savegame Reader v0.3.7 by TOLIK518";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSaveGame;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Button btnStartWithoitLoading;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblSaveGameCount;
        private System.Windows.Forms.ListView lstvSaveGames;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}