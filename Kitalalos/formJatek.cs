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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kitalalos
{
    public partial class formJatek : Form
    {
        static int tippeles = 0;
        static Szavak[] rejtettszavak = new Szavak[100];
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
            textBox_Tipp.Text = string.Empty;
        }

        private void textBox_Valasz_TextChanged(object sender, EventArgs e)
        {
            char magyarEkezetesChar1 = 'á';
            char magyarEkezetesChar2 = 'ő';
            char magyarEkezetesChar3 = 'é';
            char magyarEkezetesChar4 = 'ű';
            char magyarEkezetesChar5 = 'ó';
            char magyarEkezetesChar6 = 'í';
            char magyarEkezetesChar7 = 'ú';
            char magyarEkezetesChar8 = 'ő';
            
            string valasz = "";
            for (int i = 0; i < rejtettszavak.Length; i++)
            {
                if (rejtettszavak[i] == textBox_Tipp[i])
                {
                    valasz += rejtettszavak[i];
                }
                else
                {
                    valasz += ".";
                    Console.WriteLine(magyarEkezetesChar1);
                    Console.WriteLine(magyarEkezetesChar2);
                    Console.WriteLine(magyarEkezetesChar3);
                    Console.WriteLine(magyarEkezetesChar4);
                    Console.WriteLine(magyarEkezetesChar5);
                    Console.WriteLine(magyarEkezetesChar6);
                    Console.WriteLine(magyarEkezetesChar7);
                    Console.WriteLine(magyarEkezetesChar8);
                }
            }
            return valasz;

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            string tipp = textBox_Tipp.Text;

            // Most használd fel a tippet, például kiírhatod egy MessageBox-ban
            MessageBox.Show("A tipped: " + tipp);            
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {

        }
    }
}
