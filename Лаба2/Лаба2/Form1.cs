using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (txbText.Text != "")
            {
                //txbText.ForeColor = System.Drawing.Color.Red;
                txbText.ForeColor = Color.Red;
            }
            else MessageBox.Show("В текстовом поле нет текста!", "Ошибка", MessageBoxButtons.OK);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (txbText.Text != "")
            {
                //txbText.ForeColor = System.Drawing.Color.Blue;
                txbText.ForeColor = Color.Blue;
            }
            else MessageBox.Show("В текстовом поле нет текста!", "Ошибка", MessageBoxButtons.OK);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (txbText.Text != "")
            {
                //txbText.ForeColor = System.Drawing.Color.Green;
                txbText.ForeColor = Color.Green;
            }
            else MessageBox.Show("В текстовом поле нет текста!", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
