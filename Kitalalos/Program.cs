using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitalalos
{
    internal static class Program
    {
        public static formKezdooldal formKezdooldal = null;
        public static formBevitel formBevitel = null;
        public static formJatek formJatek = null;
        static void Main()
        {
            formKezdooldal = new formKezdooldal();
            formBevitel = new formBevitel();
            formJatek = new formJatek();
            Application.Run(formBevitel);
        }
    }
}
