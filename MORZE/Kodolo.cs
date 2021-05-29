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
    public partial class Kodolo : Form
    {
        public Kodolo()
        {
            InitializeComponent();
        }

        

        private void Forditando_TextChanged(object sender, EventArgs e)
        {
            string ForditandoSzoveg = ForditandoTextBox.Text.ToUpper();
            string ForditottSzoveg = "";
            for (int i = 0; i < ForditandoSzoveg.Length; i++)
            {
                if (ForditandoSzoveg[i] == ' ')
                {
                    ForditottSzoveg = ForditottSzoveg + "       ";
                }
                else
                {
                    for (int j = 0; j < Kodtabla.adatok.Count; j++)
                    {
                        if (Convert.ToChar(Kodtabla.adatok[j].Betu) == ForditandoSzoveg[i])
                        {
                            ForditottSzoveg = ForditottSzoveg + Kodtabla.adatok[j].MorzeKod;
                        }
                    }
                }
                ForditottSzoveg = ForditottSzoveg + "   ";
            }
            ForditottTextBox.Text = ForditottSzoveg;
        }

        private void bezaras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TorlesGomb_Click(object sender, EventArgs e)
        {
            ForditandoTextBox.Text = "";
            ForditottTextBox.Text = "";
        }
    }
}
