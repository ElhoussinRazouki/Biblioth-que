
namespace Bibliothèque.SecondForms
{
    partial class FormFiltrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltrage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIspn = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.bntConfirme = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.labelLivrePerdu = new System.Windows.Forms.Label();
            this.labelLivreRetourné = new System.Windows.Forms.Label();
            this.labelLivreSorti = new System.Windows.Forms.Label();
            this.labelTotalLivre = new System.Windows.Forms.Label();
            this.labelTotalOuvrage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radiobtnManual = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.panelDatManual = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DtPickerDexiem = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtPickerPremier = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtnAuto = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cbxDateStock = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalLivres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PanelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.panelDatManual.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIspn
            // 
            this.txtIspn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIspn.Animated = true;
            this.txtIspn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.txtIspn.BorderRadius = 8;
            this.txtIspn.BorderThickness = 2;
            this.txtIspn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIspn.DefaultText = "";
            this.txtIspn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIspn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIspn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIspn.DisabledState.Parent = this.txtIspn;
            this.txtIspn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIspn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIspn.FocusedState.Parent = this.txtIspn;
            this.txtIspn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtIspn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIspn.HoverState.Parent = this.txtIspn;
            this.txtIspn.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtIspn.IconLeft")));
            this.txtIspn.IconLeftOffset = new System.Drawing.Point(0, 1);
            this.txtIspn.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtIspn.Location = new System.Drawing.Point(15, 27);
            this.txtIspn.Name = "txtIspn";
            this.txtIspn.PasswordChar = '\0';
            this.txtIspn.PlaceholderText = "Nom Stagiaire...";
            this.txtIspn.SelectedText = "";
            this.txtIspn.ShadowDecoration.Parent = this.txtIspn;
            this.txtIspn.Size = new System.Drawing.Size(523, 36);
            this.txtIspn.TabIndex = 1;
            this.txtIspn.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button1);
            this.guna2CustomGradientPanel1.Controls.Add(this.bntConfirme);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2DataGridView1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 68);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(526, 411);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(279, 369);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 39);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Livre Est Perdu";
            this.guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // bntConfirme
            // 
            this.bntConfirme.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntConfirme.BorderRadius = 8;
            this.bntConfirme.CheckedState.Parent = this.bntConfirme;
            this.bntConfirme.CustomImages.Parent = this.bntConfirme;
            this.bntConfirme.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntConfirme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntConfirme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntConfirme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntConfirme.DisabledState.Parent = this.bntConfirme;
            this.bntConfirme.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.bntConfirme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bntConfirme.ForeColor = System.Drawing.Color.White;
            this.bntConfirme.HoverState.Parent = this.bntConfirme;
            this.bntConfirme.Location = new System.Drawing.Point(51, 369);
            this.bntConfirme.Name = "bntConfirme";
            this.bntConfirme.ShadowDecoration.Parent = this.bntConfirme;
            this.bntConfirme.Size = new System.Drawing.Size(180, 39);
            this.bntConfirme.TabIndex = 3;
            this.bntConfirme.Text = "Confirmé Le Roteur";
            this.bntConfirme.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.bntConfirme.Click += new System.EventHandler(this.bntConfirme_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(520, 363);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            // 
            // reporterToolStripMenuItem
            // 
            this.reporterToolStripMenuItem.Name = "reporterToolStripMenuItem";
            this.reporterToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.reporterToolStripMenuItem.Text = "Reporter";
            this.reporterToolStripMenuItem.Click += new System.EventHandler(this.reporterToolStripMenuItem_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.BorderThickness = 2;
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2Button2);
            this.guna2CustomGradientPanel2.Controls.Add(this.labelLivrePerdu);
            this.guna2CustomGradientPanel2.Controls.Add(this.labelLivreRetourné);
            this.guna2CustomGradientPanel2.Controls.Add(this.labelLivreSorti);
            this.guna2CustomGradientPanel2.Controls.Add(this.labelTotalLivre);
            this.guna2CustomGradientPanel2.Controls.Add(this.labelTotalOuvrage);
            this.guna2CustomGradientPanel2.Controls.Add(this.label4);
            this.guna2CustomGradientPanel2.Controls.Add(this.radiobtnManual);
            this.guna2CustomGradientPanel2.Controls.Add(this.panelDatManual);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.Controls.Add(this.radiobtnAuto);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbxDateStock);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2ComboBox1);
            this.guna2CustomGradientPanel2.Controls.Add(this.label9);
            this.guna2CustomGradientPanel2.Controls.Add(this.label8);
            this.guna2CustomGradientPanel2.Controls.Add(this.label7);
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblTotalLivres);
            this.guna2CustomGradientPanel2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(545, 69);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel2.ShadowDecoration.Enabled = true;
            this.guna2CustomGradientPanel2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(240, 410);
            this.guna2CustomGradientPanel2.TabIndex = 3;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(27, 367);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(180, 39);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Afficher Raport";
            this.guna2Button2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // labelLivrePerdu
            // 
            this.labelLivrePerdu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLivrePerdu.AutoSize = true;
            this.labelLivrePerdu.BackColor = System.Drawing.Color.White;
            this.labelLivrePerdu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivrePerdu.ForeColor = System.Drawing.Color.Black;
            this.labelLivrePerdu.Location = new System.Drawing.Point(120, 334);
            this.labelLivrePerdu.Name = "labelLivrePerdu";
            this.labelLivrePerdu.Size = new System.Drawing.Size(21, 19);
            this.labelLivrePerdu.TabIndex = 13;
            this.labelLivrePerdu.Text = "0 ";
            // 
            // labelLivreRetourné
            // 
            this.labelLivreRetourné.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLivreRetourné.AutoSize = true;
            this.labelLivreRetourné.BackColor = System.Drawing.Color.White;
            this.labelLivreRetourné.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivreRetourné.ForeColor = System.Drawing.Color.Black;
            this.labelLivreRetourné.Location = new System.Drawing.Point(174, 313);
            this.labelLivreRetourné.Name = "labelLivreRetourné";
            this.labelLivreRetourné.Size = new System.Drawing.Size(21, 19);
            this.labelLivreRetourné.TabIndex = 12;
            this.labelLivreRetourné.Text = "0 ";
            // 
            // labelLivreSorti
            // 
            this.labelLivreSorti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLivreSorti.AutoSize = true;
            this.labelLivreSorti.BackColor = System.Drawing.Color.White;
            this.labelLivreSorti.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivreSorti.ForeColor = System.Drawing.Color.Black;
            this.labelLivreSorti.Location = new System.Drawing.Point(115, 290);
            this.labelLivreSorti.Name = "labelLivreSorti";
            this.labelLivreSorti.Size = new System.Drawing.Size(21, 19);
            this.labelLivreSorti.TabIndex = 11;
            this.labelLivreSorti.Text = "0 ";
            // 
            // labelTotalLivre
            // 
            this.labelTotalLivre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalLivre.AutoSize = true;
            this.labelTotalLivre.BackColor = System.Drawing.Color.White;
            this.labelTotalLivre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLivre.ForeColor = System.Drawing.Color.Black;
            this.labelTotalLivre.Location = new System.Drawing.Point(96, 43);
            this.labelTotalLivre.Name = "labelTotalLivre";
            this.labelTotalLivre.Size = new System.Drawing.Size(21, 19);
            this.labelTotalLivre.TabIndex = 10;
            this.labelTotalLivre.Text = "0 ";
            // 
            // labelTotalOuvrage
            // 
            this.labelTotalOuvrage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalOuvrage.AutoSize = true;
            this.labelTotalOuvrage.BackColor = System.Drawing.Color.White;
            this.labelTotalOuvrage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOuvrage.ForeColor = System.Drawing.Color.Black;
            this.labelTotalOuvrage.Location = new System.Drawing.Point(115, 22);
            this.labelTotalOuvrage.Name = "labelTotalOuvrage";
            this.labelTotalOuvrage.Size = new System.Drawing.Size(21, 19);
            this.labelTotalOuvrage.TabIndex = 9;
            this.labelTotalOuvrage.Text = "0 ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "date Manual";
            // 
            // radiobtnManual
            // 
            this.radiobtnManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtnManual.BackColor = System.Drawing.Color.White;
            this.radiobtnManual.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.radiobtnManual.CheckedState.BorderThickness = 1;
            this.radiobtnManual.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.radiobtnManual.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiobtnManual.CheckedState.Parent = this.radiobtnManual;
            this.radiobtnManual.Location = new System.Drawing.Point(119, 144);
            this.radiobtnManual.Name = "radiobtnManual";
            this.radiobtnManual.ShadowDecoration.Parent = this.radiobtnManual;
            this.radiobtnManual.Size = new System.Drawing.Size(20, 20);
            this.radiobtnManual.TabIndex = 7;
            this.radiobtnManual.Text = "RadioButtonManual";
            this.radiobtnManual.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.radiobtnManual.UncheckedState.BorderThickness = 2;
            this.radiobtnManual.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiobtnManual.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radiobtnManual.UncheckedState.Parent = this.radiobtnManual;
            this.radiobtnManual.CheckedChanged += new System.EventHandler(this.radiobtnManual_CheckedChanged);
            // 
            // panelDatManual
            // 
            this.panelDatManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatManual.BorderColor = System.Drawing.Color.DimGray;
            this.panelDatManual.BorderRadius = 8;
            this.panelDatManual.BorderThickness = 2;
            this.panelDatManual.Controls.Add(this.DtPickerDexiem);
            this.panelDatManual.Controls.Add(this.DtPickerPremier);
            this.panelDatManual.Controls.Add(this.label6);
            this.panelDatManual.Controls.Add(this.label5);
            this.panelDatManual.Location = new System.Drawing.Point(5, 153);
            this.panelDatManual.Name = "panelDatManual";
            this.panelDatManual.ShadowDecoration.Parent = this.panelDatManual;
            this.panelDatManual.Size = new System.Drawing.Size(222, 134);
            this.panelDatManual.TabIndex = 4;
            // 
            // DtPickerDexiem
            // 
            this.DtPickerDexiem.BorderRadius = 6;
            this.DtPickerDexiem.Checked = true;
            this.DtPickerDexiem.CheckedState.Parent = this.DtPickerDexiem;
            this.DtPickerDexiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.DtPickerDexiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtPickerDexiem.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtPickerDexiem.HoverState.Parent = this.DtPickerDexiem;
            this.DtPickerDexiem.Location = new System.Drawing.Point(14, 91);
            this.DtPickerDexiem.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtPickerDexiem.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtPickerDexiem.Name = "DtPickerDexiem";
            this.DtPickerDexiem.ShadowDecoration.Parent = this.DtPickerDexiem;
            this.DtPickerDexiem.Size = new System.Drawing.Size(190, 29);
            this.DtPickerDexiem.TabIndex = 10;
            this.DtPickerDexiem.Value = new System.DateTime(2022, 1, 27, 18, 55, 1, 220);
            this.DtPickerDexiem.ValueChanged += new System.EventHandler(this.DtPickerDexiem_ValueChanged);
            // 
            // DtPickerPremier
            // 
            this.DtPickerPremier.BorderRadius = 6;
            this.DtPickerPremier.Checked = true;
            this.DtPickerPremier.CheckedState.Parent = this.DtPickerPremier;
            this.DtPickerPremier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.DtPickerPremier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtPickerPremier.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtPickerPremier.HoverState.Parent = this.DtPickerPremier;
            this.DtPickerPremier.Location = new System.Drawing.Point(15, 42);
            this.DtPickerPremier.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtPickerPremier.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtPickerPremier.Name = "DtPickerPremier";
            this.DtPickerPremier.ShadowDecoration.Parent = this.DtPickerPremier;
            this.DtPickerPremier.Size = new System.Drawing.Size(190, 29);
            this.DtPickerPremier.TabIndex = 9;
            this.DtPickerPremier.Value = new System.DateTime(2022, 1, 27, 18, 55, 1, 220);
            this.DtPickerPremier.ValueChanged += new System.EventHandler(this.DtPickerPremier_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = " à  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Commencé à Partir de :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "date stock";
            // 
            // radiobtnAuto
            // 
            this.radiobtnAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtnAuto.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.radiobtnAuto.CheckedState.BorderThickness = 1;
            this.radiobtnAuto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.radiobtnAuto.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiobtnAuto.CheckedState.Parent = this.radiobtnAuto;
            this.radiobtnAuto.Location = new System.Drawing.Point(100, 74);
            this.radiobtnAuto.Name = "radiobtnAuto";
            this.radiobtnAuto.ShadowDecoration.Parent = this.radiobtnAuto;
            this.radiobtnAuto.Size = new System.Drawing.Size(20, 20);
            this.radiobtnAuto.TabIndex = 5;
            this.radiobtnAuto.Text = "RadioButtonStocke";
            this.radiobtnAuto.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.radiobtnAuto.UncheckedState.BorderThickness = 2;
            this.radiobtnAuto.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiobtnAuto.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radiobtnAuto.UncheckedState.Parent = this.radiobtnAuto;
            this.radiobtnAuto.CheckedChanged += new System.EventHandler(this.guna2CustomRadioButton1_CheckedChanged);
            // 
            // cbxDateStock
            // 
            this.cbxDateStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDateStock.BackColor = System.Drawing.Color.Transparent;
            this.cbxDateStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.cbxDateStock.BorderRadius = 8;
            this.cbxDateStock.BorderThickness = 2;
            this.cbxDateStock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDateStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDateStock.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDateStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDateStock.FocusedState.Parent = this.cbxDateStock;
            this.cbxDateStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbxDateStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDateStock.HoverState.Parent = this.cbxDateStock;
            this.cbxDateStock.ItemHeight = 30;
            this.cbxDateStock.Items.AddRange(new object[] {
            "aujourd\'hui",
            "avant une semaine",
            "avant une mois"});
            this.cbxDateStock.ItemsAppearance.Parent = this.cbxDateStock;
            this.cbxDateStock.Location = new System.Drawing.Point(8, 99);
            this.cbxDateStock.Name = "cbxDateStock";
            this.cbxDateStock.ShadowDecoration.Parent = this.cbxDateStock;
            this.cbxDateStock.Size = new System.Drawing.Size(210, 36);
            this.cbxDateStock.TabIndex = 4;
            this.cbxDateStock.SelectedIndexChanged += new System.EventHandler(this.cbxDateStock_SelectedIndexChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(12, 88);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(0, 27);
            this.guna2ComboBox1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(26, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Livres Perdu:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(26, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Livres sont retourné:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(26, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "livres sortis :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Ouvrage :";
            // 
            // lblTotalLivres
            // 
            this.lblTotalLivres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLivres.AutoSize = true;
            this.lblTotalLivres.BackColor = System.Drawing.Color.White;
            this.lblTotalLivres.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLivres.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalLivres.Location = new System.Drawing.Point(8, 42);
            this.lblTotalLivres.Name = "lblTotalLivres";
            this.lblTotalLivres.Size = new System.Drawing.Size(94, 19);
            this.lblTotalLivres.TabIndex = 0;
            this.lblTotalLivres.Text = "Total Livres :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.DisabledState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(225)))), ((int)(((byte)(50)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(750, 3);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(18, 18);
            this.guna2CircleButton2.TabIndex = 10;
            this.guna2CircleButton2.Text = "guna2CircleButton2";
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.DisabledState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(773, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(18, 18);
            this.guna2CircleButton1.TabIndex = 9;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelHeader.Controls.Add(this.guna2CircleButton3);
            this.PanelHeader.Controls.Add(this.guna2CircleButton2);
            this.PanelHeader.Controls.Add(this.guna2CircleButton1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShadowDecoration.Parent = this.PanelHeader;
            this.PanelHeader.Size = new System.Drawing.Size(797, 25);
            this.PanelHeader.TabIndex = 11;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.DisabledState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(165)))), ((int)(((byte)(58)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(727, 3);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(18, 18);
            this.guna2CircleButton3.TabIndex = 11;
            this.guna2CircleButton3.Text = "guna2CircleButton3";
            this.guna2CircleButton3.Click += new System.EventHandler(this.guna2CircleButton3_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.PanelHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FormFiltrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 506);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.txtIspn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(797, 506);
            this.Name = "FormFiltrage";
            this.Text = "FiltrageEmprint";
            this.Load += new System.EventHandler(this.FormFiltrage_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.panelDatManual.ResumeLayout(false);
            this.panelDatManual.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtIspn;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radiobtnAuto;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDateStock;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalLivres;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button bntConfirme;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radiobtnManual;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelDatManual;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtPickerDexiem;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtPickerPremier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Panel PanelHeader;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label labelLivrePerdu;
        private System.Windows.Forms.Label labelLivreRetourné;
        private System.Windows.Forms.Label labelLivreSorti;
        private System.Windows.Forms.Label labelTotalLivre;
        private System.Windows.Forms.Label labelTotalOuvrage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporterToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}