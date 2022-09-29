using Bibliothèque.SecondForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothèque
{
    public partial class FormEmprinte : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Emprinte empr;
        
        public FormEmprinte(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormEmprinte_Load(object sender, EventArgs e)
        {
            bnd = new BindingSource();
            
            bnd.DataSource = db.Emprinte.ToList();           
            dataGridView1.DataSource = bnd;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            txtIdEmprinte.DataBindings.Add("text", bnd, "IdEmprinte", true);
            txtIdStagiaire.DataBindings.Add("text", bnd, "IdSagiaire", true);
            txtIdLivre.DataBindings.Add("text", bnd, "IdLivre", true);
            txtDatEmprint.DataBindings.Add("text", bnd, "DateEmprinte", true);
            txtDateRoteur.DataBindings.Add("text", bnd, "DateRoteur", true);
            txtIdEmprinte.Enabled = false;
            txtDatEmprint.Enabled = false;
            cbxIspnLivre.DataSource = db.Livre.ToList();
            cbxIspnLivre.DisplayMember = "IspnLivre";
            cbxIspnLivre.ValueMember = "IdLivre";
            cbxStagiaire.DataSource = db.Stagiaire.Select(item => new { item.IdStagiaire, fullnam = item.NomStagiaire + " " + item.PrenomStagiaire }).ToList();
            cbxStagiaire.DisplayMember = "fullnam";
            cbxStagiaire.ValueMember = "IdStagiaire";
            bnd.AllowNew = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtIdEmprinte.Text = Convert.ToString((db.Emprinte.Select(item => item.IdEmprinte).Max() + 1));
            }
            catch (Exception)
            {
              txtIdEmprinte.Text = "1";
                
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                empr = new Emprinte(int.Parse(txtIdEmprinte.Text), int.Parse(txtIdStagiaire.Text), int.Parse(txtIdLivre.Text));
                db.Emprinte.Add(empr);
                empr.Livre.EtatLivre = "Indisponible";
                db.SaveChanges();
                bnd.DataSource = db.Emprinte.ToList();
                MessageBox.Show("Votre Ligne est affecte");
            }
            catch (Exception)
            {

                MessageBox.Show("créer nouveau ligne apres saisie les donnees avec le button New Ou Verifie vous Donnees");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            new FormFiltrage(db).Show();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            empr = new Emprinte();
            empr = db.Emprinte.Find(int.Parse(txtIdEmprinte.Text));
            db.Emprinte.Remove(empr);
            db.SaveChanges();
            bnd.DataSource = db.Emprinte.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bnd.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bnd.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bnd.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bnd.MoveNext();
        }

        private void txtIdStagiaire_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbxStagiaire.SelectedValue = int.Parse(txtIdStagiaire.Text);
            }
            catch (Exception)
            {

            }
        }

        private void cbxStagiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdStagiaire.Text = cbxStagiaire.SelectedValue.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cbxIspnLivre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdLivre.Text = cbxIspnLivre.SelectedValue.ToString();
            }
            catch (Exception)
            {

                
            }
            
        }

        private void txtIdLivre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbxIspnLivre.SelectedValue = int.Parse(txtIdLivre.Text);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
