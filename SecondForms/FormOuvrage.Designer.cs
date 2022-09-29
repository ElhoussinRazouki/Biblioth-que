
namespace Bibliothèque
{
    partial class FormOuvrage
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
            this.txtPrixOuvrage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitreOuvrage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdTheme = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLieuOuvrage = new System.Windows.Forms.TextBox();
            this.txtIdSecteur = new System.Windows.Forms.TextBox();
            this.txtIDOuvrage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuteurOuvrage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditeurOuvrage = new System.Windows.Forms.TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbxSecteur = new System.Windows.Forms.ComboBox();
            this.cbxTheme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Prix :";
            // 
            // txtPrixOuvrage
            // 
            this.txtPrixOuvrage.Location = new System.Drawing.Point(581, 114);
            this.txtPrixOuvrage.Name = "txtPrixOuvrage";
            this.txtPrixOuvrage.Size = new System.Drawing.Size(214, 20);
            this.txtPrixOuvrage.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Titre  :";
            // 
            // txtTitreOuvrage
            // 
            this.txtTitreOuvrage.Location = new System.Drawing.Point(581, 88);
            this.txtTitreOuvrage.Name = "txtTitreOuvrage";
            this.txtTitreOuvrage.Size = new System.Drawing.Size(214, 20);
            this.txtTitreOuvrage.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Id Theme :";
            // 
            // txtIdTheme
            // 
            this.txtIdTheme.Enabled = false;
            this.txtIdTheme.Location = new System.Drawing.Point(582, 62);
            this.txtIdTheme.Name = "txtIdTheme";
            this.txtIdTheme.Size = new System.Drawing.Size(19, 20);
            this.txtIdTheme.TabIndex = 66;
            this.txtIdTheme.TextChanged += new System.EventHandler(this.txtIdTheme_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(43, 281);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 65;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(124, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 64;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 281);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 63;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(286, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 62;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(642, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(723, 222);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(561, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(480, 222);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 58;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Lieu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Id Secteur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id Ouvrage :";
            // 
            // TxtLieuOuvrage
            // 
            this.TxtLieuOuvrage.Location = new System.Drawing.Point(582, 145);
            this.TxtLieuOuvrage.Name = "TxtLieuOuvrage";
            this.TxtLieuOuvrage.Size = new System.Drawing.Size(214, 20);
            this.TxtLieuOuvrage.TabIndex = 54;
            // 
            // txtIdSecteur
            // 
            this.txtIdSecteur.Enabled = false;
            this.txtIdSecteur.Location = new System.Drawing.Point(582, 36);
            this.txtIdSecteur.Name = "txtIdSecteur";
            this.txtIdSecteur.Size = new System.Drawing.Size(19, 20);
            this.txtIdSecteur.TabIndex = 53;
            this.txtIdSecteur.TextChanged += new System.EventHandler(this.txtIdSecteur_TextChanged);
            // 
            // txtIDOuvrage
            // 
            this.txtIDOuvrage.Location = new System.Drawing.Point(582, 10);
            this.txtIDOuvrage.Name = "txtIDOuvrage";
            this.txtIDOuvrage.Size = new System.Drawing.Size(213, 20);
            this.txtIDOuvrage.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 247);
            this.dataGridView1.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Auteur :";
            // 
            // txtAuteurOuvrage
            // 
            this.txtAuteurOuvrage.Location = new System.Drawing.Point(581, 171);
            this.txtAuteurOuvrage.Name = "txtAuteurOuvrage";
            this.txtAuteurOuvrage.Size = new System.Drawing.Size(214, 20);
            this.txtAuteurOuvrage.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Editeur :";
            // 
            // txtEditeurOuvrage
            // 
            this.txtEditeurOuvrage.Location = new System.Drawing.Point(581, 197);
            this.txtEditeurOuvrage.Name = "txtEditeurOuvrage";
            this.txtEditeurOuvrage.Size = new System.Drawing.Size(214, 20);
            this.txtEditeurOuvrage.TabIndex = 74;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cbxSecteur
            // 
            this.cbxSecteur.FormattingEnabled = true;
            this.cbxSecteur.Location = new System.Drawing.Point(607, 35);
            this.cbxSecteur.Name = "cbxSecteur";
            this.cbxSecteur.Size = new System.Drawing.Size(188, 21);
            this.cbxSecteur.TabIndex = 76;
            this.cbxSecteur.SelectedIndexChanged += new System.EventHandler(this.cbxSecteur_SelectedIndexChanged);
            // 
            // cbxTheme
            // 
            this.cbxTheme.FormattingEnabled = true;
            this.cbxTheme.Location = new System.Drawing.Point(607, 61);
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(188, 21);
            this.cbxTheme.TabIndex = 76;
            this.cbxTheme.SelectedIndexChanged += new System.EventHandler(this.cbxTheme_SelectedIndexChanged);
            // 
            // FormOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 379);
            this.Controls.Add(this.cbxTheme);
            this.Controls.Add(this.cbxSecteur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEditeurOuvrage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAuteurOuvrage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrixOuvrage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitreOuvrage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdTheme);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtLieuOuvrage);
            this.Controls.Add(this.txtIdSecteur);
            this.Controls.Add(this.txtIDOuvrage);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOuvrage";
            this.Text = "FormOuvrage";
            this.Load += new System.EventHandler(this.FormOuvrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrixOuvrage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitreOuvrage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdTheme;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLieuOuvrage;
        private System.Windows.Forms.TextBox txtIdSecteur;
        private System.Windows.Forms.TextBox txtIDOuvrage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAuteurOuvrage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditeurOuvrage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ComboBox cbxTheme;
        private System.Windows.Forms.ComboBox cbxSecteur;
    }
}