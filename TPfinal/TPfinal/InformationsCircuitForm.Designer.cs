namespace TPfinal
{
    partial class InformationsCircuitForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCircuits = new System.Windows.Forms.ComboBox();
            this.lbxMonuments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbInfos = new System.Windows.Forms.RichTextBox();
            this.pbxMonument = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonument)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Circuit";
            // 
            // cbxCircuits
            // 
            this.cbxCircuits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCircuits.FormattingEnabled = true;
            this.cbxCircuits.Location = new System.Drawing.Point(16, 32);
            this.cbxCircuits.Name = "cbxCircuits";
            this.cbxCircuits.Size = new System.Drawing.Size(237, 28);
            this.cbxCircuits.TabIndex = 6;
            this.cbxCircuits.SelectedIndexChanged += new System.EventHandler(this.cbxCircuits_SelectedIndexChanged);
            // 
            // lbxMonuments
            // 
            this.lbxMonuments.FormattingEnabled = true;
            this.lbxMonuments.ItemHeight = 20;
            this.lbxMonuments.Location = new System.Drawing.Point(16, 86);
            this.lbxMonuments.Name = "lbxMonuments";
            this.lbxMonuments.Size = new System.Drawing.Size(237, 144);
            this.lbxMonuments.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monuments";
            // 
            // rtbInfos
            // 
            this.rtbInfos.Location = new System.Drawing.Point(16, 236);
            this.rtbInfos.Name = "rtbInfos";
            this.rtbInfos.Size = new System.Drawing.Size(457, 106);
            this.rtbInfos.TabIndex = 10;
            this.rtbInfos.Text = "";
            // 
            // pbxMonument
            // 
            this.pbxMonument.Location = new System.Drawing.Point(259, 32);
            this.pbxMonument.Name = "pbxMonument";
            this.pbxMonument.Size = new System.Drawing.Size(214, 198);
            this.pbxMonument.TabIndex = 11;
            this.pbxMonument.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 356);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(467, 45);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // InformationsCircuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 415);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbxMonument);
            this.Controls.Add(this.rtbInfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxMonuments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCircuits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InformationsCircuitForm";
            this.Text = "Informations";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCircuits;
        private System.Windows.Forms.ListBox lbxMonuments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbInfos;
        private System.Windows.Forms.PictureBox pbxMonument;
        private System.Windows.Forms.Button btnOk;
    }
}