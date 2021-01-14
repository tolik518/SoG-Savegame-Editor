
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
            this.SuspendLayout();
            // 
            // btnLoadSaveGame
            // 
            this.btnLoadSaveGame.Location = new System.Drawing.Point(134, 178);
            this.btnLoadSaveGame.Name = "btnLoadSaveGame";
            this.btnLoadSaveGame.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSaveGame.TabIndex = 0;
            this.btnLoadSaveGame.Text = "Load...";
            this.btnLoadSaveGame.UseVisualStyleBackColor = true;
            this.btnLoadSaveGame.Click += new System.EventHandler(this.BtnLoadSaveGame_Click);
            // 
            // lstSaveGames
            // 
            this.lstSaveGames.FormattingEnabled = true;
            this.lstSaveGames.Location = new System.Drawing.Point(12, 12);
            this.lstSaveGames.Name = "lstSaveGames";
            this.lstSaveGames.Size = new System.Drawing.Size(319, 160);
            this.lstSaveGames.TabIndex = 1;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseFolder.Image")));
            this.btnChooseFolder.Location = new System.Drawing.Point(12, 174);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(30, 30);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
            // 
            // FrmLoadSaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 209);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.lstSaveGames);
            this.Controls.Add(this.btnLoadSaveGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoadSaveGame";
            this.Text = "SoG: Savegame Reader v0.1 by TOLIK518";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSaveGame;
        private System.Windows.Forms.ListBox lstSaveGames;
        private System.Windows.Forms.Button btnChooseFolder;
    }
}