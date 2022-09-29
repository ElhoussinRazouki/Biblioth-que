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
    public partial class FormTheme : Form
    {
        BibliothèqueEntities db;
        BindingSource bnd;
        Theme thm;
        public FormTheme(BibliothèqueEntities dbo)
        {
            InitializeComponent();
            db = dbo;
        }

        private void FormTheme_Load(object sender, EventArgs e)
        {
            
            bnd = new BindingSource();
            bnd.DataSource = db.Theme.ToList();
            dataGridView1.DataSource = bnd;
            txtId.DataBindings.Add("text", bnd, "IdTheme", true);
            txtNom.DataBindings.Add("text", bnd, "NomTheme", true);
            txtId.Enabled = false;
            dataGridView1.Columns[2].Visible = false;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bnd.AddNew();
            try
            {
                txtId.Text = Convert.ToString((db.Theme.Select(item => item.IdTheme).Max() + 1));
            }
            catch (Exception)
            {
                txtId.Text = "1";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            thm = new Theme(int.Parse(txtId.Text), txtNom.Text);
            db.Theme.Add(thm);
            db.SaveChanges();
            bnd.DataSource = db.Theme.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            thm = db.Theme.Find(int.Parse(txtId.Text));
            thm.NomTheme = txtNom.Text;
            db.SaveChanges();
            bnd.DataSource = db.Theme.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            thm = new Theme();
            thm = db.Theme.Find(int.Parse(txtId.Text));
            db.Theme.Remove(thm);
            db.SaveChanges();
            bnd.DataSource = db.Theme.ToList();
        }
    }
}
