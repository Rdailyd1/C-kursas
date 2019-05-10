using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbvardas.Text == "")
            {
                MessageBox.Show("Vardas negali buti tuscias!");
            }
            tboutput.Clear();
            tboutput.Text = String.Format("Sveikas {0}", tbvardas.Text);
            tboutput.AppendText(Environment.NewLine);
            tboutput.Text = String.Format("Malonu tave matyt");
        }    
    }
}
