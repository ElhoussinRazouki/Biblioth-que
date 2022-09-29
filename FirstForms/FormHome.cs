using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace Bibliothèque
{
    public partial class FormHome : Form
    {
        Guna2Button CurentButton;
        private Form currentForm;
        BibliothèqueEntities db;
        
        public FormHome()
        {
            InitializeComponent();
            db = new BibliothèqueEntities();
        }
        public void DesableButton()
        {
            if(CurentButton !=null)
            {
                CurentButton.FillColor = Color.FromArgb(0,154,156);
                CurentButton.ForeColor = Color.FromArgb(250, 250, 250);
            }
        }
        public void EnableButton(object btnsender)
        {
            DesableButton();
            CurentButton =(Guna2Button) btnsender;
   
            CurentButton.FillColor = Color.FromArgb(250, 250, 250);
            CurentButton.ForeColor = Color.FromArgb(0, 154, 156);

           
        }
        public void openForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(currentForm);
            panelDesktop.Tag = currentForm;
            currentForm.BringToFront();
            currentForm.Show();
        }

        private void btnLivre_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormLivre(db) );
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

 

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSecteur_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormSecteur(db));
        }

        private void btnFiliere_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormFiliere(db));
        }

        private void BtnGroupe_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormGroupe(db));
        }

        private void BtnStagiaire_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormStagiaire(db));
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormTheme(db));
        }

        private void BtnOUvrage_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormOuvrage(db));
        }

        private void BtnEmprinte_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            openForm(new FormEmprinte(db));
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            DesableButton();
        }
    }
}
