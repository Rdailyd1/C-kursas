namespace vardas_10_kartu
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
            this.tb_langas = new System.Windows.Forms.TextBox();
            this.btn_irasyti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_langas
            // 
            this.tb_langas.Location = new System.Drawing.Point(224, 59);
            this.tb_langas.Multiline = true;
            this.tb_langas.Name = "tb_langas";
            this.tb_langas.Size = new System.Drawing.Size(100, 176);
            this.tb_langas.TabIndex = 0;
            // 
            // btn_irasyti
            // 
            this.btn_irasyti.Location = new System.Drawing.Point(224, 254);
            this.btn_irasyti.Name = "btn_irasyti";
            this.btn_irasyti.Size = new System.Drawing.Size(100, 23);
            this.btn_irasyti.TabIndex = 1;
            this.btn_irasyti.Text = "Įrašyti";
            this.btn_irasyti.UseVisualStyleBackColor = true;
            this.btn_irasyti.Click += new System.EventHandler(this.Btn_irasyti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_irasyti);
            this.Controls.Add(this.tb_langas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_langas;
        private System.Windows.Forms.Button btn_irasyti;
    }
}

