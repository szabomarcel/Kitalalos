using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitalalos
{
    public partial class formKezdooldal : Form
    {
        public formKezdooldal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Bevitel_Click(object sender, EventArgs e)
        {
            int button= 2;
            switch (button)
            {
                case 1:
                    Console.WriteLine("formBevitel");
                    break;
                case 2:
                    Console.WriteLine("formJatek");
                    break;
                default:
                    Console.WriteLine("formKezdooldal");
                    break;
            }            
        }
    }
}
