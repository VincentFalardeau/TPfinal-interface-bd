namespace TPfinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flashButton3 = new PhotoManagerClient.FlashButton();
            this.flashButton2 = new PhotoManagerClient.FlashButton();
            this.flashButton1 = new PhotoManagerClient.FlashButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupbox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupbox10 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.stars1 = new EvaluationDemo.Stars();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.circuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupbox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupbox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche de circuit ou monument";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "monument";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "circuit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flashButton3);
            this.groupBox3.Controls.Add(this.flashButton2);
            this.groupBox3.Controls.Add(this.flashButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 93);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // flashButton3
            // 
            this.flashButton3.BackgroundImage = global::TPfinal.Properties.Resources.edit;
            this.flashButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton3.ClickedImage = null;
            this.flashButton3.DisabledImage = null;
            this.flashButton3.Image = ((System.Drawing.Image)(resources.GetObject("flashButton3.Image")));
            this.flashButton3.Location = new System.Drawing.Point(119, 25);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.NeutralImage = null;
            this.flashButton3.OverImage = null;
            this.flashButton3.Size = new System.Drawing.Size(50, 50);
            this.flashButton3.TabIndex = 2;
            this.flashButton3.Text = "flashButton3";
            this.flashButton3.UseVisualStyleBackColor = true;
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::TPfinal.Properties.Resources.trash;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton2.ClickedImage = null;
            this.flashButton2.DisabledImage = null;
            this.flashButton2.Image = ((System.Drawing.Image)(resources.GetObject("flashButton2.Image")));
            this.flashButton2.Location = new System.Drawing.Point(231, 25);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.NeutralImage = null;
            this.flashButton2.OverImage = null;
            this.flashButton2.Size = new System.Drawing.Size(50, 50);
            this.flashButton2.TabIndex = 1;
            this.flashButton2.Text = "flashButton2";
            this.flashButton2.UseVisualStyleBackColor = true;
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::TPfinal.Properties.Resources.ICON_Ajouter_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Image = ((System.Drawing.Image)(resources.GetObject("flashButton1.Image")));
            this.flashButton1.Location = new System.Drawing.Point(21, 25);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(50, 50);
            this.flashButton1.TabIndex = 0;
            this.flashButton1.Text = "flashButton1";
            this.flashButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Location = new System.Drawing.Point(8, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 67);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prix maximal";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(260, 26);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Location = new System.Drawing.Point(8, 98);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(298, 67);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ville de depart";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // groupbox7
            // 
            this.groupbox7.Controls.Add(this.groupBox1);
            this.groupbox7.Controls.Add(this.groupBox6);
            this.groupbox7.Controls.Add(this.groupBox4);
            this.groupbox7.Location = new System.Drawing.Point(12, 126);
            this.groupbox7.Name = "groupbox7";
            this.groupbox7.Size = new System.Drawing.Size(312, 248);
            this.groupbox7.TabIndex = 8;
            this.groupbox7.TabStop = false;
            this.groupbox7.Text = "circuit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monument";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(260, 28);
            this.comboBox2.TabIndex = 0;
            // 
            // groupbox10
            // 
            this.groupbox10.Controls.Add(this.checkBox1);
            this.groupbox10.Controls.Add(this.stars1);
            this.groupbox10.Location = new System.Drawing.Point(12, 380);
            this.groupbox10.Name = "groupbox10";
            this.groupbox10.Size = new System.Drawing.Size(312, 67);
            this.groupbox10.TabIndex = 9;
            this.groupbox10.TabStop = false;
            this.groupbox10.Text = "monument";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Meilleur circuit";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // stars1
            // 
            this.stars1.Location = new System.Drawing.Point(7, 26);
            this.stars1.MinimumSize = new System.Drawing.Size(100, 20);
            this.stars1.Name = "stars1";
            this.stars1.Size = new System.Drawing.Size(135, 27);
            this.stars1.StarsCount = 5;
            this.stars1.TabIndex = 0;
            this.stars1.Value = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(974, 382);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 164);
            this.listBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(975, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 166);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(975, 209);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 167);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
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
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
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
            this.menuStrip1.Size = new System.Drawing.Size(1214, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 556);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupbox10);
            this.Controls.Add(this.groupbox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupbox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupbox10.ResumeLayout(false);
            this.groupbox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private PhotoManagerClient.FlashButton flashButton1;
        private PhotoManagerClient.FlashButton flashButton3;
        private PhotoManagerClient.FlashButton flashButton2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupbox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupbox10;
        private System.Windows.Forms.CheckBox checkBox1;
        private EvaluationDemo.Stars stars1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem circuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
    }
}

