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
    public partial class FormStagiaire : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Stagiaire str;
        public FormStagiaire(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormStagiaire_Load(object sender, EventArgs e)
        {
            bnd = new BindingSource();
            
            bnd.DataSource = db.Stagiaire.ToList();
            dataGridView1.DataSource = bnd;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            txtIDStagiaire.DataBindings.Add("text", bnd, "IdStagiaire", true);
            TxtIdGroupe.DataBindings.Add("text", bnd, "IdFGroupe", true);
            txtPrenomStagiaire.DataBindings.Add("text", bnd, "PrenomStagiaire", true);
            txtEmail.DataBindings.Add("text", bnd, "EmailStagiaire", true);
            txtPassword.DataBindings.Add("text", bnd, "PasswordStagiaire", true);
            txtNomStagiaire.DataBindings.Add("text", bnd, "NomStagiaire", true);
            txtIDStagiaire.Enabled = false;
            cbxGroup.DataSource = db.Groupe.ToList();
            cbxGroup.DisplayMember = "NomGroupe";
            cbxGroup.ValueMember = "IdGroupe";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtIDStagiaire.Text = Convert.ToString((db.Stagiaire.Select(item => item.IdStagiaire).Max() + 1));
            }
            catch (Exception)
            {
                txtIDStagiaire.Text = "1";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            str = new Stagiaire(int.Parse(txtIDStagiaire.Text), txtNomStagiaire.Text, txtPrenomStagiaire.Text, txtEmail.Text, txtPassword.Text, int.Parse(TxtIdGroupe.Text));
            db.Stagiaire.Add(str);
            db.SaveChanges();
            bnd.DataSource = db.Stagiaire.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            str = db.Stagiaire.Find(int.Parse(txtIDStagiaire.Text));
            str.NomStagiaire = txtNomStagiaire.Text;
            str.PrenomStagiaire = txtPrenomStagiaire.Text;
            str.EmailStagiaire = txtEmail.Text;
            str.PasswordStagiaire = txtPassword.Text;
            str.IdFGroupe = int.Parse(TxtIdGroupe.Text);
            db.SaveChanges();
            bnd.DataSource = db.Stagiaire.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            str = new Stagiaire();
            str = db.Stagiaire.Find(int.Parse(txtIDStagiaire.Text));
            db.Stagiaire.Remove(str);
            db.SaveChanges();
            bnd.DataSource = db.Stagiaire.ToList();
        }

        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            bnd.DataSource = db.Stagiaire.Where(p => p.NomStagiaire.Contains(guna2TextBox1.Text)).ToList();
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

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //MessageBox.Show(comboBoxGroup.SelectedValue.ToString());
            //    TxtIdGroupe.Text = comboBoxGroup.SelectedValue.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
               
            //}
        }

        private void TxtIdGroupe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtIdGroupe.Text != "")
                    cbxGroup.SelectedValue = int.Parse(TxtIdGroupe.Text);
            }
            catch (Exception)
            {

                
            }
        }

        private void cbxGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxGroup.SelectedValue.ToString() != "")
                    TxtIdGroupe.Text = cbxGroup.SelectedValue.ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void txtNomStagiaire_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtPrenomStagiaire_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.Text = txtNomStagiaire.Text + "." + txtPrenomStagiaire.Text + "@gmail.com";
                txtPassword.Text = txtNomStagiaire.Text + txtNomStagiaire.Text;
            }
            catch (Exception)
            {


            }
        }
    }
}
