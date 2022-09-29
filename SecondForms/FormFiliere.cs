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
    public partial class FormFiliere : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Filiere flr;

        public FormFiliere(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormFiliere_Load(object sender, EventArgs e)
        {
            bnd = new BindingSource();
            
            bnd.DataSource= db.Filiere.ToList();
            dataGridView1.DataSource = bnd;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            txtIDFiliere.DataBindings.Add("text", bnd, "IdFiliere", true);
            TxtIdSecteur.DataBindings.Add("text", bnd, "IdSecteur", true);
            txtNomFiliere.DataBindings.Add("text", bnd, "NomFiliere", true);
            txtIDFiliere.Enabled = false;
            cbxSecteur.DataSource = db.Secteur.ToList();
            cbxSecteur.DisplayMember = "NomSecteur";
            cbxSecteur.ValueMember = "IdSecteur";
            




        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtIDFiliere.Text = Convert.ToString((db.Filiere.Select(item => item.IdFiliere).Max() + 1));
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                flr = new Filiere(int.Parse(txtIDFiliere.Text), txtNomFiliere.Text, int.Parse(TxtIdSecteur.Text));
                db.Filiere.Add(flr);
                db.SaveChanges();
                bnd.DataSource = db.Filiere.ToList();
                MessageBox.Show("Votre Ligne est affecte");
            }
            catch (Exception)
            {

                MessageBox.Show("créer nouveau ligne apres saisie les donnees avec le button New Ou Verifie vous Donnees");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flr = db.Filiere.Find(int.Parse(txtIDFiliere.Text));
            flr.NomFiliere = txtNomFiliere.Text;
            flr.IdSecteur = int.Parse(TxtIdSecteur.Text);
            db.SaveChanges();
            bnd.DataSource = db.Filiere.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            flr = new Filiere();
            flr = db.Filiere.Find(int.Parse(txtIDFiliere.Text));
            db.Filiere.Remove(flr);
            db.SaveChanges();
            bnd.DataSource = db.Filiere.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bnd.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bnd.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bnd.MoveFirst();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bnd.MovePrevious();
        }

        private void cbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtIdSecteur.Text = cbxSecteur.SelectedValue.ToString();
        }

        private void TxtIdSecteur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbxSecteur.SelectedValue = int.Parse(TxtIdSecteur.Text);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
