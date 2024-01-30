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
    public partial class formBevitel : Form
    {
        public formBevitel()
        {
            InitializeComponent();
        }

        private void Bevitel_Load(object sender, EventArgs e)
        {
            // Az elérési útvonal, ahol a szöveg fájl mentésre kerül
            string filePath = "szavak.txt";

            try
            {
                // A TextBox tartalmának kiolvasása
                string content = textBox_Bevitel.Text;

                // Ellenőrzés, hogy a TextBox üres-e
                if (string.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("Nincs megadva szöveg a mentéshez.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Szöveg írása a fájlba
                File.WriteAllText(filePath, content);

                // Sikeres mentés esetén üzenet megjelenítése
                MessageBox.Show("Sikeresen mentve a fájlba.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiba esetén hibaüzenet megjelenítése
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
