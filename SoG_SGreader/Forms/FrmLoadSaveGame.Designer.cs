
namespace SoG_SGreader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadSaveGame));
            this.btnLoadSaveGame = new System.Windows.Forms.Button();
            this.lstSaveGames = new System.Windows.Forms.ListBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnStartWithoitLoading = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblSaveGameCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadSaveGame
            // 
            this.btnLoadSaveGame.Enabled = false;
            this.btnLoadSaveGame.Location = new System.Drawing.Point(164, 195);
            this.btnLoadSaveGame.Name = "btnLoadSaveGame";
            this.btnLoadSaveGame.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSaveGame.TabIndex = 0;
            this.btnLoadSaveGame.Text = "Load...";
            this.btnLoadSaveGame.UseVisualStyleBackColor = true;
            this.btnLoadSaveGame.Click += new System.EventHandler(this.BtnLoadSaveGame_Click);
            // 
            // lstSaveGames
            // 
            this.lstSaveGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSaveGames.FormattingEnabled = true;
            this.lstSaveGames.Location = new System.Drawing.Point(12, 12);
            this.lstSaveGames.Name = "lstSaveGames";
            this.lstSaveGames.Size = new System.Drawing.Size(349, 160);
            this.lstSaveGames.TabIndex = 1;
            this.lstSaveGames.SelectedIndexChanged += new System.EventHandler(this.LstSaveGames_SelectedIndexChanged);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseFolder.Image")));
            this.btnChooseFolder.Location = new System.Drawing.Point(12, 194);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(25, 25);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
            // 
            // btnStartWithoitLoading
            // 
            this.btnStartWithoitLoading.Location = new System.Drawing.Point(245, 195);
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
            this.lblFilePath.Location = new System.Drawing.Point(12, 175);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(54, 12);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "[lblFilePath]";
            // 
            // lblSaveGameCount
            // 
            this.lblSaveGameCount.AutoSize = true;
            this.lblSaveGameCount.Location = new System.Drawing.Point(43, 200);
            this.lblSaveGameCount.Name = "lblSaveGameCount";
            this.lblSaveGameCount.Size = new System.Drawing.Size(113, 13);
            this.lblSaveGameCount.TabIndex = 5;
            this.lblSaveGameCount.Text = "No Savegames found!";
            // 
            // FrmLoadSaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 223);
            this.Controls.Add(this.lblSaveGameCount);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnStartWithoitLoading);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.lstSaveGames);
            this.Controls.Add(this.btnLoadSaveGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoadSaveGame";
            this.Text = "SoG: Savegame Reader v0.2 by TOLIK518";
            this.Load += new System.EventHandler(this.FrmLoadSaveGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSaveGame;
        private System.Windows.Forms.ListBox lstSaveGames;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Button btnStartWithoitLoading;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblSaveGameCount;
    }
}