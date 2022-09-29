
namespace Bibliothèque
{
    partial class FormEmprinte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateRoteur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatEmprint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdLivre = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdStagiaire = new System.Windows.Forms.TextBox();
            this.txtIdEmprinte = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbxStagiaire = new System.Windows.Forms.ComboBox();
            this.cbxIspnLivre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Date Roteur :";
            // 
            // txtDateRoteur
            // 
            this.txtDateRoteur.Enabled = false;
            this.txtDateRoteur.Location = new System.Drawing.Point(518, 114);
            this.txtDateRoteur.Name = "txtDateRoteur";
            this.txtDateRoteur.Size = new System.Drawing.Size(214, 20);
            this.txtDateRoteur.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Date Emprunt  :";
            // 
            // txtDatEmprint
            // 
            this.txtDatEmprint.Location = new System.Drawing.Point(518, 88);
            this.txtDatEmprint.Name = "txtDatEmprint";
            this.txtDatEmprint.Size = new System.Drawing.Size(214, 20);
            this.txtDatEmprint.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "ISPN Livre :";
            // 
            // txtIdLivre
            // 
            this.txtIdLivre.Enabled = false;
            this.txtIdLivre.Location = new System.Drawing.Point(519, 62);
            this.txtIdLivre.Name = "txtIdLivre";
            this.txtIdLivre.Size = new System.Drawing.Size(23, 20);
            this.txtIdLivre.TabIndex = 91;
            this.txtIdLivre.TextChanged += new System.EventHandler(this.txtIdLivre_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 251);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 90;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(125, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 89;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(227, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 88;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(332, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 87;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(413, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Text = "Confirmation";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(659, 150);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 85;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(533, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 84;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(416, 150);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 83;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Id Stagiaire :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Id Emprunt :";
            // 
            // txtIdStagiaire
            // 
            this.txtIdStagiaire.Enabled = false;
            this.txtIdStagiaire.Location = new System.Drawing.Point(519, 36);
            this.txtIdStagiaire.Name = "txtIdStagiaire";
            this.txtIdStagiaire.Size = new System.Drawing.Size(23, 20);
            this.txtIdStagiaire.TabIndex = 78;
            this.txtIdStagiaire.TextChanged += new System.EventHandler(this.txtIdStagiaire_TextChanged);
            // 
            // txtIdEmprinte
            // 
            this.txtIdEmprinte.Location = new System.Drawing.Point(519, 10);
            this.txtIdEmprinte.Name = "txtIdEmprinte";
            this.txtIdEmprinte.Size = new System.Drawing.Size(214, 20);
            this.txtIdEmprinte.TabIndex = 77;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(395, 233);
            this.dataGridView1.TabIndex = 76;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cbxStagiaire
            // 
            this.cbxStagiaire.FormattingEnabled = true;
            this.cbxStagiaire.Location = new System.Drawing.Point(548, 35);
            this.cbxStagiaire.Name = "cbxStagiaire";
            this.cbxStagiaire.Size = new System.Drawing.Size(186, 21);
            this.cbxStagiaire.TabIndex = 97;
            this.cbxStagiaire.SelectedIndexChanged += new System.EventHandler(this.cbxStagiaire_SelectedIndexChanged);
            // 
            // cbxIspnLivre
            // 
            this.cbxIspnLivre.FormattingEnabled = true;
            this.cbxIspnLivre.Location = new System.Drawing.Point(548, 61);
            this.cbxIspnLivre.Name = "cbxIspnLivre";
            this.cbxIspnLivre.Size = new System.Drawing.Size(186, 21);
            this.cbxIspnLivre.TabIndex = 98;
            this.cbxIspnLivre.SelectedIndexChanged += new System.EventHandler(this.cbxIspnLivre_SelectedIndexChanged);
            // 
            // FormEmprinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 323);
            this.Controls.Add(this.cbxIspnLivre);
            this.Controls.Add(this.cbxStagiaire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDateRoteur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatEmprint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdLivre);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdStagiaire);
            this.Controls.Add(this.txtIdEmprinte);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmprinte";
            this.Text = "FormEmprinte";
            this.Load += new System.EventHandler(this.FormEmprinte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateRoteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatEmprint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdLivre;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdStagiaire;
        private System.Windows.Forms.TextBox txtIdEmprinte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ComboBox cbxIspnLivre;
        private System.Windows.Forms.ComboBox cbxStagiaire;
    }
}