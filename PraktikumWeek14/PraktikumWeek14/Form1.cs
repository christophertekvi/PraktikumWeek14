using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tidak ada inputan!!");
            }

            char[] arr1 = new char[textBoxInput.TextLength];
            

            for (int i = 0; i < textBoxInput.TextLength; i++)
            {
                arr1[i] = Convert.ToChar(textBoxInput.Text.Substring(i, 1));
            }

            Array.Reverse(arr1);

            string output = new string(arr1);

            labelOutput.Text = output;

        }

        private void buttonUrut_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tidak ada inputan!!");
            }

            char[] arr1 = new char[textBoxInput.TextLength];


            for (int i = 0; i < textBoxInput.TextLength; i++)
            {
                arr1[i] = Convert.ToChar(textBoxInput.Text.Substring(i, 1));
            }

            Array.Sort(arr1);



            string output = new string(arr1);

            labelOutput.Text = output;
        }
    }
}
