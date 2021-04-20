using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
     partial class frmUnosAnalize : Form
    {

        public Analiza analiza;
        public frmUnosAnalize()
        {
            InitializeComponent();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(tbIme.Text))
            {
                errorProvider1.SetError(tbIme, "Morate popuniti ovo polje!");
                return;
                tbIme.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }

        }
        private bool izabranTipCheckedListBox()
        {
            bool izabran = false;
            if(checkedListBox1.CheckedItems.Count == 0)
            {
                izabran = false;
            }
            else
            {
                izabran = true;
            }
            return izabran;
        }
        private bool izabranTipPanel()
        {
            bool izabran = false;
            foreach(CheckBox cb in panel1.Controls)
            {
                if(cb.Checked)
                {
                    izabran = true;
                }
                else
                {
                    izabran = false;
                }
                
            }
            return izabran;
        }

        private int vratiBrojAnaliza()
        {
            int brojac = 0;
            foreach(CheckBox cb in panel1.Controls)
            {
                if(cb.Checked)
                {
                    brojac++;
                }
            }
            return brojac;
        }
        private string vratiAnalize()
        {
            string analize = "";
            foreach(CheckBox cb in panel1.Controls)
            {
                analize = cb.Text +" ";
            }
            return analize;
        }

        public int vratiBrojAnaliza1()
        {
            int brojac = 0;
            foreach(string s in checkedListBox1.CheckedItems)
            {
                brojac += s.Count();
            }
            return brojac;
        }
        private string vratiAnalize1()
        {
            string analiza = "";
            foreach(string s in checkedListBox1.CheckedItems)
            {
                analiza += s.ToString() + " ";
            }
            return analiza;
        }
        
        private double racunajCenu()
        {
            vratiBrojAnaliza();

            double cena = 300;

            if (trackBar1.Value == 1)
            {
                cena = vratiBrojAnaliza() * cena * 1.50;
            }
            else if (trackBar1.Value == 2)
            {
                cena = vratiBrojAnaliza() * cena * 1.25;
            }
            else if (trackBar1.Value == 3)
            {
                cena = vratiBrojAnaliza() * cena * 1.15;
            }
            else if (trackBar1.Value == 4)
            {
                cena = vratiBrojAnaliza() * cena * 1.10;
            }
            return cena;
            
        }
        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            textBox1.Text = racunajCenu().ToString();
            if(tbIme.Text != "" && izabranTipCheckedListBox() )
            {
                racunajCenu();
                analiza = new Analiza();
                analiza.Cena = racunajCenu();
                analiza.Ime = tbIme.Text;
                analiza.Prioritet = trackBar1.Value;
                analiza.Tip = vratiAnalize();
                

                MessageBox.Show("Uspesno ste uneli sve!", "Uspeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Morate popuniti sve!", "Neuspeh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
