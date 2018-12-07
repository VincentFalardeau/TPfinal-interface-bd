namespace TPfinal
{
    partial class ModifierCircuitForm
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
            this.tbxNvPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCircuits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNvPrix
            // 
            this.tbxNvPrix.Location = new System.Drawing.Point(118, 98);
            this.tbxNvPrix.MaxLength = 6;
            this.tbxNvPrix.Name = "tbxNvPrix";
            this.tbxNvPrix.Size = new System.Drawing.Size(135, 26);
            this.tbxNvPrix.TabIndex = 0;
            this.tbxNvPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNvPrix_Keyress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nouveau prix";
            // 
            // cbxCircuits
            // 
            this.cbxCircuits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCircuits.FormattingEnabled = true;
            this.cbxCircuits.Location = new System.Drawing.Point(16, 32);
            this.cbxCircuits.Name = "cbxCircuits";
            this.cbxCircuits.Size = new System.Drawing.Size(237, 28);
            this.cbxCircuits.TabIndex = 4;
            this.cbxCircuits.SelectedIndexChanged += new System.EventHandler(this.cbxCircuits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Circuit";
            // 
            // tbxPrix
            // 
            this.tbxPrix.Location = new System.Drawing.Point(118, 66);
            this.tbxPrix.Name = "tbxPrix";
            this.tbxPrix.ReadOnly = true;
            this.tbxPrix.Size = new System.Drawing.Size(135, 26);
            this.tbxPrix.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prix";
            // 
            // btnModifier
            // 
            this.btnModifier.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModifier.Location = new System.Drawing.Point(16, 137);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 34);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(142, 137);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(111, 34);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // ModifierCircuitForm
            // 
            this.AcceptButton = this.btnModifier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(283, 183);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCircuits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNvPrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModifierCircuitForm";
            this.Text = "Modifier un circuit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNvPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCircuits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
    }
}