using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MORZE
{
    public partial class KezdoOldal : Form
    {
        public KezdoOldal()
        {
            InitializeComponent();
            Kodtabla Kod = new Kodtabla();
            Kod.beolvasas();
            Jelkeszlet.Items.Add( $"A morze ABC {Kodtabla.adatok.Count()} darab karakter kódját tartalmazza" );
        }

        private void Kodolas_Click(object sender, EventArgs e)
        {
           Kodolo ujablak = new Kodolo();
           ujablak.Show();
        }

        private void Dekodolas_Click(object sender, EventArgs e)
        {
            Dekodolo ujablak = new Dekodolo();
            ujablak.Show();
        }

        private void bezaras_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
