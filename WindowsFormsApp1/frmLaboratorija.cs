using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
     partial class frmLaboratorija : Form
    {
        public Stack<Analiza> analize;
        public frmLaboratorija()
        {
            InitializeComponent();
            analize = new Stack<Analiza>();
            tbCenaAnaliza.Text = "0";
            tbBrojAnaliza.Text = 0.ToString();
            for(int i=1;i<=5;i++)
            {
                cmbPrioritet.Items.Add(i);
            }
         


        }
        

        private void Ispis()
        {
            richTextBox1.Clear();
            double zbir = 0;
            int brojac = 0;
            foreach(Analiza a in analize)
            {
                richTextBox1.AppendText(a.ToString() + " ");
                zbir += a.Cena;
                brojac++;
            }
            tbCenaAnaliza.Text = zbir.ToString();
            tbBrojAnaliza.Text = brojac.ToString();
            cmbPrioritet.Text = "";
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            frmUnosAnalize unosAnalize = new frmUnosAnalize();
            if (unosAnalize.ShowDialog() == DialogResult.OK)
            {
                analize.Push(unosAnalize.analiza);
                Ispis();
            }

        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            if(analize.Count != 0)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Tekstualni fajl | *.txt ";
                if(saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveDialog.FileName);
                    try
                    {
                        foreach(Analiza a in analize)
                        {
                            sw.WriteLine(a.ToString());
                        }
                        sw.WriteLine("Ukupno analiza: " + analize.Count);
                        MessageBox.Show("Uspesno ste sacuvali analize!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Greska: " + ex.Message);

                    }
                    finally
                    {
                        sw.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Stek je prazan, nije moguce sacuvati!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Ispis();
            }


        }

        private void cmbPrioritet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int broj = 0;
            foreach(Analiza a in analize)
            {
                if(Convert.ToInt32(cmbPrioritet.Text)== a.Prioritet)
                {
                    broj++;
                }
            }
            tbBrojAnaliza.Clear();
            tbBrojAnaliza.Text = broj.ToString();
        }

        private void frmLaboratorija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Gotovo za danas", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information)== DialogResult.OK)
            {
                analize.Clear();
                MessageBox.Show("Sve analize su zavrsene", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                e.Cancel = true;
            }
            
        }
    }
}
