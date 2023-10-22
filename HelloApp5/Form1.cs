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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HelloApp5
{
    public partial class Form1 : Form
    {
        public static string DoubleLitter(string s)
        {
            string st = string.Empty;
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            foreach (char c in s)
            {
                if (consonants.Contains(c))
                {
                    st += c.ToString() + c.ToString();
                }
                else
                {
                    st += c.ToString();
                }
            }
            return st;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len1, len2;
            string word1, word2;
            word1 = textBox1.Text;
            word2 = textBox2.Text;
            len1 = word1.Length;
            len2 = word2.Length;
            if (len1 > len2)
            {
                label6.Text = "Первое слово больше на " + (len1 - len2) + " знаков";
            }
            else if (len1 < len2)
            {
                label6.Text = "Второе слово больше на " + (len2 - len1) + " знаков";
            }
            else
            {
                label6.Text = "Слова имеют одинаковое количество знаков";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str2, strrev = String.Empty, strrevn = String.Empty;
            int size = 0, count1 = 0, count2 = 0, k = 0;
            string[] arrString;
            str2 = textBox3.Text;
            foreach (char c in str2)
            {
                if (c.ToString() == "." || c.ToString() == ",")
                {
                    size++;
                }
            }
            Console.WriteLine(size);
            arrString = new string[size];
            foreach (char c in str2)
            {
                if (c.ToString() == "." || c.ToString() == ",")
                {
                    for (int i = (count1 - count2); i < count1; i++)
                    {
                        arrString[k] += str2[i];
                    }
                    k++;
                    count2 = 0;
                }
                else
                {
                    count2++;
                }
                count1++;
            }
            for (int i = size - 1; i >= 0; i--)
            {
                strrev += arrString[i] + ",";
            }
            strrevn = strrev.Remove(strrev.Length - 1) + ".";
            label8.Text = strrevn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox4.Text;
            label10.Text = DoubleLitter(str);
        }
    }
}
