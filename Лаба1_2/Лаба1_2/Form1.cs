using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба1_2
{
    public partial class Form1 : Form
    {
        public double x = 0.0, y = 0.0, result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            x = double.Parse(txbX.Text);
            y = double.Parse(txbY.Text);
            if (x <= 10000 && y <= 10000)
            {
                result = x * y;
                Form2 f = new Form2(this);
                f.ShowDialog();
            }
            else MessageBox.Show("Одно из ваших чисел больше 10,000. Введите число поменьше.", "Ошибка", MessageBoxButtons.OK);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txbX.Text = "";
            txbY.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
