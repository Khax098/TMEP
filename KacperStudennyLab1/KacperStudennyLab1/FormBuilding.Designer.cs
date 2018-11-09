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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelResourcesStatus = new System.Windows.Forms.Label();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materiał potrzebne do dalszej rozbudowy";
            // 
            // LabelResourcesStatus
            // 
            this.LabelResourcesStatus.AutoSize = true;
            this.LabelResourcesStatus.Location = new System.Drawing.Point(12, 46);
            this.LabelResourcesStatus.Name = "LabelResourcesStatus";
            this.LabelResourcesStatus.Size = new System.Drawing.Size(154, 13);
            this.LabelResourcesStatus.TabIndex = 2;
            this.LabelResourcesStatus.Text = "MateriałyPosiadane/Potrzebne";
            this.LabelResourcesStatus.Click += new System.EventHandler(this.LabelResourcesStatus_Click);
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
            // FormBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 151);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonIncrement);
            this.Controls.Add(this.LabelResourcesStatus);
            this.Controls.Add(this.label1);
            this.Name = "FormBuilding";
            this.Text = "FormBuilding";
            this.Load += new System.EventHandler(this.FormBuilding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label LabelResourcesStatus;
    }
}