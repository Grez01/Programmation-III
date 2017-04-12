namespace Pratique_5{
    partial class MenuForm{
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.btNewGame = new System.Windows.Forms.Button();
            this.optBot = new System.Windows.Forms.RadioButton();
            this.optMulti = new System.Windows.Forms.RadioButton();
            this.btHost = new System.Windows.Forms.Button();
            this.btJoin = new System.Windows.Forms.Button();
            this.txtJoin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(0, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 3;
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(60, 176);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(75, 23);
            this.btNewGame.TabIndex = 0;
            this.btNewGame.Text = "New Game";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // optBot
            // 
            this.optBot.AutoSize = true;
            this.optBot.Location = new System.Drawing.Point(69, 130);
            this.optBot.Name = "optBot";
            this.optBot.Size = new System.Drawing.Size(41, 17);
            this.optBot.TabIndex = 4;
            this.optBot.TabStop = true;
            this.optBot.Text = "Bot";
            this.optBot.UseVisualStyleBackColor = true;
            this.optBot.CheckedChanged += new System.EventHandler(this.optBot_CheckedChanged);
            // 
            // optMulti
            // 
            this.optMulti.AutoSize = true;
            this.optMulti.Location = new System.Drawing.Point(69, 153);
            this.optMulti.Name = "optMulti";
            this.optMulti.Size = new System.Drawing.Size(75, 17);
            this.optMulti.TabIndex = 5;
            this.optMulti.TabStop = true;
            this.optMulti.Text = "Multiplayer";
            this.optMulti.UseVisualStyleBackColor = true;
            this.optMulti.CheckedChanged += new System.EventHandler(this.optMulti_CheckedChanged);
            // 
            // btHost
            // 
            this.btHost.Location = new System.Drawing.Point(12, 215);
            this.btHost.Name = "btHost";
            this.btHost.Size = new System.Drawing.Size(75, 23);
            this.btHost.TabIndex = 6;
            this.btHost.Text = "Host";
            this.btHost.UseVisualStyleBackColor = true;
            this.btHost.Click += new System.EventHandler(this.btHost_Click);
            // 
            // btJoin
            // 
            this.btJoin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btJoin.Location = new System.Drawing.Point(106, 215);
            this.btJoin.Name = "btJoin";
            this.btJoin.Size = new System.Drawing.Size(75, 23);
            this.btJoin.TabIndex = 7;
            this.btJoin.Text = "Join";
            this.btJoin.UseVisualStyleBackColor = true;
            this.btJoin.Click += new System.EventHandler(this.btJoin_Click);
            // 
            // txtJoin
            // 
            this.txtJoin.Location = new System.Drawing.Point(44, 254);
            this.txtJoin.Name = "txtJoin";
            this.txtJoin.Size = new System.Drawing.Size(100, 20);
            this.txtJoin.TabIndex = 8;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 286);
            this.Controls.Add(this.txtJoin);
            this.Controls.Add(this.btJoin);
            this.Controls.Add(this.btHost);
            this.Controls.Add(this.optMulti);
            this.Controls.Add(this.optBot);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton optBot;
        private System.Windows.Forms.RadioButton optMulti;
        private System.Windows.Forms.Button btHost;
        private System.Windows.Forms.Button btJoin;
        private System.Windows.Forms.TextBox txtJoin;
    }
}