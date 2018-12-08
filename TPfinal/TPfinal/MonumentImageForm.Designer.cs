namespace TPfinal
{
    partial class MonumentImageForm
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
            this.TBX_NewImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Accept = new System.Windows.Forms.Button();
            this.PBX_Dummy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Dummy)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_NewImage
            // 
            this.TBX_NewImage.Location = new System.Drawing.Point(31, 48);
            this.TBX_NewImage.Name = "TBX_NewImage";
            this.TBX_NewImage.Size = new System.Drawing.Size(363, 26);
            this.TBX_NewImage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lien internet vers l\'image";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(276, 93);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(118, 36);
            this.BTN_Cancel.TabIndex = 15;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Accept
            // 
            this.BTN_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Accept.Location = new System.Drawing.Point(139, 93);
            this.BTN_Accept.Name = "BTN_Accept";
            this.BTN_Accept.Size = new System.Drawing.Size(118, 36);
            this.BTN_Accept.TabIndex = 14;
            this.BTN_Accept.Text = "Accepter";
            this.BTN_Accept.UseVisualStyleBackColor = true;
            this.BTN_Accept.Click += new System.EventHandler(this.BTN_Accept_Click);
            // 
            // PBX_Dummy
            // 
            this.PBX_Dummy.Location = new System.Drawing.Point(94, 98);
            this.PBX_Dummy.Name = "PBX_Dummy";
            this.PBX_Dummy.Size = new System.Drawing.Size(24, 26);
            this.PBX_Dummy.TabIndex = 16;
            this.PBX_Dummy.TabStop = false;
            this.PBX_Dummy.Visible = false;
            // 
            // MonumentImageForm
            // 
            this.AcceptButton = this.BTN_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(425, 151);
            this.Controls.Add(this.PBX_Dummy);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Accept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_NewImage);
            this.Name = "MonumentImageForm";
            this.Text = "Ajouter une image";
            this.Load += new System.EventHandler(this.MonumentImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Dummy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_NewImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Accept;
        private System.Windows.Forms.PictureBox PBX_Dummy;
    }
}