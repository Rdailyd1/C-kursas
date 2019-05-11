using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestrai
{
    public partial class Form1 : Form
    {
        private int pirmas_semestras;
        private int antras_semestras;
        private int trecias_semestras;
        private int vidurkis;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tb_pazymiai.Clear();
            pirmas_semestras = Convert.ToInt16(tb_semestras1.Text);
            antras_semestras = Convert.ToInt16(tb_semestras2.Text);
            trecias_semestras = Convert.ToInt16(tb_semestras3.Text);
            vidurkis = (pirmas_semestras + antras_semestras + trecias_semestras) / 3;
            tb_pazymiai.AppendText(pirmas_semestras.ToString() + "\r\n" + antras_semestras.ToString() + "\r\n" + trecias_semestras.ToString());
            tb_vidurkis.Text = String.Format(vidurkis.ToString());
        }
    }
}
