using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration ;
using System.Configuration.Assemblies;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace Bibliothèque
{
    public partial class Form1 :Form
    {
        BibliothèqueEntities db;
        

        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //db = new BibliothèqueEntities();
            //if (checkDBexists() != true)
            //{
            //    loadDB();
            //}
        }
        public Boolean checkDBexists()
        {
            SqlConnection cnx = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from master.sys.databases where name like 'Bibliothèque'", cnx);
            Boolean exists = false;
            cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            exists = dr.HasRows;
            cnx.Close();
            return exists;
           


        }
        public void loadDB()
        {
            
            Configuration confige = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            confige.ConnectionStrings.ConnectionStrings.Remove("BibliothèqueEntities");
            confige.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("BibliothèqueEntities", "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DataBase\\Bibliothèque.mdf;initial catalog=Bibliothèque;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;", "System.Data.EntityClient"));
            confige.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DataBase\\Bibliothèque.mdf;initial catalog=Bibliothèque;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;");
        }
       

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.guna2ToggleSwitch1.Checked==true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin" && txtPassword.Text == "admin")
            {
                new FormHome().Show();

            }
            else
            {
                if (db.Stagiaire.Where(item => item.EmailStagiaire == txtEmail.Text && item.PasswordStagiaire == txtPassword.Text).ToList().Count() == 1)
                {
                    List<Stagiaire> str = db.Stagiaire.Where(item => item.EmailStagiaire == txtEmail.Text && item.PasswordStagiaire == txtPassword.Text).ToList();
                    new FormAfiichageLivre(str[0]).Show();
                }

            }
            
           
        }

        
    }
}
