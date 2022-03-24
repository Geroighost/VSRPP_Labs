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
    public partial class Form2 : Form
    {
        //Form1 mainForm = null;
        public Form2(Form1 mainForm)
        {
            double result = 0.0;
            result = mainForm.result;
            InitializeComponent();
            txbResult.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
