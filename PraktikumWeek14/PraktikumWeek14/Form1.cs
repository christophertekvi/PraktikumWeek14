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

            //char[] hurufbesar = new char[textBoxInput.Text.Length];
            //char[] hurufkecil = new char[textBoxInput.Text.Length];
            //char[] angka = new char[textBoxInput.Text.Length];
            //char[] simbol = new char[textBoxInput.Text.Length];

            //for (int i = 0; i < textBoxInput.Text.Length; i++)
            //{
            //    if (char.IsSymbol(arr1[i]) == true)
            //    {
            //        simbol[i] = arr1[i];
            //    }
            //    if (char.IsNumber(arr1[i]) == true)
            //    {
            //        angka[i] = arr1[i];
            //    }
            //    if (char.IsUpper(arr1[i]) == true)
            //    {
            //        hurufbesar[i] = arr1[i];
            //    }
            //    if (char.IsLower(arr1[i]) == true)
            //    {
            //        hurufkecil[i] = arr1[i];
            //    }
            //}

            string output = new string (arr1);


            labelOutput.Text = output;
        }
    }
}
