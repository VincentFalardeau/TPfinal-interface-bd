namespace TPfinal
{
    partial class AjouterCircuitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterCircuitForm));
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDepart = new System.Windows.Forms.ComboBox();
            this.cbxArrivee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lbxMonuments = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMonuments = new System.Windows.Forms.ComboBox();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.fbtnEffacerMonument = new PhotoManagerClient.FlashButton();
            this.fbtnAjouterMonument = new PhotoManagerClient.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(180, 19);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(10);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(236, 26);
            this.tbxNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // cbxDepart
            // 
            this.cbxDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepart.FormattingEnabled = true;
            this.cbxDepart.Location = new System.Drawing.Point(179, 65);
            this.cbxDepart.Margin = new System.Windows.Forms.Padding(10);
            this.cbxDepart.Name = "cbxDepart";
            this.cbxDepart.Size = new System.Drawing.Size(237, 28);
            this.cbxDepart.Sorted = true;
            this.cbxDepart.TabIndex = 5;
            // 
            // cbxArrivee
            // 
            this.cbxArrivee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArrivee.FormattingEnabled = true;
            this.cbxArrivee.Location = new System.Drawing.Point(179, 113);
            this.cbxArrivee.Margin = new System.Windows.Forms.Padding(10);
            this.cbxArrivee.Name = "cbxArrivee";
            this.cbxArrivee.Size = new System.Drawing.Size(237, 28);
            this.cbxArrivee.Sorted = true;
            this.cbxArrivee.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ville de départ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ville d\'arrivée";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(241, 359);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(175, 55);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Location = new System.Drawing.Point(42, 359);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(175, 55);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(132, 163);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(34, 20);
            this.lblPrix.TabIndex = 17;
            this.lblPrix.Text = "Prix";
            // 
            // lbxMonuments
            // 
            this.lbxMonuments.FormattingEnabled = true;
            this.lbxMonuments.ItemHeight = 20;
            this.lbxMonuments.Location = new System.Drawing.Point(179, 235);
            this.lbxMonuments.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lbxMonuments.Name = "lbxMonuments";
            this.lbxMonuments.Size = new System.Drawing.Size(237, 104);
            this.lbxMonuments.TabIndex = 19;
            this.lbxMonuments.SelectedIndexChanged += new System.EventHandler(this.lbxMonuments_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Monuments";
            // 
            // cbxMonuments
            // 
            this.cbxMonuments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonuments.FormattingEnabled = true;
            this.cbxMonuments.Location = new System.Drawing.Point(179, 207);
            this.cbxMonuments.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.cbxMonuments.Name = "cbxMonuments";
            this.cbxMonuments.Size = new System.Drawing.Size(237, 28);
            this.cbxMonuments.Sorted = true;
            this.cbxMonuments.TabIndex = 21;
            // 
            // nudPrix
            // 
            this.nudPrix.DecimalPlaces = 2;
            this.nudPrix.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPrix.Location = new System.Drawing.Point(180, 161);
            this.nudPrix.Margin = new System.Windows.Forms.Padding(10);
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
            this.nudPrix.Size = new System.Drawing.Size(236, 26);
            this.nudPrix.TabIndex = 22;
            this.nudPrix.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // fbtnEffacerMonument
            // 
            this.fbtnEffacerMonument.BackColor = System.Drawing.Color.Transparent;
            this.fbtnEffacerMonument.BackgroundImage = global::TPfinal.Properties.Resources.trash;
            this.fbtnEffacerMonument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnEffacerMonument.ClickedImage = global::TPfinal.Properties.Resources.trash_accept;
            this.fbtnEffacerMonument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnEffacerMonument.DisabledImage = global::TPfinal.Properties.Resources.trash_disable;
            this.fbtnEffacerMonument.Enabled = false;
            this.fbtnEffacerMonument.Image = ((System.Drawing.Image)(resources.GetObject("fbtnEffacerMonument.Image")));
            this.fbtnEffacerMonument.Location = new System.Drawing.Point(130, 293);
            this.fbtnEffacerMonument.Name = "fbtnEffacerMonument";
            this.fbtnEffacerMonument.NeutralImage = global::TPfinal.Properties.Resources.trash;
            this.fbtnEffacerMonument.OverImage = global::TPfinal.Properties.Resources.trash_accept;
            this.fbtnEffacerMonument.Size = new System.Drawing.Size(36, 36);
            this.fbtnEffacerMonument.TabIndex = 13;
            this.fbtnEffacerMonument.Text = "Supprimer le monument sélectionné dans la liste";
            this.fbtnEffacerMonument.UseVisualStyleBackColor = false;
            this.fbtnEffacerMonument.Click += new System.EventHandler(this.fbtnEffacerMonument_Click);
            // 
            // fbtnAjouterMonument
            // 
            this.fbtnAjouterMonument.BackColor = System.Drawing.Color.Transparent;
            this.fbtnAjouterMonument.BackgroundImage = global::TPfinal.Properties.Resources.ICON_Ajouter_Neutral;
            this.fbtnAjouterMonument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnAjouterMonument.ClickedImage = global::TPfinal.Properties.Resources.ICON_Ajouter_Click;
            this.fbtnAjouterMonument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnAjouterMonument.DisabledImage = global::TPfinal.Properties.Resources.ICON_Ajouter_Disable;
            this.fbtnAjouterMonument.Image = ((System.Drawing.Image)(resources.GetObject("fbtnAjouterMonument.Image")));
            this.fbtnAjouterMonument.Location = new System.Drawing.Point(130, 251);
            this.fbtnAjouterMonument.Name = "fbtnAjouterMonument";
            this.fbtnAjouterMonument.NeutralImage = global::TPfinal.Properties.Resources.ICON_Ajouter_Neutral;
            this.fbtnAjouterMonument.OverImage = global::TPfinal.Properties.Resources.ICON_Ajouter_Over;
            this.fbtnAjouterMonument.Size = new System.Drawing.Size(36, 36);
            this.fbtnAjouterMonument.TabIndex = 12;
            this.fbtnAjouterMonument.Text = "Ajouter le monument sélectionné";
            this.fbtnAjouterMonument.UseVisualStyleBackColor = false;
            this.fbtnAjouterMonument.Click += new System.EventHandler(this.fbtnAjouterMonument_Click);
            // 
            // AjouterCircuitForm
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(464, 433);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.cbxMonuments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxMonuments);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.fbtnEffacerMonument);
            this.Controls.Add(this.fbtnAjouterMonument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxArrivee);
            this.Controls.Add(this.cbxDepart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AjouterCircuitForm";
            this.Text = "Ajouter un circuit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjouterCircuitForm_FormClosing);
            this.Load += new System.EventHandler(this.AjouterCircuitForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AjouterCircuitForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDepart;
        private System.Windows.Forms.ComboBox cbxArrivee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PhotoManagerClient.FlashButton fbtnAjouterMonument;
        private PhotoManagerClient.FlashButton fbtnEffacerMonument;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.ListBox lbxMonuments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMonuments;
        private System.Windows.Forms.NumericUpDown nudPrix;
    }
}