using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vardas_10_kartu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_irasyti_Click(object sender, EventArgs e)
        {
            string vardas = "Rolandas";
            for(int i=0;i<10; i++)
            {
                tb_langas.AppendText(vardas+"\r\n");
            }
        }
    }
}

