
namespace Farmacie_app
{
    partial class interfata2
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Cauta = new System.Windows.Forms.Button();
            this.Updatebaza = new System.Windows.Forms.Button();
            this.Medicamente = new System.Windows.Forms.Button();
            this.Angajati = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDekstopPane = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.Cauta);
            this.panelMenu.Controls.Add(this.Updatebaza);
            this.panelMenu.Controls.Add(this.Medicamente);
            this.panelMenu.Controls.Add(this.Angajati);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // Cauta
            // 
            this.Cauta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cauta.FlatAppearance.BorderSize = 0;
            this.Cauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cauta.ForeColor = System.Drawing.Color.Gainsboro;
            this.Cauta.Location = new System.Drawing.Point(0, 260);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(220, 60);
            this.Cauta.TabIndex = 5;
            this.Cauta.Text = "Search";
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // Updatebaza
            // 
            this.Updatebaza.Dock = System.Windows.Forms.DockStyle.Top;
            this.Updatebaza.FlatAppearance.BorderSize = 0;
            this.Updatebaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Updatebaza.ForeColor = System.Drawing.Color.Gainsboro;
            this.Updatebaza.Location = new System.Drawing.Point(0, 200);
            this.Updatebaza.Name = "Updatebaza";
            this.Updatebaza.Size = new System.Drawing.Size(220, 60);
            this.Updatebaza.TabIndex = 4;
            this.Updatebaza.Text = "Update";
            this.Updatebaza.UseVisualStyleBackColor = true;
            this.Updatebaza.Click += new System.EventHandler(this.Updatebaza_Click);
            // 
            // Medicamente
            // 
            this.Medicamente.Dock = System.Windows.Forms.DockStyle.Top;
            this.Medicamente.FlatAppearance.BorderSize = 0;
            this.Medicamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medicamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Medicamente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Medicamente.Location = new System.Drawing.Point(0, 140);
            this.Medicamente.Name = "Medicamente";
            this.Medicamente.Size = new System.Drawing.Size(220, 60);
            this.Medicamente.TabIndex = 3;
            this.Medicamente.Text = "Medicine";
            this.Medicamente.UseVisualStyleBackColor = true;
            this.Medicamente.Click += new System.EventHandler(this.Medicamente_Click);
            // 
            // Angajati
            // 
            this.Angajati.Dock = System.Windows.Forms.DockStyle.Top;
            this.Angajati.FlatAppearance.BorderSize = 0;
            this.Angajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Angajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Angajati.ForeColor = System.Drawing.Color.Gainsboro;
            this.Angajati.Location = new System.Drawing.Point(0, 80);
            this.Angajati.Name = "Angajati";
            this.Angajati.Size = new System.Drawing.Size(220, 60);
            this.Angajati.TabIndex = 2;
            this.Angajati.Text = "Staff";
            this.Angajati.UseVisualStyleBackColor = true;
            this.Angajati.Click += new System.EventHandler(this.Angajati_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(580, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(250, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDekstopPane
            // 
            this.panelDekstopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDekstopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDekstopPane.Name = "panelDekstopPane";
            this.panelDekstopPane.Size = new System.Drawing.Size(580, 370);
            this.panelDekstopPane.TabIndex = 2;
            this.panelDekstopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.Staff_Paint);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 0;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // interfata2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDekstopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "interfata2";
            this.Text = "interfata2";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Angajati;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.Button Updatebaza;
        private System.Windows.Forms.Button Medicamente;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDekstopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}