namespace KacperStudennyLab1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.PictureBoxWoodcutter = new System.Windows.Forms.PictureBox();
            this.labelTestWood = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.labelWood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWoodcutter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // PictureBoxWoodcutter
            // 
            this.PictureBoxWoodcutter.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxWoodcutter.Image")));
            this.PictureBoxWoodcutter.Location = new System.Drawing.Point(595, 41);
            this.PictureBoxWoodcutter.Name = "PictureBoxWoodcutter";
            this.PictureBoxWoodcutter.Size = new System.Drawing.Size(144, 110);
            this.PictureBoxWoodcutter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxWoodcutter.TabIndex = 1;
            this.PictureBoxWoodcutter.TabStop = false;
            this.PictureBoxWoodcutter.Click += new System.EventHandler(this.PictureBoxWoodcutter_Click);
            // 
            // labelTestWood
            // 
            this.labelTestWood.AutoSize = true;
            this.labelTestWood.Location = new System.Drawing.Point(592, 198);
            this.labelTestWood.Name = "labelTestWood";
            this.labelTestWood.Size = new System.Drawing.Size(35, 13);
            this.labelTestWood.TabIndex = 2;
            this.labelTestWood.Text = "label1";
            this.labelTestWood.Click += new System.EventHandler(this.LabelTestWood_Click);
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.Location = new System.Drawing.Point(59, 9);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(44, 13);
            this.labelWood.TabIndex = 3;
            this.labelWood.Text = "Drewno";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelTestWood);
            this.Controls.Add(this.PictureBoxWoodcutter);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "FormMain";
            this.Text = "Gra";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWoodcutter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox PictureBoxWoodcutter;
        private System.Windows.Forms.Label labelTestWood;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label labelWood;
    }
}

