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
    public partial class FormReporting : Form
    {
        
        DataSet1 dta ;
        public FormReporting(Array reportStr)
        {
            InitializeComponent();
            
            dta = new DataSet1( );

            foreach (Emprinte item in reportStr)
            {
                DataRow rowempr = dta.Tables[0].NewRow();
                rowempr[0] = item.IdSagiaire;
                rowempr[1] = item.Stagiaire;
                rowempr[2] = item.Stagiaire.Groupe.Filiere;
                rowempr[3] = item.Stagiaire.Groupe;
                rowempr[4] = item.DateEmprinte;
                rowempr[5] = item.Livre.Ouvrage.TitreOuvrage;
                dta.Tables[0].Rows.Add(rowempr);

            }
            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(dta.Tables["report"]);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();
        }
        public FormReporting(Array reportsinglStr,int test)
        {
            InitializeComponent();
            dta = new DataSet1( );

            foreach (Emprinte item in reportsinglStr)
            {
                DataRow rowempr = dta.Tables[1].NewRow();
                rowempr[0] = item.IdSagiaire;
                rowempr[1] = item.Stagiaire.NomStagiaire;
                rowempr[2] = item.Stagiaire.PrenomStagiaire;
                rowempr[3] = item.Livre.IspnLivre;
                rowempr[4] = item.Livre.Ouvrage.PrixOuvrage;
                
                dta.Tables[1].Rows.Add(rowempr);

            }
            CrystalReport2 cr2 = new CrystalReport2();
            cr2.SetDataSource(dta.Tables["StagiaireReport"]);
            crystalReportViewer1.ReportSource = cr2;
            
        }

        private void FormReporting_Load(object sender, EventArgs e)
        {
            
        }
    }
}
