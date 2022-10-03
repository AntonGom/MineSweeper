using MineSweeper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            int r = Convert.ToInt32(numericUpDown1.Value);
            int c = Convert.ToInt32(numericUpDown2.Value);
            int m = Convert.ToInt32(numericUpDown3.Value);

            if (r * c < 18 || m > r * c / 2)
            {
                MessageBox.Show("These parameters are invalid, please enter different values", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

           

            else

            {


                row = r;
                col = c;
                mines = m;
                text = "Custom";



                int size = Math.Min(30, 1000 / Math.Max(row, col));
                f = new Form2(text, row, col, size, mines);
                f.Show();

                this.Close();

            }
        }
    }
}
