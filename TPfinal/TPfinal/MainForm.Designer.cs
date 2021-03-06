﻿namespace TPfinal
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STRIP_AjouterMonument = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirMeilleurCircuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.circuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TAB_Monuments = new System.Windows.Forms.TabPage();
            this.dgvMonumentsCircuits = new System.Windows.Forms.DataGridView();
            this.NomCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdreDansCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMonuments = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Histoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etoiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox10 = new System.Windows.Forms.GroupBox();
            this.cbxStarsMonument = new System.Windows.Forms.CheckBox();
            this.starsMonument = new EvaluationDemo.Stars();
            this.TAB_Circuits = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxPrix = new System.Windows.Forms.CheckBox();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMonument = new System.Windows.Forms.ComboBox();
            this.dgvCircuits = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxVille = new System.Windows.Forms.ComboBox();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.fbtnMeilleurCircuit = new PhotoManagerClient.FlashButton();
            this.fbtnImage = new PhotoManagerClient.FlashButton();
            this.FBTN_AddMonument = new PhotoManagerClient.FlashButton();
            this.fbtnInformations = new PhotoManagerClient.FlashButton();
            this.fbtnEffacer = new PhotoManagerClient.FlashButton();
            this.fbtnModifier = new PhotoManagerClient.FlashButton();
            this.fbtnAjouter = new PhotoManagerClient.FlashButton();
            this.menuStrip1.SuspendLayout();
            this.TAB_Monuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonumentsCircuits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonuments)).BeginInit();
            this.groupbox10.SuspendLayout();
            this.TAB_Circuits.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCircuits)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // monumentToolStripMenuItem
            // 
            this.monumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STRIP_AjouterMonument,
            this.afficherImageToolStripMenuItem,
            this.voirMeilleurCircuitToolStripMenuItem});
            this.monumentToolStripMenuItem.Name = "monumentToolStripMenuItem";
            this.monumentToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.monumentToolStripMenuItem.Text = "Monuments";
            // 
            // STRIP_AjouterMonument
            // 
            this.STRIP_AjouterMonument.Image = global::TPfinal.Properties.Resources.Tower_Add_Neutral;
            this.STRIP_AjouterMonument.Name = "STRIP_AjouterMonument";
            this.STRIP_AjouterMonument.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.STRIP_AjouterMonument.Size = new System.Drawing.Size(355, 30);
            this.STRIP_AjouterMonument.Text = "Ajouter";
            this.STRIP_AjouterMonument.Click += new System.EventHandler(this.STRIP_AjouterMonument_Click);
            // 
            // afficherImageToolStripMenuItem
            // 
            this.afficherImageToolStripMenuItem.Image = global::TPfinal.Properties.Resources.Eye;
            this.afficherImageToolStripMenuItem.Name = "afficherImageToolStripMenuItem";
            this.afficherImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.afficherImageToolStripMenuItem.Size = new System.Drawing.Size(355, 30);
            this.afficherImageToolStripMenuItem.Text = "Afficher image";
            this.afficherImageToolStripMenuItem.Click += new System.EventHandler(this.afficherImageToolStripMenuItem_Click);
            // 
            // voirMeilleurCircuitToolStripMenuItem
            // 
            this.voirMeilleurCircuitToolStripMenuItem.Image = global::TPfinal.Properties.Resources.meilleur_circuit_nouveau;
            this.voirMeilleurCircuitToolStripMenuItem.Name = "voirMeilleurCircuitToolStripMenuItem";
            this.voirMeilleurCircuitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.voirMeilleurCircuitToolStripMenuItem.Size = new System.Drawing.Size(355, 30);
            this.voirMeilleurCircuitToolStripMenuItem.Text = "Voir meilleur circuit";
            this.voirMeilleurCircuitToolStripMenuItem.Click += new System.EventHandler(this.voirMeilleurCircuitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuitToolStripMenuItem,
            this.monumentToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // circuitToolStripMenuItem
            // 
            this.circuitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.voirInformationsToolStripMenuItem});
            this.circuitToolStripMenuItem.Name = "circuitToolStripMenuItem";
            this.circuitToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.circuitToolStripMenuItem.Text = "Circuits";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Image = global::TPfinal.Properties.Resources.circuit_add_neutre;
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::TPfinal.Properties.Resources.circuit_edit_neutre;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::TPfinal.Properties.Resources.circuit_delete_neutre;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // voirInformationsToolStripMenuItem
            // 
            this.voirInformationsToolStripMenuItem.Image = global::TPfinal.Properties.Resources.info_neutre;
            this.voirInformationsToolStripMenuItem.Name = "voirInformationsToolStripMenuItem";
            this.voirInformationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.voirInformationsToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.voirInformationsToolStripMenuItem.Text = "Voir informations";
            this.voirInformationsToolStripMenuItem.Click += new System.EventHandler(this.voirInformationsToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // TAB_Monuments
            // 
            this.TAB_Monuments.Controls.Add(this.dgvMonumentsCircuits);
            this.TAB_Monuments.Controls.Add(this.dgvMonuments);
            this.TAB_Monuments.Controls.Add(this.groupbox10);
            this.TAB_Monuments.Location = new System.Drawing.Point(4, 29);
            this.TAB_Monuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TAB_Monuments.Name = "TAB_Monuments";
            this.TAB_Monuments.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TAB_Monuments.Size = new System.Drawing.Size(846, 570);
            this.TAB_Monuments.TabIndex = 1;
            this.TAB_Monuments.Text = "Monuments";
            this.TAB_Monuments.UseVisualStyleBackColor = true;
            // 
            // dgvMonumentsCircuits
            // 
            this.dgvMonumentsCircuits.AllowUserToAddRows = false;
            this.dgvMonumentsCircuits.AllowUserToDeleteRows = false;
            this.dgvMonumentsCircuits.AllowUserToResizeColumns = false;
            this.dgvMonumentsCircuits.AllowUserToResizeRows = false;
            this.dgvMonumentsCircuits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonumentsCircuits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonumentsCircuits.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonumentsCircuits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonumentsCircuits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMonumentsCircuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonumentsCircuits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCircuit,
            this.OrdreDansCircuit});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonumentsCircuits.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonumentsCircuits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMonumentsCircuits.Enabled = false;
            this.dgvMonumentsCircuits.Location = new System.Drawing.Point(12, 349);
            this.dgvMonumentsCircuits.MultiSelect = false;
            this.dgvMonumentsCircuits.Name = "dgvMonumentsCircuits";
            this.dgvMonumentsCircuits.ReadOnly = true;
            this.dgvMonumentsCircuits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonumentsCircuits.RowHeadersVisible = false;
            this.dgvMonumentsCircuits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMonumentsCircuits.RowTemplate.Height = 26;
            this.dgvMonumentsCircuits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonumentsCircuits.Size = new System.Drawing.Size(814, 198);
            this.dgvMonumentsCircuits.TabIndex = 12;
            this.dgvMonumentsCircuits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonumentsCircuits_CellClick);
            // 
            // NomCircuit
            // 
            this.NomCircuit.HeaderText = "Nom du circuit";
            this.NomCircuit.Name = "NomCircuit";
            this.NomCircuit.ReadOnly = true;
            // 
            // OrdreDansCircuit
            // 
            this.OrdreDansCircuit.HeaderText = "Ordre dans ce circuit";
            this.OrdreDansCircuit.Name = "OrdreDansCircuit";
            this.OrdreDansCircuit.ReadOnly = true;
            // 
            // dgvMonuments
            // 
            this.dgvMonuments.AllowUserToAddRows = false;
            this.dgvMonuments.AllowUserToDeleteRows = false;
            this.dgvMonuments.AllowUserToResizeColumns = false;
            this.dgvMonuments.AllowUserToResizeRows = false;
            this.dgvMonuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonuments.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMonuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Date,
            this.Histoire,
            this.Prix,
            this.Etoiles,
            this.MonumentId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonuments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonuments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMonuments.Location = new System.Drawing.Point(12, 92);
            this.dgvMonuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMonuments.MultiSelect = false;
            this.dgvMonuments.Name = "dgvMonuments";
            this.dgvMonuments.ReadOnly = true;
            this.dgvMonuments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonuments.RowHeadersVisible = false;
            this.dgvMonuments.RowTemplate.Height = 26;
            this.dgvMonuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonuments.Size = new System.Drawing.Size(814, 248);
            this.dgvMonuments.TabIndex = 11;
            this.dgvMonuments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonuments_CellClick);
            this.dgvMonuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonuments_CellDoubleClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Histoire
            // 
            this.Histoire.HeaderText = "Histoire";
            this.Histoire.Name = "Histoire";
            this.Histoire.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // Etoiles
            // 
            this.Etoiles.HeaderText = "Étoiles";
            this.Etoiles.Name = "Etoiles";
            this.Etoiles.ReadOnly = true;
            // 
            // MonumentId
            // 
            this.MonumentId.HeaderText = "MonumentId";
            this.MonumentId.Name = "MonumentId";
            this.MonumentId.ReadOnly = true;
            this.MonumentId.Visible = false;
            // 
            // groupbox10
            // 
            this.groupbox10.Controls.Add(this.cbxStarsMonument);
            this.groupbox10.Controls.Add(this.starsMonument);
            this.groupbox10.Location = new System.Drawing.Point(12, 17);
            this.groupbox10.Name = "groupbox10";
            this.groupbox10.Size = new System.Drawing.Size(296, 68);
            this.groupbox10.TabIndex = 10;
            this.groupbox10.TabStop = false;
            this.groupbox10.Text = "Cotation";
            // 
            // cbxStarsMonument
            // 
            this.cbxStarsMonument.AutoSize = true;
            this.cbxStarsMonument.Location = new System.Drawing.Point(200, 29);
            this.cbxStarsMonument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxStarsMonument.Name = "cbxStarsMonument";
            this.cbxStarsMonument.Size = new System.Drawing.Size(83, 24);
            this.cbxStarsMonument.TabIndex = 11;
            this.cbxStarsMonument.Text = "Activer";
            this.cbxStarsMonument.UseVisualStyleBackColor = true;
            this.cbxStarsMonument.CheckedChanged += new System.EventHandler(this.cbxStarsMonument_CheckedChanged);
            // 
            // starsMonument
            // 
            this.starsMonument.Location = new System.Drawing.Point(21, 22);
            this.starsMonument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.starsMonument.MinimumSize = new System.Drawing.Size(150, 31);
            this.starsMonument.Name = "starsMonument";
            this.starsMonument.Size = new System.Drawing.Size(170, 34);
            this.starsMonument.StarsCount = 5;
            this.starsMonument.TabIndex = 2;
            this.starsMonument.Value = 0;
            this.starsMonument.ValueChanged += new EvaluationDemo.Stars.ValueChangedEventHandler(this.starsMonument_ValueChanged);
            // 
            // TAB_Circuits
            // 
            this.TAB_Circuits.Controls.Add(this.groupBox4);
            this.TAB_Circuits.Controls.Add(this.groupBox1);
            this.TAB_Circuits.Controls.Add(this.dgvCircuits);
            this.TAB_Circuits.Controls.Add(this.groupBox6);
            this.TAB_Circuits.Location = new System.Drawing.Point(4, 29);
            this.TAB_Circuits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TAB_Circuits.Name = "TAB_Circuits";
            this.TAB_Circuits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TAB_Circuits.Size = new System.Drawing.Size(846, 570);
            this.TAB_Circuits.TabIndex = 0;
            this.TAB_Circuits.Text = "Circuits";
            this.TAB_Circuits.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxPrix);
            this.groupBox4.Controls.Add(this.nudPrix);
            this.groupBox4.Location = new System.Drawing.Point(560, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 68);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prix maximal";
            // 
            // cbxPrix
            // 
            this.cbxPrix.AutoSize = true;
            this.cbxPrix.Location = new System.Drawing.Point(153, 28);
            this.cbxPrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPrix.Name = "cbxPrix";
            this.cbxPrix.Size = new System.Drawing.Size(83, 24);
            this.cbxPrix.TabIndex = 10;
            this.cbxPrix.Text = "Activer";
            this.cbxPrix.UseVisualStyleBackColor = true;
            this.cbxPrix.CheckedChanged += new System.EventHandler(this.cbxPrix_CheckedChanged);
            // 
            // nudPrix
            // 
            this.nudPrix.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPrix.Location = new System.Drawing.Point(21, 26);
            this.nudPrix.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrix.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(110, 26);
            this.nudPrix.TabIndex = 0;
            this.nudPrix.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrix.ValueChanged += new System.EventHandler(this.nudPrix_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMonument);
            this.groupBox1.Location = new System.Drawing.Point(284, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monument";
            // 
            // cbxMonument
            // 
            this.cbxMonument.FormattingEnabled = true;
            this.cbxMonument.Location = new System.Drawing.Point(21, 25);
            this.cbxMonument.Name = "cbxMonument";
            this.cbxMonument.Size = new System.Drawing.Size(224, 28);
            this.cbxMonument.TabIndex = 0;
            this.cbxMonument.SelectedIndexChanged += new System.EventHandler(this.cbxMonument_SelectedIndexChanged);
            // 
            // dgvCircuits
            // 
            this.dgvCircuits.AllowUserToAddRows = false;
            this.dgvCircuits.AllowUserToDeleteRows = false;
            this.dgvCircuits.AllowUserToResizeColumns = false;
            this.dgvCircuits.AllowUserToResizeRows = false;
            this.dgvCircuits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCircuits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCircuits.BackgroundColor = System.Drawing.Color.White;
            this.dgvCircuits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCircuits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCircuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCircuits.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCircuits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCircuits.Location = new System.Drawing.Point(12, 92);
            this.dgvCircuits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCircuits.MultiSelect = false;
            this.dgvCircuits.Name = "dgvCircuits";
            this.dgvCircuits.ReadOnly = true;
            this.dgvCircuits.RowHeadersVisible = false;
            this.dgvCircuits.RowTemplate.Height = 26;
            this.dgvCircuits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCircuits.Size = new System.Drawing.Size(813, 452);
            this.dgvCircuits.TabIndex = 9;
            this.dgvCircuits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCircuits_CellDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxVille);
            this.groupBox6.Location = new System.Drawing.Point(12, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 68);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ville de depart";
            // 
            // cbxVille
            // 
            this.cbxVille.FormattingEnabled = true;
            this.cbxVille.Location = new System.Drawing.Point(21, 25);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(224, 28);
            this.cbxVille.TabIndex = 0;
            this.cbxVille.SelectedIndexChanged += new System.EventHandler(this.cbxVille_SelectedIndexChanged);
            // 
            // tabsControl
            // 
            this.tabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsControl.Controls.Add(this.TAB_Circuits);
            this.tabsControl.Controls.Add(this.TAB_Monuments);
            this.tabsControl.Location = new System.Drawing.Point(86, 49);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabsControl.MinimumSize = new System.Drawing.Size(854, 603);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(854, 603);
            this.tabsControl.TabIndex = 10;
            this.tabsControl.SelectedIndexChanged += new System.EventHandler(this.TABPages_SelectedIndexChanged);
            // 
            // fbtnMeilleurCircuit
            // 
            this.fbtnMeilleurCircuit.BackgroundImage = global::TPfinal.Properties.Resources.meilleur_circuit_nouveau;
            this.fbtnMeilleurCircuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnMeilleurCircuit.ClickedImage = global::TPfinal.Properties.Resources.meilleur_circuit_accept_nouveau;
            this.fbtnMeilleurCircuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnMeilleurCircuit.DisabledImage = global::TPfinal.Properties.Resources.meilleur_circuit_accept_nouveau;
            this.fbtnMeilleurCircuit.Image = ((System.Drawing.Image)(resources.GetObject("fbtnMeilleurCircuit.Image")));
            this.fbtnMeilleurCircuit.Location = new System.Drawing.Point(21, 500);
            this.fbtnMeilleurCircuit.Name = "fbtnMeilleurCircuit";
            this.fbtnMeilleurCircuit.NeutralImage = global::TPfinal.Properties.Resources.meilleur_circuit_nouveau;
            this.fbtnMeilleurCircuit.OverImage = global::TPfinal.Properties.Resources.meilleur_circuit_accept_nouveau;
            this.fbtnMeilleurCircuit.Size = new System.Drawing.Size(51, 52);
            this.fbtnMeilleurCircuit.TabIndex = 16;
            this.fbtnMeilleurCircuit.Text = "Meilleur circuit pour monument sélectionné";
            this.fbtnMeilleurCircuit.UseVisualStyleBackColor = true;
            this.fbtnMeilleurCircuit.Click += new System.EventHandler(this.fbtnMeilleurCircuit_Click);
            // 
            // fbtnImage
            // 
            this.fbtnImage.BackgroundImage = global::TPfinal.Properties.Resources.Eye;
            this.fbtnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnImage.ClickedImage = global::TPfinal.Properties.Resources.Eye_accept;
            this.fbtnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnImage.DisabledImage = null;
            this.fbtnImage.Image = ((System.Drawing.Image)(resources.GetObject("fbtnImage.Image")));
            this.fbtnImage.Location = new System.Drawing.Point(21, 428);
            this.fbtnImage.Name = "fbtnImage";
            this.fbtnImage.NeutralImage = global::TPfinal.Properties.Resources.Eye;
            this.fbtnImage.OverImage = global::TPfinal.Properties.Resources.Eye_accept;
            this.fbtnImage.Size = new System.Drawing.Size(51, 52);
            this.fbtnImage.TabIndex = 15;
            this.fbtnImage.Text = "Afficher l\'image du monument sélectionné";
            this.fbtnImage.UseVisualStyleBackColor = true;
            this.fbtnImage.Click += new System.EventHandler(this.fbtnImage_Click);
            // 
            // FBTN_AddMonument
            // 
            this.FBTN_AddMonument.BackgroundImage = global::TPfinal.Properties.Resources.Tower_Add_Neutral;
            this.FBTN_AddMonument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_AddMonument.ClickedImage = global::TPfinal.Properties.Resources.Tower_Add_Accept;
            this.FBTN_AddMonument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FBTN_AddMonument.DisabledImage = global::TPfinal.Properties.Resources.Tower_Add_Disable;
            this.FBTN_AddMonument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FBTN_AddMonument.ForeColor = System.Drawing.Color.Transparent;
            this.FBTN_AddMonument.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_AddMonument.Image")));
            this.FBTN_AddMonument.Location = new System.Drawing.Point(21, 357);
            this.FBTN_AddMonument.Name = "FBTN_AddMonument";
            this.FBTN_AddMonument.NeutralImage = global::TPfinal.Properties.Resources.Tower_Add_Neutral;
            this.FBTN_AddMonument.OverImage = global::TPfinal.Properties.Resources.Tower_Add_Accept;
            this.FBTN_AddMonument.Size = new System.Drawing.Size(51, 52);
            this.FBTN_AddMonument.TabIndex = 12;
            this.FBTN_AddMonument.Text = "Ajouter un monument";
            this.FBTN_AddMonument.UseVisualStyleBackColor = true;
            this.FBTN_AddMonument.Click += new System.EventHandler(this.FBTN_AddMonument_Click);
            // 
            // fbtnInformations
            // 
            this.fbtnInformations.BackgroundImage = global::TPfinal.Properties.Resources.info_neutre;
            this.fbtnInformations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnInformations.ClickedImage = global::TPfinal.Properties.Resources.info_accept;
            this.fbtnInformations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnInformations.DisabledImage = null;
            this.fbtnInformations.Image = ((System.Drawing.Image)(resources.GetObject("fbtnInformations.Image")));
            this.fbtnInformations.Location = new System.Drawing.Point(21, 275);
            this.fbtnInformations.Name = "fbtnInformations";
            this.fbtnInformations.NeutralImage = global::TPfinal.Properties.Resources.info_neutre;
            this.fbtnInformations.OverImage = global::TPfinal.Properties.Resources.info_accept;
            this.fbtnInformations.Size = new System.Drawing.Size(51, 52);
            this.fbtnInformations.TabIndex = 14;
            this.fbtnInformations.Text = "Voir les informations du circuit sélectionné";
            this.fbtnInformations.UseVisualStyleBackColor = true;
            this.fbtnInformations.Click += new System.EventHandler(this.fbtnInformations_Click);
            // 
            // fbtnEffacer
            // 
            this.fbtnEffacer.BackgroundImage = global::TPfinal.Properties.Resources.circuit_delete_neutre;
            this.fbtnEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnEffacer.ClickedImage = global::TPfinal.Properties.Resources.circuit_delete_accept;
            this.fbtnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnEffacer.DisabledImage = global::TPfinal.Properties.Resources.circuit_delete_disable;
            this.fbtnEffacer.Image = ((System.Drawing.Image)(resources.GetObject("fbtnEffacer.Image")));
            this.fbtnEffacer.Location = new System.Drawing.Point(21, 200);
            this.fbtnEffacer.Name = "fbtnEffacer";
            this.fbtnEffacer.NeutralImage = global::TPfinal.Properties.Resources.circuit_delete_neutre;
            this.fbtnEffacer.OverImage = global::TPfinal.Properties.Resources.circuit_delete_accept;
            this.fbtnEffacer.Size = new System.Drawing.Size(51, 52);
            this.fbtnEffacer.TabIndex = 13;
            this.fbtnEffacer.Text = "Effacer des monuments";
            this.fbtnEffacer.UseVisualStyleBackColor = true;
            this.fbtnEffacer.Click += new System.EventHandler(this.fbtnEffacer_Click);
            // 
            // fbtnModifier
            // 
            this.fbtnModifier.BackgroundImage = global::TPfinal.Properties.Resources.circuit_edit_neutre;
            this.fbtnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnModifier.ClickedImage = global::TPfinal.Properties.Resources.circuit_edit_accept;
            this.fbtnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnModifier.DisabledImage = global::TPfinal.Properties.Resources.circuit_add_disable;
            this.fbtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("fbtnModifier.Image")));
            this.fbtnModifier.Location = new System.Drawing.Point(21, 125);
            this.fbtnModifier.Name = "fbtnModifier";
            this.fbtnModifier.NeutralImage = global::TPfinal.Properties.Resources.circuit_edit_neutre;
            this.fbtnModifier.OverImage = global::TPfinal.Properties.Resources.circuit_edit_accept;
            this.fbtnModifier.Size = new System.Drawing.Size(51, 52);
            this.fbtnModifier.TabIndex = 12;
            this.fbtnModifier.Text = "Modifier un circuit";
            this.fbtnModifier.UseVisualStyleBackColor = true;
            this.fbtnModifier.Click += new System.EventHandler(this.fbtnModifier_Click);
            // 
            // fbtnAjouter
            // 
            this.fbtnAjouter.BackgroundImage = global::TPfinal.Properties.Resources.circuit_add_neutre;
            this.fbtnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnAjouter.ClickedImage = global::TPfinal.Properties.Resources.circuit_add_accept;
            this.fbtnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnAjouter.DisabledImage = global::TPfinal.Properties.Resources.circuit_add_disable;
            this.fbtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("fbtnAjouter.Image")));
            this.fbtnAjouter.Location = new System.Drawing.Point(21, 49);
            this.fbtnAjouter.Name = "fbtnAjouter";
            this.fbtnAjouter.NeutralImage = global::TPfinal.Properties.Resources.circuit_add_neutre;
            this.fbtnAjouter.OverImage = global::TPfinal.Properties.Resources.circuit_add_accept;
            this.fbtnAjouter.Size = new System.Drawing.Size(51, 52);
            this.fbtnAjouter.TabIndex = 11;
            this.fbtnAjouter.Text = "Ajouter un circuit";
            this.fbtnAjouter.UseVisualStyleBackColor = true;
            this.fbtnAjouter.Click += new System.EventHandler(this.fbtnAjouter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 682);
            this.Controls.Add(this.fbtnMeilleurCircuit);
            this.Controls.Add(this.fbtnImage);
            this.Controls.Add(this.FBTN_AddMonument);
            this.Controls.Add(this.fbtnInformations);
            this.Controls.Add(this.fbtnEffacer);
            this.Controls.Add(this.fbtnModifier);
            this.Controls.Add(this.fbtnAjouter);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(984, 711);
            this.Name = "MainForm";
            this.Text = "Agence Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TAB_Monuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonumentsCircuits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonuments)).EndInit();
            this.groupbox10.ResumeLayout(false);
            this.groupbox10.PerformLayout();
            this.TAB_Circuits.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCircuits)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tabsControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PhotoManagerClient.FlashButton flashButton1;
        private PhotoManagerClient.FlashButton flashButton3;
        private PhotoManagerClient.FlashButton flashButton2;
        private EvaluationDemo.Stars stars1;
        private System.Windows.Forms.ToolStripMenuItem monumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem STRIP_AjouterMonument;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.TabPage TAB_Monuments;
        private System.Windows.Forms.GroupBox groupbox10;
        private System.Windows.Forms.TabPage TAB_Circuits;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxMonument;
        private System.Windows.Forms.DataGridView dgvCircuits;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.DataGridView dgvMonuments;
        private EvaluationDemo.Stars starsMonument;
        private System.Windows.Forms.CheckBox cbxPrix;
        private System.Windows.Forms.CheckBox cbxStarsMonument;
        private System.Windows.Forms.ToolStripMenuItem circuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private PhotoManagerClient.FlashButton fbtnAjouter;
        private PhotoManagerClient.FlashButton fbtnModifier;
        private PhotoManagerClient.FlashButton fbtnEffacer;
        private PhotoManagerClient.FlashButton fbtnInformations;
        private System.Windows.Forms.ToolStripMenuItem voirInformationsToolStripMenuItem;
        private PhotoManagerClient.FlashButton FBTN_AddMonument;
        private System.Windows.Forms.DataGridView dgvMonumentsCircuits;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdreDansCircuit;
        private PhotoManagerClient.FlashButton fbtnImage;
        private System.Windows.Forms.ToolStripMenuItem afficherImageToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Histoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etoiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonumentId;
        private PhotoManagerClient.FlashButton fbtnMeilleurCircuit;
        private System.Windows.Forms.ToolStripMenuItem voirMeilleurCircuitToolStripMenuItem;
    }
}

