namespace TPfinal
{
    partial class AfficherImageMonument
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
            this.components = new System.ComponentModel.Container();
            this.PBX_Image = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // PBX_Image
            // 
            this.PBX_Image.AllowDrop = true;
            this.PBX_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBX_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBX_Image.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.PBX_Image.Enabled = false;
            this.PBX_Image.ImportImageText = "Import image from file...";
            this.PBX_Image.Location = new System.Drawing.Point(12, 12);
            this.PBX_Image.Name = "PBX_Image";
            this.PBX_Image.OpenFileDialogTitle = "Please choose image an file";
            this.PBX_Image.PasteMenuText = "Paste image from clipboard";
            this.PBX_Image.Size = new System.Drawing.Size(454, 420);
            this.PBX_Image.TabIndex = 0;
            this.PBX_Image.TabStop = false;
            // 
            // AfficherImageMonument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.PBX_Image);
            this.Name = "AfficherImageMonument";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AfficherImageMonument_FormClosing);
            this.Load += new System.EventHandler(this.AfficherImageMonument_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageMonument_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoManagerClient.ImageBox PBX_Image;
    }
}