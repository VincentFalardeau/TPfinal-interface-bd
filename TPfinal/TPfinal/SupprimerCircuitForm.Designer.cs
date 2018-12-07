namespace TPfinal
{
    partial class SupprimerCircuitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerCircuitForm));
            this.clbxCircuits = new System.Windows.Forms.CheckedListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.fbtnEffacer = new PhotoManagerClient.FlashButton();
            this.SuspendLayout();
            // 
            // clbxCircuits
            // 
            this.clbxCircuits.CheckOnClick = true;
            this.clbxCircuits.FormattingEnabled = true;
            this.clbxCircuits.Location = new System.Drawing.Point(13, 13);
            this.clbxCircuits.Name = "clbxCircuits";
            this.clbxCircuits.Size = new System.Drawing.Size(258, 277);
            this.clbxCircuits.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 297);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(204, 45);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fbtnEffacer
            // 
            this.fbtnEffacer.BackgroundImage = global::TPfinal.Properties.Resources.trash;
            this.fbtnEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fbtnEffacer.ClickedImage = null;
            this.fbtnEffacer.DisabledImage = null;
            this.fbtnEffacer.Image = ((System.Drawing.Image)(resources.GetObject("fbtnEffacer.Image")));
            this.fbtnEffacer.Location = new System.Drawing.Point(223, 297);
            this.fbtnEffacer.Name = "fbtnEffacer";
            this.fbtnEffacer.NeutralImage = null;
            this.fbtnEffacer.OverImage = null;
            this.fbtnEffacer.Size = new System.Drawing.Size(44, 45);
            this.fbtnEffacer.TabIndex = 14;
            this.fbtnEffacer.Text = "flashButton2";
            this.fbtnEffacer.UseVisualStyleBackColor = true;
            this.fbtnEffacer.Click += new System.EventHandler(this.fbtnEffacer_Click);
            // 
            // SupprimerCircuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 358);
            this.Controls.Add(this.fbtnEffacer);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.clbxCircuits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SupprimerCircuitForm";
            this.Text = "Supprimer des circuits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbxCircuits;
        private System.Windows.Forms.Button btnOk;
        private PhotoManagerClient.FlashButton fbtnEffacer;
    }
}