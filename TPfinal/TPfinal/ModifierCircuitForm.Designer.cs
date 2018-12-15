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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCircuits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.nudNvPrix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNvPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nouveau prix";
            // 
            // cbxCircuits
            // 
            this.cbxCircuits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCircuits.FormattingEnabled = true;
            this.cbxCircuits.Location = new System.Drawing.Point(23, 28);
            this.cbxCircuits.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxCircuits.Name = "cbxCircuits";
            this.cbxCircuits.Size = new System.Drawing.Size(248, 21);
            this.cbxCircuits.TabIndex = 4;
            this.cbxCircuits.SelectedIndexChanged += new System.EventHandler(this.cbxCircuits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Circuit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxPrix
            // 
            this.tbxPrix.Location = new System.Drawing.Point(23, 68);
            this.tbxPrix.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbxPrix.Name = "tbxPrix";
            this.tbxPrix.ReadOnly = true;
            this.tbxPrix.Size = new System.Drawing.Size(248, 20);
            this.tbxPrix.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prix actuel";
            // 
            // btnModifier
            // 
            this.btnModifier.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModifier.Location = new System.Drawing.Point(24, 140);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(117, 36);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(153, 140);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(117, 36);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // nudNvPrix
            // 
            this.nudNvPrix.DecimalPlaces = 2;
            this.nudNvPrix.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNvPrix.Location = new System.Drawing.Point(24, 108);
            this.nudNvPrix.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.nudNvPrix.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNvPrix.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNvPrix.Name = "nudNvPrix";
            this.nudNvPrix.Size = new System.Drawing.Size(246, 20);
            this.nudNvPrix.TabIndex = 17;
            this.nudNvPrix.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ModifierCircuitForm
            // 
            this.AcceptButton = this.btnModifier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(294, 195);
            this.Controls.Add(this.nudNvPrix);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCircuits);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifierCircuitForm";
            this.Text = "Modifier un circuit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifierCircuitForm_FormClosing);
            this.Load += new System.EventHandler(this.ModifierCircuitForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModifierCircuitForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.nudNvPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCircuits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.NumericUpDown nudNvPrix;
    }
}