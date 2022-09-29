using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothèque.SecondForms
{
    public partial class FormFiltrage : Form
    {
        BibliothèqueEntities db;
        Emprinte empr;
        public FormFiltrage(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }
        private void chargeDetailsManual(DateTime dat1,DateTime dat2)
        {
            labelLivrePerdu.Text = db.LivrePerdus.Where(item => item.datPerdu >= dat1 && item.datPerdu<=dat2).Count().ToString();
            labelLivreRetourné.Text = db.Emprinte.Where(item => item.DateRoteur >= dat1 && item.DateRoteur <= dat2).Count().ToString(); ;
            labelLivreSorti.Text = db.Emprinte.Where(item => item.DateEmprinte >= dat1 && item.DateEmprinte <= dat2).Count().ToString(); ;
        }
        private void chargeDetailsStock(int indexChoix)
        {
            DateTime dt = System.DateTime.Today;
            if(indexChoix<4 && indexChoix>-1)
            switch(indexChoix)
                {
                    case 0:
                        labelLivrePerdu.Text = db.LivrePerdus.Where(item => item.datPerdu == dt.Date).Count().ToString();
                        labelLivreRetourné.Text = db.Emprinte.Where(item => item.DateRoteur == dt.Date).Count().ToString();
                        labelLivreSorti.Text = db.Emprinte.Where(item => item.DateEmprinte==dt.Date).Count().ToString();
                        break;
                    case 1:
                        dt = System.DateTime.Today.AddDays(-7);
                        labelLivrePerdu.Text = db.LivrePerdus.Where(item => item.datPerdu >= dt.Date).Count().ToString();
                        labelLivreRetourné.Text = db.Emprinte.Where(item => item.DateRoteur >= dt.Date).Count().ToString();
                        labelLivreSorti.Text = db.Emprinte.Where(item => item.DateEmprinte >= dt.Date).Count().ToString();
                        break;
                    case 2:
                        dt = System.DateTime.Today.AddMonths(-1);
                        labelLivrePerdu.Text = db.LivrePerdus.Where(item => item.datPerdu >= dt.Date).Count().ToString();
                        labelLivreRetourné.Text = db.Emprinte.Where(item => item.DateRoteur >= dt.Date).Count().ToString();
                        labelLivreSorti.Text = db.Emprinte.Where(item => item.DateEmprinte >= dt.Date).Count().ToString();
                        break;
                }
            
        }
        
       
        private void clearResult()
        {
            labelLivrePerdu.Text = "0";
            labelLivreRetourné.Text = "0";
            labelLivreSorti.Text = "0";
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clearResult();
            panelDatManual.Enabled = false;
            cbxDateStock.Enabled = true;
            
        }

        private void FiltrageEmprint_Load(object sender, EventArgs e)
        {

        }

        private void FormFiltrage_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = db.Emprinte.Select(item => new { item.IdEmprinte, item.Livre.IspnLivre, item.Livre.Ouvrage.TitreOuvrage, Fullnam = item.Stagiaire, item.DateEmprinte, item.DateRoteur , Prix = item.Livre.Ouvrage.PrixOuvrage }).Where(item =>item.DateRoteur==null).ToList();
            labelTotalLivre.Text = db.Livre.Count().ToString();
            labelTotalOuvrage.Text= db.Ouvrage.Count().ToString();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbxDateStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargeDetailsStock(cbxDateStock.SelectedIndex);
        }

        private void bntConfirme_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("les Stagiaire " + guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString() + " a rendu le livre numéroté " + guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString(), "Confirmation Roteur", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    empr = db.Emprinte.Find(int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    DateTime dta = System.DateTime.Now;
                    empr.DateRoteur = dta.Date;
                    db.SaveChanges();
                    guna2DataGridView1.DataSource = db.Emprinte.Select(item => new { item.IdEmprinte, item.Livre.IspnLivre, item.Livre.Ouvrage.TitreOuvrage, Fullnam = item.Stagiaire, item.DateEmprinte, item.DateRoteur,Prix=item.Livre.Ouvrage.PrixOuvrage }).ToList();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult dar = MessageBox.Show("Ce livre coûte " + guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString() + "  dirhams  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dar == DialogResult.Yes)
                {
                    empr = db.Emprinte.Find(int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    db.LivrePerdus.Add(new LivrePerdu(empr.Livre.IdLivre));
                    Livre lvrpdu = db.Livre.Find(empr.Livre.IdLivre);
                    lvrpdu.EtatLivre = "perdu";
                    db.Emprinte.Remove(empr);
                    db.SaveChanges();
                    MessageBox.Show("L'opération a réussi");
                    guna2DataGridView1.DataSource = db.Emprinte.Select(item => new { item.IdEmprinte, item.Livre.IspnLivre, item.Livre.Ouvrage.TitreOuvrage, Fullnam = item.Stagiaire, item.DateEmprinte, item.DateRoteur, Prix = item.Livre.Ouvrage.PrixOuvrage }).ToList();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
            
            
            
            
        }

        private void radiobtnManual_CheckedChanged(object sender, EventArgs e)
        {
            clearResult();
            cbxDateStock.Enabled = false;
            panelDatManual.Enabled = true;           
        }

        private void DtPickerPremier_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                chargeDetailsManual(DtPickerPremier.Value.Date, DtPickerDexiem.Value.Date);
            }
            catch (Exception)
            {

                
            }
           
        }

        private void DtPickerDexiem_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                chargeDetailsManual(DtPickerPremier.Value.Date, DtPickerDexiem.Value.Date);
            }
            catch (Exception)
            {


            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = db.Emprinte.Select(item => new { item.IdEmprinte, item.Livre.IspnLivre, item.Livre.Ouvrage.TitreOuvrage, item.Stagiaire, item.DateEmprinte, item.DateRoteur, Prix = item.Livre.Ouvrage.PrixOuvrage }).Where(item => (item.Stagiaire.NomStagiaire+item.Stagiaire.PrenomStagiaire).Contains(txtIspn.Text)).ToList();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(panelDatManual.Enabled==true)
            {
                try
                {
                    new FormReporting(db.Emprinte.Where(item => item.DateEmprinte >= DtPickerPremier.Value.Date && item.DateEmprinte <= DtPickerDexiem.Value.Date && item.DateRoteur == null).ToArray()).Show();
                }
                catch (Exception)
                {

                    
                }
               
            }
            else
                if(cbxDateStock.Enabled==true)
            {
                try
                {
                    int indexChoix = cbxDateStock.SelectedIndex;
                    DateTime dt = System.DateTime.Today;
                    if (indexChoix < 4 && indexChoix > -1)
                        switch (indexChoix)
                        {
                            case 0:
                                new FormReporting(db.Emprinte.Where(item => item.DateEmprinte == dt.Date && item.DateRoteur == null).ToArray()).Show();
                                break;
                            case 1:
                                dt = System.DateTime.Today.AddDays(-7);
                                new FormReporting(db.Emprinte.Where(item => item.DateEmprinte >= dt.Date && item.DateRoteur == null).ToArray()).Show();
                                break;
                            case 2:
                                dt = System.DateTime.Today.AddMonths(-1);
                                new FormReporting( db.Emprinte.Where(item => item.DateEmprinte >= dt.Date && item.DateRoteur==null).ToArray()).Show();
                                break;

                        }

                }
                catch (Exception)
                {

                    
                }
            }
            
        }

        private void reporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int emprint= int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            new FormReporting(db.Emprinte.Where(item => item.IdEmprinte == emprint).ToArray(), 1).Show();
        }
    }
}
