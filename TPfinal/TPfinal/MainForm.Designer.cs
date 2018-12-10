namespace TPfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STRIP_AjouterMonument = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.circuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TAB_Monuments = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonumentsCircuits = new System.Windows.Forms.DataGridView();
            this.NomCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdreDansCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMonuments = new System.Windows.Forms.DataGridView();
            this.SelectMonument = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Histoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etoiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MonumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox10 = new System.Windows.Forms.GroupBox();
            this.cbxStarsMonument = new System.Windows.Forms.CheckBox();
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
            this.FBTN_AddMonument = new PhotoManagerClient.FlashButton();
            this.fbtnInformations = new PhotoManagerClient.FlashButton();
            this.fbtnEffacer = new PhotoManagerClient.FlashButton();
            this.fbtnModifier = new PhotoManagerClient.FlashButton();
            this.fbtnAjouter = new PhotoManagerClient.FlashButton();
            this.starsMonument = new EvaluationDemo.Stars();
            this.CircuitAjouter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CircuitModifier = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.STRIP_AjouterMonument});
            this.monumentToolStripMenuItem.Name = "monumentToolStripMenuItem";
            this.monumentToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.monumentToolStripMenuItem.Text = "Monument";
            // 
            // STRIP_AjouterMonument
            // 
            this.STRIP_AjouterMonument.Name = "STRIP_AjouterMonument";
            this.STRIP_AjouterMonument.Size = new System.Drawing.Size(154, 30);
            this.STRIP_AjouterMonument.Text = "Ajouter";
            this.STRIP_AjouterMonument.Click += new System.EventHandler(this.STRIP_AjouterMonument_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuitToolStripMenuItem,
            this.monumentToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // circuitToolStripMenuItem
            // 
            this.circuitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.voirInformationsToolStripMenuItem});
            this.circuitToolStripMenuItem.Name = "circuitToolStripMenuItem";
            this.circuitToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.circuitToolStripMenuItem.Text = "Circuit";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // voirInformationsToolStripMenuItem
            // 
            this.voirInformationsToolStripMenuItem.Name = "voirInformationsToolStripMenuItem";
            this.voirInformationsToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.voirInformationsToolStripMenuItem.Text = "Voir informations";
            this.voirInformationsToolStripMenuItem.Click += new System.EventHandler(this.voirInformationsToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.àProposToolStripMenuItem.Text = "À propos";
            // 
            // TAB_Monuments
            // 
            this.TAB_Monuments.Controls.Add(this.label2);
            this.TAB_Monuments.Controls.Add(this.label1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Circuits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Monuments";
            // 
            // dgvMonumentsCircuits
            // 
            this.dgvMonumentsCircuits.AllowUserToAddRows = false;
            this.dgvMonumentsCircuits.AllowUserToDeleteRows = false;
            this.dgvMonumentsCircuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonumentsCircuits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCircuit,
            this.OrdreDansCircuit});
            this.dgvMonumentsCircuits.Location = new System.Drawing.Point(12, 369);
            this.dgvMonumentsCircuits.Name = "dgvMonumentsCircuits";
            this.dgvMonumentsCircuits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonumentsCircuits.RowHeadersVisible = false;
            this.dgvMonumentsCircuits.RowTemplate.Height = 28;
            this.dgvMonumentsCircuits.Size = new System.Drawing.Size(814, 179);
            this.dgvMonumentsCircuits.TabIndex = 12;
            // 
            // NomCircuit
            // 
            this.NomCircuit.HeaderText = "Nom du circuit";
            this.NomCircuit.Name = "NomCircuit";
            // 
            // OrdreDansCircuit
            // 
            this.OrdreDansCircuit.HeaderText = "Ordre dans ce circuit";
            this.OrdreDansCircuit.Name = "OrdreDansCircuit";
            // 
            // dgvMonuments
            // 
            this.dgvMonuments.AllowUserToAddRows = false;
            this.dgvMonuments.AllowUserToDeleteRows = false;
            this.dgvMonuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectMonument,
            this.Nom,
            this.Date,
            this.Histoire,
            this.Prix,
            this.Etoiles,
            this.ImageButton,
            this.MonumentId});
            this.dgvMonuments.Location = new System.Drawing.Point(12, 121);
            this.dgvMonuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMonuments.Name = "dgvMonuments";
            this.dgvMonuments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonuments.RowHeadersVisible = false;
            this.dgvMonuments.RowTemplate.Height = 32;
            this.dgvMonuments.Size = new System.Drawing.Size(814, 220);
            this.dgvMonuments.TabIndex = 11;
            this.dgvMonuments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonuments_CellContentClick);
            // 
            // SelectMonument
            // 
            this.SelectMonument.FalseValue = "false";
            this.SelectMonument.HeaderText = "Sélectionner";
            this.SelectMonument.Name = "SelectMonument";
            this.SelectMonument.TrueValue = "true";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 75;
            // 
            // Histoire
            // 
            this.Histoire.HeaderText = "Histoire";
            this.Histoire.Name = "Histoire";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.Width = 50;
            // 
            // Etoiles
            // 
            this.Etoiles.HeaderText = "Score";
            this.Etoiles.Name = "Etoiles";
            this.Etoiles.Width = 40;
            // 
            // ImageButton
            // 
            this.ImageButton.HeaderText = "Image";
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Text = "Afficher";
            this.ImageButton.ToolTipText = "Afficher";
            this.ImageButton.UseColumnTextForButtonValue = true;
            this.ImageButton.Width = 75;
            // 
            // MonumentId
            // 
            this.MonumentId.HeaderText = "MonumentId";
            this.MonumentId.Name = "MonumentId";
            this.MonumentId.Visible = false;
            // 
            // groupbox10
            // 
            this.groupbox10.Controls.Add(this.cbxStarsMonument);
            this.groupbox10.Controls.Add(this.starsMonument);
            this.groupbox10.Location = new System.Drawing.Point(12, 17);
            this.groupbox10.Name = "groupbox10";
            this.groupbox10.Size = new System.Drawing.Size(272, 68);
            this.groupbox10.TabIndex = 10;
            this.groupbox10.TabStop = false;
            this.groupbox10.Text = "Cotation";
            // 
            // cbxStarsMonument
            // 
            this.cbxStarsMonument.AutoSize = true;
            this.cbxStarsMonument.Location = new System.Drawing.Point(184, 29);
            this.cbxStarsMonument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxStarsMonument.Name = "cbxStarsMonument";
            this.cbxStarsMonument.Size = new System.Drawing.Size(83, 24);
            this.cbxStarsMonument.TabIndex = 11;
            this.cbxStarsMonument.Text = "Activer";
            this.cbxStarsMonument.UseVisualStyleBackColor = true;
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
            this.dgvCircuits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCircuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCircuits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CircuitAjouter,
            this.CircuitModifier});
            this.dgvCircuits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCircuits.Enabled = false;
            this.dgvCircuits.Location = new System.Drawing.Point(12, 92);
            this.dgvCircuits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCircuits.MultiSelect = false;
            this.dgvCircuits.Name = "dgvCircuits";
            this.dgvCircuits.Size = new System.Drawing.Size(813, 452);
            this.dgvCircuits.TabIndex = 9;
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
            this.tabsControl.Controls.Add(this.TAB_Circuits);
            this.tabsControl.Controls.Add(this.TAB_Monuments);
            this.tabsControl.Location = new System.Drawing.Point(85, 50);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(854, 603);
            this.tabsControl.TabIndex = 10;
            this.tabsControl.SelectedIndexChanged += new System.EventHandler(this.TABPages_SelectedIndexChanged);
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
            this.FBTN_AddMonument.Location = new System.Drawing.Point(16, 354);
            this.FBTN_AddMonument.Name = "FBTN_AddMonument";
            this.FBTN_AddMonument.NeutralImage = global::TPfinal.Properties.Resources.Tower_Add_Neutral;
            this.FBTN_AddMonument.OverImage = global::TPfinal.Properties.Resources.Tower_Add_Accept;
            this.FBTN_AddMonument.Size = new System.Drawing.Size(62, 62);
            this.FBTN_AddMonument.TabIndex = 12;
            this.FBTN_AddMonument.Text = "Ajouter un monument";
            this.FBTN_AddMonument.UseVisualStyleBackColor = true;
            this.FBTN_AddMonument.Click += new System.EventHandler(this.FBTN_AddMonument_Click);
            // 
            // fbtnInformations
            // 
            this.fbtnInformations.BackgroundImage = global::TPfinal.Properties.Resources.Eye;
            this.fbtnInformations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnInformations.ClickedImage = null;
            this.fbtnInformations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnInformations.DisabledImage = null;
            this.fbtnInformations.Image = ((System.Drawing.Image)(resources.GetObject("fbtnInformations.Image")));
            this.fbtnInformations.Location = new System.Drawing.Point(21, 275);
            this.fbtnInformations.Name = "fbtnInformations";
            this.fbtnInformations.NeutralImage = null;
            this.fbtnInformations.OverImage = null;
            this.fbtnInformations.Size = new System.Drawing.Size(52, 52);
            this.fbtnInformations.TabIndex = 14;
            this.fbtnInformations.Text = "Voir les informations";
            this.fbtnInformations.UseVisualStyleBackColor = true;
            this.fbtnInformations.Click += new System.EventHandler(this.fbtnInformations_Click);
            // 
            // fbtnEffacer
            // 
            this.fbtnEffacer.BackgroundImage = global::TPfinal.Properties.Resources.trash;
            this.fbtnEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnEffacer.ClickedImage = null;
            this.fbtnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnEffacer.DisabledImage = null;
            this.fbtnEffacer.Image = ((System.Drawing.Image)(resources.GetObject("fbtnEffacer.Image")));
            this.fbtnEffacer.Location = new System.Drawing.Point(21, 200);
            this.fbtnEffacer.Name = "fbtnEffacer";
            this.fbtnEffacer.NeutralImage = null;
            this.fbtnEffacer.OverImage = null;
            this.fbtnEffacer.Size = new System.Drawing.Size(52, 52);
            this.fbtnEffacer.TabIndex = 13;
            this.fbtnEffacer.Text = "Effacer un circuit";
            this.fbtnEffacer.UseVisualStyleBackColor = true;
            this.fbtnEffacer.Click += new System.EventHandler(this.fbtnEffacer_Click);
            // 
            // fbtnModifier
            // 
            this.fbtnModifier.BackgroundImage = global::TPfinal.Properties.Resources.edit;
            this.fbtnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnModifier.ClickedImage = null;
            this.fbtnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnModifier.DisabledImage = null;
            this.fbtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("fbtnModifier.Image")));
            this.fbtnModifier.Location = new System.Drawing.Point(21, 125);
            this.fbtnModifier.Name = "fbtnModifier";
            this.fbtnModifier.NeutralImage = null;
            this.fbtnModifier.OverImage = null;
            this.fbtnModifier.Size = new System.Drawing.Size(52, 52);
            this.fbtnModifier.TabIndex = 12;
            this.fbtnModifier.Text = "Modifier un circuit";
            this.fbtnModifier.UseVisualStyleBackColor = true;
            this.fbtnModifier.Click += new System.EventHandler(this.fbtnModifier_Click);
            // 
            // fbtnAjouter
            // 
            this.fbtnAjouter.BackgroundImage = global::TPfinal.Properties.Resources.ICON_Ajouter_Neutral;
            this.fbtnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnAjouter.ClickedImage = null;
            this.fbtnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnAjouter.DisabledImage = null;
            this.fbtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("fbtnAjouter.Image")));
            this.fbtnAjouter.Location = new System.Drawing.Point(21, 50);
            this.fbtnAjouter.Name = "fbtnAjouter";
            this.fbtnAjouter.NeutralImage = null;
            this.fbtnAjouter.OverImage = null;
            this.fbtnAjouter.Size = new System.Drawing.Size(52, 52);
            this.fbtnAjouter.TabIndex = 11;
            this.fbtnAjouter.Text = "Ajouter un circuit";
            this.fbtnAjouter.UseVisualStyleBackColor = true;
            this.fbtnAjouter.Click += new System.EventHandler(this.fbtnAjouter_Click);
            // 
            // starsMonument
            // 
            this.starsMonument.Location = new System.Drawing.Point(21, 22);
            this.starsMonument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.starsMonument.MinimumSize = new System.Drawing.Size(150, 31);
            this.starsMonument.Name = "starsMonument";
            this.starsMonument.Size = new System.Drawing.Size(155, 31);
            this.starsMonument.StarsCount = 5;
            this.starsMonument.TabIndex = 2;
            this.starsMonument.Value = 0;
            // 
            // CircuitAjouter
            // 
            this.CircuitAjouter.HeaderText = "Ajouter un circuit";
            this.CircuitAjouter.Name = "CircuitAjouter";
            this.CircuitAjouter.Text = "Ajouter";
            this.CircuitAjouter.UseColumnTextForButtonValue = true;
            // 
            // CircuitModifier
            // 
            this.CircuitModifier.HeaderText = "Modifier un circuit";
            this.CircuitModifier.Name = "CircuitModifier";
            this.CircuitModifier.Text = "Modifier";
            this.CircuitModifier.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 664);
            this.Controls.Add(this.FBTN_AddMonument);
            this.Controls.Add(this.fbtnInformations);
            this.Controls.Add(this.fbtnEffacer);
            this.Controls.Add(this.fbtnModifier);
            this.Controls.Add(this.fbtnAjouter);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Agence Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TAB_Monuments.ResumeLayout(false);
            this.TAB_Monuments.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdreDansCircuit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectMonument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Histoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etoiles;
        private System.Windows.Forms.DataGridViewButtonColumn ImageButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonumentId;
        private System.Windows.Forms.DataGridViewButtonColumn CircuitAjouter;
        private System.Windows.Forms.DataGridViewButtonColumn CircuitModifier;
    }
}

