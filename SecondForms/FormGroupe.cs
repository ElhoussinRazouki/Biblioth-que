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
    public partial class FormGroupe : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Groupe grp;
        public FormGroupe(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormGroupe_Load(object sender, EventArgs e)
        {
            bnd = new BindingSource();
            
            bnd.DataSource = db.Groupe.ToList();
            dataGridView1.DataSource = bnd;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            txtIDGroupe.DataBindings.Add("text", bnd, "IdGroupe", true);
            TxtIdFiliere.DataBindings.Add("text", bnd, "IdFiliere", true);
            txtNomGroupe.DataBindings.Add("text", bnd, "NomGroupe", true);
            txtIDGroupe.Enabled = false;
            cbxFiliere.DataSource = db.Filiere.ToList();
            cbxFiliere.DisplayMember = "NomFiliere";
            cbxFiliere.ValueMember = "IdFiliere";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtIDGroupe.Text = Convert.ToString((db.Groupe.Select(item => item.IdGroupe).Max() + 1));
            }
            catch (Exception)
            {}
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grp = db.Groupe.Find(int.Parse(txtIDGroupe.Text));
            grp.NomGroupe = txtNomGroupe.Text;
            grp.IdFiliere = int.Parse(TxtIdFiliere.Text);
            db.SaveChanges();
            bnd.DataSource = db.Groupe.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            grp = new Groupe();
            grp = db.Groupe.Find(int.Parse(txtIDGroupe.Text));
            db.Groupe.Remove(grp);
            db.SaveChanges();
            bnd.DataSource = db.Groupe.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grp = new Groupe(int.Parse(txtIDGroupe.Text), txtNomGroupe.Text, int.Parse(TxtIdFiliere.Text));
            db.Groupe.Add(grp);
            db.SaveChanges();
            bnd.DataSource = db.Groupe.ToList();
            MessageBox.Show("Votre Ligne est affecte");
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

        private void TxtIdFiliere_TextChanged(object sender, EventArgs e)
        {
            try
            {               
                    if (TxtIdFiliere.Text != "")
                        cbxFiliere.SelectedValue = int.Parse(TxtIdFiliere.Text);
            }
            catch (Exception)
            {

                
            }
        }

        private void cbxFiliere_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxFiliere.SelectedValue.ToString() != "")
                    TxtIdFiliere.Text = cbxFiliere.SelectedValue.ToString();
            }
            catch (Exception )
            {     
            }
        }
    }
}
