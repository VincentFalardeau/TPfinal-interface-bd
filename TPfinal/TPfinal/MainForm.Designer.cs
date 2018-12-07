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
            this.monumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.circuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TAB_Monuments = new System.Windows.Forms.TabPage();
            this.dgvMonuments = new System.Windows.Forms.DataGridView();
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
            this.menuStrip1.SuspendLayout();
            this.TAB_Monuments.SuspendLayout();
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
            this.ajouterToolStripMenuItem1});
            this.monumentToolStripMenuItem.Name = "monumentToolStripMenuItem";
            this.monumentToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.monumentToolStripMenuItem.Text = "Monument";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(154, 30);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
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
            this.menuStrip1.Size = new System.Drawing.Size(878, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // circuitToolStripMenuItem
            // 
            this.circuitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.circuitToolStripMenuItem.Name = "circuitToolStripMenuItem";
            this.circuitToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.circuitToolStripMenuItem.Text = "Circuit";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
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
            // dgvMonuments
            // 
            this.dgvMonuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonuments.Location = new System.Drawing.Point(12, 92);
            this.dgvMonuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMonuments.Name = "dgvMonuments";
            this.dgvMonuments.Size = new System.Drawing.Size(814, 452);
            this.dgvMonuments.TabIndex = 11;
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
            this.dgvCircuits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCircuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCircuits.Location = new System.Drawing.Point(12, 92);
            this.dgvCircuits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCircuits.Name = "dgvCircuits";
            this.dgvCircuits.ReadOnly = true;
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
            this.tabsControl.Location = new System.Drawing.Point(13, 38);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(854, 603);
            this.tabsControl.TabIndex = 10;
            this.tabsControl.SelectedIndexChanged += new System.EventHandler(this.TABPages_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 656);
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
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
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
    }
}

