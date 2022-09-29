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
    public partial class FormSecteur : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Secteur sr;
        public FormSecteur(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormSecteur_Load(object sender, EventArgs e)
        {

            
            bnd = new BindingSource();
            bnd.DataSource = db.Secteur.ToList();
            dataGridView1.DataSource = bnd;
            txtId.DataBindings.Add("text", bnd, "IdSecteur", true);
            txtNom.DataBindings.Add("text", bnd, "NomSecteur", true);
            txtId.Enabled = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtId.Text = Convert.ToString((db.Secteur.Select(item => item.IdSecteur).Max() + 1));
            }
            catch (Exception)
            { txtId.Text = "1"; }
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //bnd.EndEdit();
            //db.SaveChanges();
            sr = db.Secteur.Find(int.Parse(txtId.Text));
            sr.NomSecteur = txtNom.Text;
            db.SaveChanges();
            bnd.DataSource = db.Secteur.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sr = new Secteur();
            sr = db.Secteur.Find(int.Parse(txtId.Text));
            db.Secteur.Remove(sr);
            db.SaveChanges();
            bnd.DataSource= db.Secteur.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sr = new Secteur(int.Parse(txtId.Text), txtNom.Text);
                db.Secteur.Add(sr);
                db.SaveChanges();
                bnd.DataSource = db.Secteur.ToList();
                MessageBox.Show("Votre Ligne est affecte");

            }
            catch (Exception)
            {
                MessageBox.Show("créer nouveau ligne apres saisie les donnees avec le button New Ou Verifie vous Donnees");

            }
            
        }
    }
}
