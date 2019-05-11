namespace temperaturu_skaiciuokle
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
            this.tb_celcius = new System.Windows.Forms.TextBox();
            this.tb_farenheit = new System.Windows.Forms.TextBox();
            this.tb_reomiur = new System.Windows.Forms.TextBox();
            this.tb_kelvin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.konvertuoti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_celcius
            // 
            this.tb_celcius.Location = new System.Drawing.Point(189, 64);
            this.tb_celcius.Name = "tb_celcius";
            this.tb_celcius.Size = new System.Drawing.Size(71, 20);
            this.tb_celcius.TabIndex = 0;
            // 
            // tb_farenheit
            // 
            this.tb_farenheit.Location = new System.Drawing.Point(189, 145);
            this.tb_farenheit.Name = "tb_farenheit";
            this.tb_farenheit.Size = new System.Drawing.Size(71, 20);
            this.tb_farenheit.TabIndex = 1;
            // 
            // tb_reomiur
            // 
            this.tb_reomiur.Location = new System.Drawing.Point(189, 251);
            this.tb_reomiur.Name = "tb_reomiur";
            this.tb_reomiur.Size = new System.Drawing.Size(71, 20);
            this.tb_reomiur.TabIndex = 2;
            // 
            // tb_kelvin
            // 
            this.tb_kelvin.Location = new System.Drawing.Point(189, 200);
            this.tb_kelvin.Name = "tb_kelvin";
            this.tb_kelvin.Size = new System.Drawing.Size(71, 20);
            this.tb_kelvin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celcijaus laipsniai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Farenheito laipsniai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kelvino laipsniai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reomiūro laipsniai";
            // 
            // konvertuoti
            // 
            this.konvertuoti.Location = new System.Drawing.Point(87, 103);
            this.konvertuoti.Name = "konvertuoti";
            this.konvertuoti.Size = new System.Drawing.Size(173, 23);
            this.konvertuoti.TabIndex = 8;
            this.konvertuoti.Text = "Konvertuoti";
            this.konvertuoti.UseVisualStyleBackColor = true;
            this.konvertuoti.Click += new System.EventHandler(this.Konvertuoti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperatūros skaičiuoklė";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.konvertuoti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_kelvin);
            this.Controls.Add(this.tb_reomiur);
            this.Controls.Add(this.tb_farenheit);
            this.Controls.Add(this.tb_celcius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_celcius;
        private System.Windows.Forms.TextBox tb_farenheit;
        private System.Windows.Forms.TextBox tb_reomiur;
        private System.Windows.Forms.TextBox tb_kelvin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button konvertuoti;
        private System.Windows.Forms.Label label5;
    }
}

