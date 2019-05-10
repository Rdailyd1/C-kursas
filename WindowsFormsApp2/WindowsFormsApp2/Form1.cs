using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int ugis;
        private int svoris;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbugis.Text, out ugis))
            {
                MessageBox.Show(String.Format("Nekorektiska ugio reiksme {0}", tbugis.Text));
            }
            if (!int.TryParse(tbsvoris.Text, out svoris))
            {
                MessageBox.Show(String.Format("Nekorektiska svorio reiksme {0}", tbugis.Text));
            }
            tbugis.Clear();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            tboutput.AppendText(string.Format("Ugis yra {0}", ugis));
            tboutput.AppendText(Environment.NewLine);
            tboutput.AppendText(string.Format("Svoris yra {0}", svoris));
            tboutput.AppendText(Environment.NewLine);
        }

        private void tbugis_TextChanged(object sender, EventArgs e)
        {
            int temp = 0;
            if (!int.TryParse(tbugis.Text, out temp)) ;
            {
                string s = tbugis.Text;
                s = s.Remove(s.Length - 1);
                tbugis.Text = s;
            }
        }
    }
}
