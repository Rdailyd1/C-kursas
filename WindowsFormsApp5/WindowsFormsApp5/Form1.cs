using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private int skaicius;
        public Form1()
        {
            InitializeComponent();
        }

        private void btntikrinti_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbskaicius.Text, out skaicius))
            {
                MessageBox.Show(String.Format("Blogas formatas {0}", tbskaicius.Text));
            }
            if (skaicius % 2 == 0)
            {
                MessageBox.Show("Lyginis");
            }
            else
            {
                MessageBox.Show("Nelyginis");
            }
          
        }
    }
}
