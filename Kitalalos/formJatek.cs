using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitalalos
{
    public partial class formJatek : Form
    {
        static int tippeles = 0;
        static szavak[] rejtettszavak = new szavak[100];
        public formJatek()
        {
            InitializeComponent();
        }

        private void Kezdooldal_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileStream sr = new FileStream("szavak.txt", FileMode.Open);
            Console.WriteLine("1. Feladat: ");
            Console.WriteLine();
            StreamReader beolvas = new StreamReader(sr);
            while (!beolvas.EndOfStream)
            {
                string[] valaszt = beolvas.ReadLine().Split(' ');
                if (tippeles < rejtettszavak.Length)
                {
                    rejtettszavak[tippeles] = valaszt[0];
                    tippeles++;
                }
                else
                {
                    break;
                }
            }
            beolvas.Close();
            sr.Close();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Valasz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
