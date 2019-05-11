using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class btnParodyt : Form
    {
        public btnParodyt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vardas = "Rolandas";
            DateTime sdata = DateTime.Now;
            MessageBox.Show(String.Format(vardas +" "+ sdata.ToString("yyyy-mm-dd")));
        }
    }
}
