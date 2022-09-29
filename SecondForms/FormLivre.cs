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
    public partial class FormLivre : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Livre lvr;
        public FormLivre(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormLivre_Load(object sender, EventArgs e)
        {
            bnd = new BindingSource();
            
            bnd.DataSource = db.Livre.ToList();
            
            dataGridView1.DataSource = bnd;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            txtIDLivre.DataBindings.Add("text", bnd, "IdLivre", true);
            txtISPN.DataBindings.Add("text", bnd, "IspnLivre", true);
            TxtEtat.DataBindings.Add("text", bnd, "EtatLivre", true);
            txtIdOuvrage.DataBindings.Add("text", bnd, "IdOuvrage", true);
            txtIDLivre.Enabled = false;
            cbxOuvrage.DataSource = db.Ouvrage.ToList();
            cbxOuvrage.DisplayMember = "TitreOuvrage";
            cbxOuvrage.ValueMember = "IdOuvrage";


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtIDLivre.Text = Convert.ToString((db.Livre.Select(item => item.IdLivre).Max() + 1));
                TxtEtat.Text = "Disponible";
            }
            catch (Exception)
            {
                txtIDLivre.Text = "1";


            }
           
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lvr = new Livre(int.Parse(txtIDLivre.Text), int.Parse(txtIdOuvrage.Text),txtISPN.Text,TxtEtat.Text);
            db.Livre.Add(lvr);
            db.SaveChanges();
            bnd.DataSource = db.Livre.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lvr = db.Livre.Find(int.Parse(txtIDLivre.Text));
            lvr.IspnLivre = txtISPN.Text;
            lvr.EtatLivre = TxtEtat.Text;
            lvr.IdOuvrage = int.Parse(txtIdOuvrage.Text);
            db.SaveChanges();
            bnd.DataSource = db.Livre.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lvr = new Livre();
            lvr = db.Livre.Find(int.Parse(txtIDLivre.Text));
            db.Livre.Remove(lvr);
            db.SaveChanges();
            bnd.DataSource = db.Livre.ToList();
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

        private void IdOuvrage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxOuvrage.Text.ToString() !="")
                    cbxOuvrage.SelectedValue = int.Parse(txtIdOuvrage.Text);
            }
            catch (Exception)
            {

            }
        }

        private void cbxOuvrage_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                /*if(cbxOuvrage.SelectedValue.ToString() !="")*/
                txtIdOuvrage.Text = cbxOuvrage.SelectedValue.ToString();
            }
            catch (Exception)
            {


            }

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void TxtEtat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bnd.DataSource = db.Livre.Where(item => item.IspnLivre.Contains(textBox1.Text)).ToList();
        }

        private void btnRecupiration_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtEtat.Text == "Perdu!")
                    TxtEtat.Text = "Disponible";
                else
                    MessageBox.Show("le livre non perdu");
            }
            catch (Exception)
            {

               
            }
        }
    }
}
