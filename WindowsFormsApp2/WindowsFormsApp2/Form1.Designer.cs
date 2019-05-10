namespace WindowsFormsApp2
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
            this.tbugis = new System.Windows.Forms.TextBox();
            this.tboutput = new System.Windows.Forms.TextBox();
            this.tbsvoris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.lbugis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbugis
            // 
            this.tbugis.Location = new System.Drawing.Point(86, 46);
            this.tbugis.Name = "tbugis";
            this.tbugis.Size = new System.Drawing.Size(100, 20);
            this.tbugis.TabIndex = 0;
            this.tbugis.TextChanged += new System.EventHandler(this.tbugis_TextChanged);
            // 
            // tboutput
            // 
            this.tboutput.Location = new System.Drawing.Point(244, 46);
            this.tboutput.Multiline = true;
            this.tboutput.Name = "tboutput";
            this.tboutput.Size = new System.Drawing.Size(100, 70);
            this.tboutput.TabIndex = 2;
            // 
            // tbsvoris
            // 
            this.tbsvoris.Location = new System.Drawing.Point(86, 96);
            this.tbsvoris.Name = "tbsvoris";
            this.tbsvoris.Size = new System.Drawing.Size(100, 20);
            this.tbsvoris.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Svoris";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(86, 156);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(244, 156);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // lbugis
            // 
            this.lbugis.AutoSize = true;
            this.lbugis.Location = new System.Drawing.Point(24, 53);
            this.lbugis.Name = "lbugis";
            this.lbugis.Size = new System.Drawing.Size(28, 13);
            this.lbugis.TabIndex = 7;
            this.lbugis.Text = "Ugis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.lbugis);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsvoris);
            this.Controls.Add(this.tboutput);
            this.Controls.Add(this.tbugis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbugis;
        private System.Windows.Forms.TextBox tboutput;
        private System.Windows.Forms.TextBox tbsvoris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label lbugis;
    }
}

