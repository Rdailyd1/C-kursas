namespace KMI_skaiciuokle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ugis = new System.Windows.Forms.TextBox();
            this.tb_svoris = new System.Windows.Forms.TextBox();
            this.btn_paskaiciuoti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_kmi = new System.Windows.Forms.Label();
            this.lb_isvada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(95, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KMI skaičiuoklė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Įveskite savo ūgį ir svorį";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ūgis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Svoris";
            // 
            // tb_ugis
            // 
            this.tb_ugis.Location = new System.Drawing.Point(152, 121);
            this.tb_ugis.Name = "tb_ugis";
            this.tb_ugis.Size = new System.Drawing.Size(64, 20);
            this.tb_ugis.TabIndex = 4;
            // 
            // tb_svoris
            // 
            this.tb_svoris.Location = new System.Drawing.Point(152, 163);
            this.tb_svoris.Name = "tb_svoris";
            this.tb_svoris.Size = new System.Drawing.Size(64, 20);
            this.tb_svoris.TabIndex = 5;
            // 
            // btn_paskaiciuoti
            // 
            this.btn_paskaiciuoti.Location = new System.Drawing.Point(99, 215);
            this.btn_paskaiciuoti.Name = "btn_paskaiciuoti";
            this.btn_paskaiciuoti.Size = new System.Drawing.Size(117, 23);
            this.btn_paskaiciuoti.TabIndex = 6;
            this.btn_paskaiciuoti.Text = "Paskaičiuoti";
            this.btn_paskaiciuoti.UseVisualStyleBackColor = true;
            this.btn_paskaiciuoti.Click += new System.EventHandler(this.btn_paskaiciuoti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rezultatas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(96, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "KMI";
            // 
            // lb_kmi
            // 
            this.lb_kmi.AutoSize = true;
            this.lb_kmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lb_kmi.Location = new System.Drawing.Point(156, 293);
            this.lb_kmi.Name = "lb_kmi";
            this.lb_kmi.Size = new System.Drawing.Size(18, 20);
            this.lb_kmi.TabIndex = 9;
            this.lb_kmi.Text = "0";
            // 
            // lb_isvada
            // 
            this.lb_isvada.AutoSize = true;
            this.lb_isvada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lb_isvada.ForeColor = System.Drawing.Color.Maroon;
            this.lb_isvada.Location = new System.Drawing.Point(96, 325);
            this.lb_isvada.Name = "lb_isvada";
            this.lb_isvada.Size = new System.Drawing.Size(0, 20);
            this.lb_isvada.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_isvada);
            this.Controls.Add(this.lb_kmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_paskaiciuoti);
            this.Controls.Add(this.tb_svoris);
            this.Controls.Add(this.tb_ugis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ugis;
        private System.Windows.Forms.TextBox tb_svoris;
        private System.Windows.Forms.Button btn_paskaiciuoti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_kmi;
        private System.Windows.Forms.Label lb_isvada;
    }
}

