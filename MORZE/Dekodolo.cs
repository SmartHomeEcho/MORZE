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
    public partial class Dekodolo : Form
    {
        public Dekodolo()
        {
            InitializeComponent();
            
        }

        

        private void ForditandoTextBox_TextChanged(object sender, EventArgs e)
        {
            string Kodoltszoveg = ForditandoTextBox.Text;
            Kodoltszoveg = Kodoltszoveg.Replace("       ", "_");
            Kodoltszoveg = Kodoltszoveg.Replace("   ", "+");
            string[] kodoltszovegszavai = Kodoltszoveg.Split('_');
            string dekodoltszoveg = "";
            for (int i = 0; i < kodoltszovegszavai.Length; i++)
            {
                string[] Kodoltszovegbetui = kodoltszovegszavai[i].Split('+');
                for (int j = 0; j < Kodoltszovegbetui.Length; j++)
                {
                    for (int k = 0; k < Kodtabla.adatok.Count; k++)
                    {
                        if (Kodoltszovegbetui[j] == Kodtabla.adatok[k].MorzeKod)
                        {
                            dekodoltszoveg += Kodtabla.adatok[k].Betu;
                        }
                    }
                }
                dekodoltszoveg += " ";
            }
            dekodoltszoveg = dekodoltszoveg.Trim();
            ForditottLabel.Text = dekodoltszoveg;
        }

        private void TorlesGomb_Click(object sender, EventArgs e)
        {
            ForditandoTextBox.Text = "";
        }

        private void bezaras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
