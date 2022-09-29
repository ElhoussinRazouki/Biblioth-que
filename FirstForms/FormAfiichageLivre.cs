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
    public partial class FormAfiichageLivre : Form
    {
        BibliothèqueEntities db;
        Stagiaire strr;
        public FormAfiichageLivre(Stagiaire str)
        {
            InitializeComponent();
            str = strr;
        }

        private void FormAfiichageLivre_Load(object sender, EventArgs e)
        {
            db = new BibliothèqueEntities();
            //comboBox1.DataSource = db.Theme.ToList();
            //comboBox1.DisplayMember = "NomTheme";
            //comboBox1.ValueMember = "IdTheme";
            DataGridView1.DataSource = db.Ouvrage.Select(item => new { item.IdOuvrage, item.TitreOuvrage, item.LieuOuvrage, item.Theme  }).ToList();
            comboBoxSecteur.DataSource = db.Secteur.ToList();
            comboBoxSecteur.DisplayMember = "NomSecteur";
            comboBoxSecteur.ValueMember = "IdSecteur";
            comboBoxTheme.DataSource = db.Theme.ToList();
            comboBoxTheme.DisplayMember = "NomTheme";
            comboBoxTheme.ValueMember = "IdTheme";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                DataGridView1.DataSource = db.Ouvrage.Where(item => item.TitreOuvrage.Contains(textBox1.Text)).Select(item => new { item.IdOuvrage, item.TitreOuvrage, item.LieuOuvrage, item.Theme }).ToList();
            }
            catch (Exception)
            {

                
            }
           
        }

        private void comboBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataGridView1.DataSource = db.Ouvrage.Where(item => item.Theme.NomTheme==comboBoxTheme.Text && item.Secteur.NomSecteur==comboBoxSecteur.Text).Select(item => new { item.IdOuvrage, item.TitreOuvrage, item.LieuOuvrage, item.Theme }).ToList();
            }
            catch (Exception)
            {


            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
            
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataGridView1.DataSource = db.Ouvrage.Where(item => item.Theme.NomTheme == comboBoxTheme.Text && item.Secteur.NomSecteur == comboBoxSecteur.Text).Select(item => new { item.IdOuvrage, item.TitreOuvrage, item.LieuOuvrage, item.Theme }).ToList();
            }
            catch (Exception)
            {


            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idOuvrage = int.Parse(DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (db.Livre.Where(item => item.EtatLivre == "Disponible" && item.IdOuvrage == idOuvrage).Count() > 0)
            {
                btnEtat.FillColor = System.Drawing.Color.FromArgb(0, 175, 23);
                btnEtat.Text = "Disponible";
                btnEtat.Enabled = true;


            }
            else
            {
                btnEtat.FillColor = System.Drawing.Color.FromArgb(203, 43, 1);
                btnEtat.Text = "Indisponible";
                btnEtat.Enabled = true;
            }
        }
    }
}
