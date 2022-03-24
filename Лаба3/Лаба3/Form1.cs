using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            string currentbutton = radioBtn.Name;
            if (radioBtn.Checked == true)
            {
                switch (currentbutton)
                {
                    case "radioButton1":
                        {
                            textBox1.Text = "Красный";
                        } break;
                    case "radioButton2":
                        {
                            textBox1.Text = "Оранжевый";
                        } break;
                    case "radioButton3":
                        {
                            textBox1.Text = "Жёлтый";
                        } break;
                    case "radioButton4":
                        {
                            textBox1.Text = "Зелёный";
                        } break;
                    case "radioButton5":
                        {
                            textBox1.Text = "Голубой";
                        } break;
                    case "radioButton6":
                        {
                            textBox1.Text = "Синий";
                        } break;
                    case "radioButton7":
                        {
                            textBox1.Text = "Фиолетовый";
                        } break;
                }
            }
        }
    }
}