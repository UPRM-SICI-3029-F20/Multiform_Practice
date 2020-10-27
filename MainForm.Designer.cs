namespace Multiform_Practice
{
    partial class MainForm
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
            this.BtnDisplayForm = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDisplayForm
            // 
            this.BtnDisplayForm.Location = new System.Drawing.Point(89, 52);
            this.BtnDisplayForm.Name = "BtnDisplayForm";
            this.BtnDisplayForm.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplayForm.TabIndex = 0;
            this.BtnDisplayForm.Text = "Display Other Form";
            this.BtnDisplayForm.UseVisualStyleBackColor = true;
            this.BtnDisplayForm.Click += new System.EventHandler(this.BtnDisplayForm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(262, 52);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 137);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDisplayForm);
            this.Name = "MainForm";
            this.Text = "Main Form (MultiForm Practice)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplayForm;
        private System.Windows.Forms.Button BtnExit;
    }
}

