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
            this.btnOk = new System.Windows.Forms.Button();
            this.pbxMonument = new System.Windows.Forms.PictureBox();
            this.starsMonument = new EvaluationDemo.Stars();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonument)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Circuit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxCircuits
            // 
            this.cbxCircuits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCircuits.FormattingEnabled = true;
            this.cbxCircuits.Location = new System.Drawing.Point(14, 24);
            this.cbxCircuits.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxCircuits.Name = "cbxCircuits";
            this.cbxCircuits.Size = new System.Drawing.Size(159, 21);
            this.cbxCircuits.TabIndex = 6;
            this.cbxCircuits.SelectedIndexChanged += new System.EventHandler(this.cbxCircuits_SelectedIndexChanged);
            // 
            // lbxMonuments
            // 
            this.lbxMonuments.FormattingEnabled = true;
            this.lbxMonuments.Location = new System.Drawing.Point(14, 64);
            this.lbxMonuments.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbxMonuments.Name = "lbxMonuments";
            this.lbxMonuments.Size = new System.Drawing.Size(159, 69);
            this.lbxMonuments.TabIndex = 8;
            this.lbxMonuments.SelectedIndexChanged += new System.EventHandler(this.lbxMonuments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monuments";
            // 
            // rtbInfos
            // 
            this.rtbInfos.Location = new System.Drawing.Point(14, 145);
            this.rtbInfos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rtbInfos.Name = "rtbInfos";
            this.rtbInfos.ReadOnly = true;
            this.rtbInfos.Size = new System.Drawing.Size(159, 83);
            this.rtbInfos.TabIndex = 10;
            this.rtbInfos.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 240);
            this.btnOk.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(158, 35);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pbxMonument
            // 
            this.pbxMonument.BackColor = System.Drawing.Color.Transparent;
            this.pbxMonument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMonument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxMonument.Location = new System.Drawing.Point(0, 0);
            this.pbxMonument.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pbxMonument.Name = "pbxMonument";
            this.pbxMonument.Size = new System.Drawing.Size(202, 202);
            this.pbxMonument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMonument.TabIndex = 14;
            this.pbxMonument.TabStop = false;
            // 
            // starsMonument
            // 
            this.starsMonument.BackColor = System.Drawing.Color.Transparent;
            this.starsMonument.Enabled = false;
            this.starsMonument.Location = new System.Drawing.Point(187, 240);
            this.starsMonument.Margin = new System.Windows.Forms.Padding(2);
            this.starsMonument.MinimumSize = new System.Drawing.Size(67, 13);
            this.starsMonument.Name = "starsMonument";
            this.starsMonument.Size = new System.Drawing.Size(175, 35);
            this.starsMonument.StarsCount = 5;
            this.starsMonument.TabIndex = 13;
            this.starsMonument.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxMonument);
            this.panel1.Location = new System.Drawing.Point(183, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 204);
            this.panel1.TabIndex = 15;
            // 
            // InformationsCircuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.starsMonument);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rtbInfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxMonuments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCircuits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InformationsCircuitForm";
            this.Text = "Informations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformationsCircuitForm_FormClosing);
            this.Load += new System.EventHandler(this.InformationsCircuitForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InformationsCircuitForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonument)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCircuits;
        private System.Windows.Forms.ListBox lbxMonuments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbInfos;
        private System.Windows.Forms.Button btnOk;
        private EvaluationDemo.Stars starsMonument;
        private System.Windows.Forms.PictureBox pbxMonument;
        private System.Windows.Forms.Panel panel1;
    }
}