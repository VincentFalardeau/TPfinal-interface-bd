namespace TPfinal
{
    partial class SupprimerMonumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerMonumentForm));
            this.cbxCircuits = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.clbxMonuments = new System.Windows.Forms.CheckedListBox();
            this.fbtnEffacer = new PhotoManagerClient.FlashButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxCircuits
            // 
            this.cbxCircuits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCircuits.FormattingEnabled = true;
            this.cbxCircuits.Location = new System.Drawing.Point(14, 24);
            this.cbxCircuits.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxCircuits.Name = "cbxCircuits";
            this.cbxCircuits.Size = new System.Drawing.Size(213, 21);
            this.cbxCircuits.TabIndex = 15;
            this.cbxCircuits.SelectedIndexChanged += new System.EventHandler(this.cbxCircuits_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(105, 170);
            this.btnOk.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(122, 35);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Quitter";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // clbxMonuments
            // 
            this.clbxMonuments.CheckOnClick = true;
            this.clbxMonuments.FormattingEnabled = true;
            this.clbxMonuments.Location = new System.Drawing.Point(14, 53);
            this.clbxMonuments.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.clbxMonuments.Name = "clbxMonuments";
            this.clbxMonuments.Size = new System.Drawing.Size(213, 109);
            this.clbxMonuments.TabIndex = 16;
            this.clbxMonuments.SelectedIndexChanged += new System.EventHandler(this.clbxMonuments_SelectedIndexChanged);
            // 
            // fbtnEffacer
            // 
            this.fbtnEffacer.BackgroundImage = global::TPfinal.Properties.Resources.trash;
            this.fbtnEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnEffacer.ClickedImage = global::TPfinal.Properties.Resources.trash_accept;
            this.fbtnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnEffacer.DisabledImage = global::TPfinal.Properties.Resources.trash_disable;
            this.fbtnEffacer.Image = ((System.Drawing.Image)(resources.GetObject("fbtnEffacer.Image")));
            this.fbtnEffacer.Location = new System.Drawing.Point(17, 173);
            this.fbtnEffacer.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.fbtnEffacer.Name = "fbtnEffacer";
            this.fbtnEffacer.NeutralImage = global::TPfinal.Properties.Resources.trash;
            this.fbtnEffacer.OverImage = global::TPfinal.Properties.Resources.trash_accept;
            this.fbtnEffacer.Size = new System.Drawing.Size(30, 29);
            this.fbtnEffacer.TabIndex = 18;
            this.fbtnEffacer.Text = "Supprimer les circuits selectionnés";
            this.fbtnEffacer.UseVisualStyleBackColor = true;
            this.fbtnEffacer.Click += new System.EventHandler(this.fbtnEffacer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Circuit";
            // 
            // SupprimerMonumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbtnEffacer);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.clbxMonuments);
            this.Controls.Add(this.cbxCircuits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SupprimerMonumentForm";
            this.Text = "Supprimer des monuments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SupprimerMonumentForm_FormClosing);
            this.Load += new System.EventHandler(this.SupprimerMonumentForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SupprimerMonumentForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCircuits;
        private PhotoManagerClient.FlashButton fbtnEffacer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckedListBox clbxMonuments;
        private System.Windows.Forms.Label label1;
    }
}