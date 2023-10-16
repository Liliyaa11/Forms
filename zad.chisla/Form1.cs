using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad.chisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           // if (textBox1.Text == "0")
           // {
           //     label1.Text= "Nula";   
           // }
           // else
           //   if (textBox1.Text == "1")
           // {
           //     label1.Text = "Edno";
           // } 
           // else
           // if (textBox1.Text == "2")
           // {
           //     label1.Text = "Dve";
           // }
           // else

            
           // if (textBox1.Text == "3")
           // {
           //     label1.Text = "Tri";
           // }
           // else

           // if (textBox1.Text == "4")
           // {
           //     label1.Text = "Chetiri";
           // }
           // else
          
           // if (textBox1.Text == "5")
           // {
           //     label1.Text = "Pet";
           // }
           // else
           
           // if (textBox1.Text == "6")
           // {
           //     label1.Text = "Shest";
           // }
           // else
           
           // if (textBox1.Text == "7")
           // {
           //     label1.Text = "Sedem";
           // }
           // else
            
           // if (textBox1.Text == "8")
           // {
           //     label1.Text = "Osem";
           // }
           // else
          
           // if (textBox1.Text == "9")
           // {
           //     label1.Text = "Devet";
           // }
           // else
            
           // if (textBox1.Text == "10")
           // {
           //     label1.Text = "Deset";
           // }
           //else 
           // {
           //     label1.Text = "Vuvel si neshto drugo";
           // }
           switch (textBox1.Text) 
            
            {
                case "0":
                    label1.Text = "nulla";
                    break;
                case "1":
                    label1.Text = "Edno";
                    break;
                case "2":
                    label1.Text = "Dve";
                    break;
                case "3":
                    label1.Text = "Tri";
                    break;
                case "4":
                    label1.Text = "Cetiri";
                    break;
                case "5":
                    label1.Text = "Pet";
                    break;
                case "6":
                    label1.Text = "Shest";
                    break;
                case "7":
                    label1.Text = "Sedem";
                    break;
                case "8":
                    label1.Text = "Osem";
                    break;
                case "9":
                    label1.Text = "Devet";
                    break;
                case "10":
                    label1.Text = "Deset";
                    break;
                default:
                    label1.Text = "Vuvel si neshto drugo";
                    MessageBox.Show("Vuvel si neshto drugo","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
