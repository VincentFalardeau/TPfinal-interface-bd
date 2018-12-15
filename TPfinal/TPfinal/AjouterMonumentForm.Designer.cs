namespace TPfinal
{
    partial class AjouterMonumentForm
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
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DATE_Monument = new System.Windows.Forms.DateTimePicker();
            this.RTBX_Histoire = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Accepter = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.Control_Stars = new EvaluationDemo.Stars();
            this.PBX_Monument = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Monument)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(16, 29);
            this.TBX_Nom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TBX_Nom.MaxLength = 30;
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(159, 20);
            this.TBX_Nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // DATE_Monument
            // 
            this.DATE_Monument.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_Monument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_Monument.Location = new System.Drawing.Point(17, 68);
            this.DATE_Monument.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DATE_Monument.Name = "DATE_Monument";
            this.DATE_Monument.Size = new System.Drawing.Size(159, 20);
            this.DATE_Monument.TabIndex = 5;
            // 
            // RTBX_Histoire
            // 
            this.RTBX_Histoire.AcceptsTab = true;
            this.RTBX_Histoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBX_Histoire.Location = new System.Drawing.Point(17, 144);
            this.RTBX_Histoire.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RTBX_Histoire.MaxLength = 100;
            this.RTBX_Histoire.Name = "RTBX_Histoire";
            this.RTBX_Histoire.Size = new System.Drawing.Size(159, 35);
            this.RTBX_Histoire.TabIndex = 6;
            this.RTBX_Histoire.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date de création";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre d\'étoiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Histoire";
            // 
            // BTN_Accepter
            // 
            this.BTN_Accepter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Accepter.Location = new System.Drawing.Point(195, 234);
            this.BTN_Accepter.Margin = new System.Windows.Forms.Padding(7, 6, 2, 6);
            this.BTN_Accepter.Name = "BTN_Accepter";
            this.BTN_Accepter.Size = new System.Drawing.Size(100, 35);
            this.BTN_Accepter.TabIndex = 12;
            this.BTN_Accepter.Text = "Ajouter";
            this.BTN_Accepter.UseVisualStyleBackColor = true;
            this.BTN_Accepter.Click += new System.EventHandler(this.BTN_Accepter_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(300, 234);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(2, 6, 7, 6);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(100, 35);
            this.BTN_Annuler.TabIndex = 13;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix";
            // 
            // nudPrix
            // 
            this.nudPrix.DecimalPlaces = 2;
            this.nudPrix.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPrix.Location = new System.Drawing.Point(16, 106);
            this.nudPrix.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.nudPrix.Size = new System.Drawing.Size(158, 20);
            this.nudPrix.TabIndex = 16;
            this.nudPrix.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Control_Stars
            // 
            this.Control_Stars.Location = new System.Drawing.Point(18, 195);
            this.Control_Stars.Margin = new System.Windows.Forms.Padding(2);
            this.Control_Stars.MinimumSize = new System.Drawing.Size(127, 25);
            this.Control_Stars.Name = "Control_Stars";
            this.Control_Stars.Size = new System.Drawing.Size(127, 25);
            this.Control_Stars.StarsCount = 5;
            this.Control_Stars.TabIndex = 4;
            this.Control_Stars.Value = 0;
            // 
            // PBX_Monument
            // 
            this.PBX_Monument.AllowDrop = true;
            this.PBX_Monument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBX_Monument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Monument.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.PBX_Monument.ImportImageText = "Import image from file...";
            this.PBX_Monument.Location = new System.Drawing.Point(195, 15);
            this.PBX_Monument.Margin = new System.Windows.Forms.Padding(2);
            this.PBX_Monument.Name = "PBX_Monument";
            this.PBX_Monument.OpenFileDialogTitle = "Please choose image an file";
            this.PBX_Monument.PasteMenuText = "Paste image from clipboard";
            this.PBX_Monument.Size = new System.Drawing.Size(205, 205);
            this.PBX_Monument.TabIndex = 0;
            this.PBX_Monument.TabStop = false;
            this.PBX_Monument.BackgroundImageChanged += new System.EventHandler(this.PBX_Monument_BackgroundImageChanged);
            // 
            // AjouterMonumentForm
            // 
            this.AcceptButton = this.BTN_Accepter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(418, 284);
            this.Controls.Add(this.PBX_Monument);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.RTBX_Histoire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Accepter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DATE_Monument);
            this.Controls.Add(this.Control_Stars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AjouterMonumentForm";
            this.Text = "Ajouter un monument";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjouterMonumentForm_FormClosing);
            this.Load += new System.EventHandler(this.NouveauMonumentForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AjouterMonumentForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Monument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.Label label1;
        private EvaluationDemo.Stars Control_Stars;
        private System.Windows.Forms.DateTimePicker DATE_Monument;
        private System.Windows.Forms.RichTextBox RTBX_Histoire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Accepter;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private PhotoManagerClient.ImageBox PBX_Monument;
    }
}