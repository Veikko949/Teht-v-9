using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Toimii ok nappina
        private void kilometritV_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double kustanukset, laina, lisanesteet, vakuuts, muut, poltoaine, pesut, huollot, renkaat, kilometrit;

            laina = Convert.ToDouble(laina_textBox.Text);
            lisanesteet = Convert.ToDouble(nesteet_textBox.Text);
            vakuuts = Convert.ToDouble(vakuutus_textBox.Text);
            muut = Convert.ToDouble(muutkulut_textBox.Text);
            poltoaine = Convert.ToDouble(poltoaine_textBox.Text);
            pesut = Convert.ToDouble(pesut_textBox.Text);
            huollot = Convert.ToDouble(huollot_textBox.Text);
            renkaat = Convert.ToDouble(renkaat_textBox.Text);
            kilometrit = Convert.ToDouble(kilometritV_comboBox.Text);

            kustanukset = (laina + lisanesteet + vakuuts + muut + poltoaine + pesut + huollot + renkaat) / (kilometrit / 12);

            vastaus_label.Text = "Kustanukset kilometrejä kohti ovat: " + kustanukset;
            vastaus_label.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
