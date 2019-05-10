namespace WindowsFormsApp3
{
    partial class Form1
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
            this.btnparodyt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnparodyt
            // 
            this.btnparodyt.Location = new System.Drawing.Point(177, 57);
            this.btnparodyt.Name = "btnparodyt";
            this.btnparodyt.Size = new System.Drawing.Size(86, 23);
            this.btnparodyt.TabIndex = 0;
            this.btnparodyt.Text = "Parodyti";
            this.btnparodyt.UseVisualStyleBackColor = true;
            this.btnparodyt.Click += new System.EventHandler(this.btnparodyt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.btnparodyt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnparodyt;
    }
}

