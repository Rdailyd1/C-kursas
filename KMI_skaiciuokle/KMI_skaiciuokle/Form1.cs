using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMI_skaiciuokle
{
    public partial class Form1 : Form
    {
        private double ugis;
        private double svoris;
        private double kmi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_paskaiciuoti_Click(object sender, EventArgs e)
        {
            ugis = double.Parse(tb_ugis.Text)/100;
            svoris = double.Parse(tb_svoris.Text);
            kmi = Math.Round(svoris / Math.Pow(ugis, 2),2);
            lb_kmi.Text = String.Format(kmi.ToString());
            if (kmi <= 18.5)
            {
                lb_isvada.Text = "Asmuo yra nusilpęs ir jo kūno svoris per mažas.";
            }
            else if(kmi > 18.5 && kmi <= 25)
            {
                lb_isvada.Text = "Idealus kūno masės indeksas.";
            }
            else if (kmi > 25 && kmi <= 30)
            {
                lb_isvada.Text = "Asmuo turi antsvorį.";
            }
            else
            {
                lb_isvada.Text = "Asmuo yra nutukęs.";
            }
        }
    }
}
