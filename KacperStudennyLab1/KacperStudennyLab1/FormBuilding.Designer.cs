namespace KacperStudennyLab1
{
    partial class FormBuilding
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
            this.SuspendLayout();
            // 
            // FormBuilding
            // 
            this.ClientSize = new System.Drawing.Size(400, 210);
            this.Name = "FormBuilding";
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponentDefault()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescriptionIncome = new System.Windows.Forms.Label();
            this.labelValueIncome = new System.Windows.Forms.Label();
            this.labelDescriptionLvl = new System.Windows.Forms.Label();
            this.labelBuildingLvl = new System.Windows.Forms.Label();
            this.timerFPS = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(80, 89);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(132, 21);
            this.buttonIncrement.TabIndex = 3;
            this.buttonIncrement.Text = "Rozbuduj Budynek";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.ButtonIncrement_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(112, 116);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(94, 38);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Przydziel Ilość robotników do pracy";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelDescriptionIncome
            // 
            this.labelDescriptionIncome.AutoSize = true;
            this.labelDescriptionIncome.Location = new System.Drawing.Point(242, 9);
            this.labelDescriptionIncome.Name = "labelDescriptionIncome";
            this.labelDescriptionIncome.Size = new System.Drawing.Size(128, 13);
            this.labelDescriptionIncome.TabIndex = 6;
            this.labelDescriptionIncome.Text = "Obcny Dzienny przychód:";
            // 
            // labelValueIncome
            // 
            this.labelValueIncome.AutoSize = true;
            this.labelValueIncome.Location = new System.Drawing.Point(242, 38);
            this.labelValueIncome.Name = "labelValueIncome";
            this.labelValueIncome.Size = new System.Drawing.Size(76, 13);
            this.labelValueIncome.TabIndex = 7;
            this.labelValueIncome.Text = "Setki zasobów";
            this.labelValueIncome.Click += new System.EventHandler(this.LabelValueIncome_Click);
            // 
            // labelDescriptionLvl
            // 
            this.labelDescriptionLvl.AutoSize = true;
            this.labelDescriptionLvl.Location = new System.Drawing.Point(242, 70);
            this.labelDescriptionLvl.Name = "labelDescriptionLvl";
            this.labelDescriptionLvl.Size = new System.Drawing.Size(129, 13);
            this.labelDescriptionLvl.TabIndex = 7;
            this.labelDescriptionLvl.Text = "Obecny Poziom Budynku:";
            // 
            // labelBuildingLvl
            // 
            this.labelBuildingLvl.AutoSize = true;
            this.labelBuildingLvl.Location = new System.Drawing.Point(242, 97);
            this.labelBuildingLvl.Name = "labelBuildingLvl";
            this.labelBuildingLvl.Size = new System.Drawing.Size(41, 13);
            this.labelBuildingLvl.TabIndex = 7;
            this.labelBuildingLvl.Text = "Poziom";
            // 
            // timerFPS
            // 
            this.timerFPS.Tick += new System.EventHandler(this.TimerFPS_Tick_1);
            // 
            // FormBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 184);
            this.Controls.Add(this.labelDescriptionLvl);
            this.Controls.Add(this.labelBuildingLvl);
            this.Controls.Add(this.labelValueIncome);
            this.Controls.Add(this.labelDescriptionIncome);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonIncrement);
            this.Controls.Add(this.label1);
            this.Name = "FormBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBuilding";
            this.Load += new System.EventHandler(this.FormBuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescriptionIncome;
        private System.Windows.Forms.Label labelValueIncome;
        private System.Windows.Forms.Label labelDescriptionLvl;
        private System.Windows.Forms.Label labelBuildingLvl;
        private System.Windows.Forms.Timer timerFPS;
    }
}