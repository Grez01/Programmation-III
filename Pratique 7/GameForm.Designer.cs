namespace Pratique_5
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.c7 = new System.Windows.Forms.Button();
            this.c8 = new System.Windows.Forms.Button();
            this.c9 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c5 = new System.Windows.Forms.Button();
            this.c6 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c7
            // 
            this.c7.Location = new System.Drawing.Point(12, 12);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(122, 127);
            this.c7.TabIndex = 0;
            this.c7.UseVisualStyleBackColor = true;
            this.c7.Click += new System.EventHandler(this.c7_Click);
            // 
            // c8
            // 
            this.c8.Location = new System.Drawing.Point(140, 12);
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(122, 127);
            this.c8.TabIndex = 1;
            this.c8.UseVisualStyleBackColor = true;
            this.c8.Click += new System.EventHandler(this.c8_Click);
            // 
            // c9
            // 
            this.c9.Location = new System.Drawing.Point(268, 12);
            this.c9.Name = "c9";
            this.c9.Size = new System.Drawing.Size(122, 127);
            this.c9.TabIndex = 2;
            this.c9.UseVisualStyleBackColor = true;
            this.c9.Click += new System.EventHandler(this.c9_Click);
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(12, 145);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(122, 127);
            this.c4.TabIndex = 3;
            this.c4.UseVisualStyleBackColor = true;
            this.c4.Click += new System.EventHandler(this.c4_Click);
            // 
            // c5
            // 
            this.c5.Location = new System.Drawing.Point(140, 145);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(122, 127);
            this.c5.TabIndex = 4;
            this.c5.UseVisualStyleBackColor = true;
            this.c5.Click += new System.EventHandler(this.c5_Click);
            // 
            // c6
            // 
            this.c6.Location = new System.Drawing.Point(268, 145);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(122, 127);
            this.c6.TabIndex = 5;
            this.c6.UseVisualStyleBackColor = true;
            this.c6.Click += new System.EventHandler(this.c6_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(12, 278);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(122, 127);
            this.c1.TabIndex = 6;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(140, 278);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(122, 127);
            this.c2.TabIndex = 7;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(268, 278);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(122, 127);
            this.c3.TabIndex = 8;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.c3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 404);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "C\'est le tour du joueur X";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c9);
            this.Controls.Add(this.c8);
            this.Controls.Add(this.c7);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c7;
        private System.Windows.Forms.Button c8;
        private System.Windows.Forms.Button c9;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c5;
        private System.Windows.Forms.Button c6;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}