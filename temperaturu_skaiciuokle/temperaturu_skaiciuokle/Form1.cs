using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperaturu_skaiciuokle
{
    public partial class Form1 : Form
    {
        private double celcius;
        private double farenheit;
        private double kelvin;
        private double reomiur;
        public Form1()
        {
            InitializeComponent();
        }

        private void Konvertuoti_Click(object sender, EventArgs e)
        {
            celcius = int.Parse(tb_celcius.Text);
            farenheit = celcius * 9 / 5 + 32;
            kelvin = celcius + 273.16;
            reomiur = 0.8 * celcius;
            tb_farenheit.Text = farenheit.ToString();
            tb_kelvin.Text = kelvin.ToString();
            tb_reomiur.Text = reomiur.ToString();
        }
    }
}
