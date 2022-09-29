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
    public partial class FormOuvrage : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Ouvrage ovg;
        public FormOuvrage(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormOuvrage_Load(object sender, EventArgs e)
        {
            bnd = new BindingSource();
            
            bnd.DataSource = db.Ouvrage.ToList();
            dataGridView1.DataSource = bnd;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            txtIDOuvrage.DataBindings.Add("text", bnd, "IdOuvrage", true);
            txtIdSecteur.DataBindings.Add("text", bnd, "IdSecteur", true);
            txtIdTheme.DataBindings.Add("text", bnd, "IdTheme", true);
            txtTitreOuvrage.DataBindings.Add("text", bnd, "TitreOuvrage", true);
            txtPrixOuvrage.DataBindings.Add("text", bnd, "PrixOuvrage", true);
            TxtLieuOuvrage.DataBindings.Add("text", bnd, "LieuOuvrage", true);
            txtAuteurOuvrage.DataBindings.Add("text", bnd, "AuteurOuvrage", true);
            txtEditeurOuvrage.DataBindings.Add("text", bnd, "EditeurOuvrage", true);
            txtIDOuvrage.Enabled = false;
            cbxSecteur.DataSource = db.Secteur.ToList();
            cbxSecteur.DisplayMember = "nomSecteur";
            cbxSecteur.ValueMember = "IdSecteur";
            cbxTheme.DataSource = db.Theme.ToList();
            cbxTheme.DisplayMember = "nomTheme";
            cbxTheme.ValueMember = "IdTheme";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtIDOuvrage.Text = Convert.ToString((db.Ouvrage.Select(item => item.IdOuvrage).Max() + 1));
            }
            catch (Exception)
            {

                txtIDOuvrage.Text = "1";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ovg = new Ouvrage(int.Parse(txtIDOuvrage.Text), int.Parse(txtIdSecteur.Text), int.Parse(txtIdTheme.Text), txtTitreOuvrage.Text, double.Parse(txtPrixOuvrage.Text), TxtLieuOuvrage.Text, txtAuteurOuvrage.Text, txtEditeurOuvrage.Text);
                db.Ouvrage.Add(ovg);
                db.SaveChanges();
                bnd.DataSource = db.Ouvrage.ToList();
                MessageBox.Show("Votre Ligne est affecte");
            }
            catch (Exception)
            {

                MessageBox.Show("créer nouveau ligne apres saisie les donnees avec le button New Ou Verifie vous Donnees");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ovg = db.Ouvrage.Find(int.Parse(txtIDOuvrage.Text));
            ovg.IdSecteur = int.Parse(txtIdSecteur.Text);
            ovg.IdTheme = int.Parse(txtIdTheme.Text);
            ovg.TitreOuvrage = txtTitreOuvrage.Text;
            ovg.PrixOuvrage = double.Parse(txtPrixOuvrage.Text);
            ovg.LieuOuvrage = TxtLieuOuvrage.Text;
            ovg.AuteurOuvrage = txtAuteurOuvrage.Text;
            ovg.EditeurOuvrage = txtEditeurOuvrage.Text;
            db.SaveChanges();
            bnd.DataSource = db.Ouvrage.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ovg = new Ouvrage();
            ovg = db.Ouvrage.Find(int.Parse(txtIDOuvrage.Text));
            db.Ouvrage.Remove(ovg);
            db.SaveChanges();
            bnd.DataSource = db.Ouvrage.ToList();
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

        private void txtIdSecteur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxSecteur.Text.ToString() != "")
                    cbxSecteur.SelectedValue = int.Parse(txtIdSecteur.Text);
            }
            catch (Exception)
            {

            }
        }

        private void cbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*if(cbxOuvrage.SelectedValue.ToString() !="")*/
                txtIdSecteur.Text = cbxSecteur.SelectedValue.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void txtIdTheme_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTheme.Text.ToString() != "")
                    cbxTheme.SelectedValue = int.Parse(txtIdTheme.Text);
            }
            catch (Exception)
            {

            }
        }

        private void cbxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*if(cbxOuvrage.SelectedValue.ToString() !="")*/
                txtIdTheme.Text = cbxTheme.SelectedValue.ToString();
            }
            catch (Exception)
            {


            }
        }
    }
}
