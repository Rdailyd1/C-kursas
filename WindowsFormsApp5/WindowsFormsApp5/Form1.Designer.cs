namespace WindowsFormsApp5
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
            this.tbskaicius = new System.Windows.Forms.TextBox();
            this.lbskaicius = new System.Windows.Forms.Label();
            this.btntikrinti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbskaicius
            // 
            this.tbskaicius.Location = new System.Drawing.Point(128, 90);
            this.tbskaicius.Name = "tbskaicius";
            this.tbskaicius.Size = new System.Drawing.Size(100, 20);
            this.tbskaicius.TabIndex = 0;
            // 
            // lbskaicius
            // 
            this.lbskaicius.AutoSize = true;
            this.lbskaicius.Location = new System.Drawing.Point(58, 93);
            this.lbskaicius.Name = "lbskaicius";
            this.lbskaicius.Size = new System.Drawing.Size(47, 13);
            this.lbskaicius.TabIndex = 1;
            this.lbskaicius.Text = "Skaicius";
            // 
            // btntikrinti
            // 
            this.btntikrinti.Location = new System.Drawing.Point(128, 139);
            this.btntikrinti.Name = "btntikrinti";
            this.btntikrinti.Size = new System.Drawing.Size(75, 23);
            this.btntikrinti.TabIndex = 2;
            this.btntikrinti.Text = "Tikrinti";
            this.btntikrinti.UseVisualStyleBackColor = true;
            this.btntikrinti.Click += new System.EventHandler(this.btntikrinti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 345);
            this.Controls.Add(this.btntikrinti);
            this.Controls.Add(this.lbskaicius);
            this.Controls.Add(this.tbskaicius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbskaicius;
        private System.Windows.Forms.Label lbskaicius;
        private System.Windows.Forms.Button btntikrinti;
    }
}

