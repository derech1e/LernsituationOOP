namespace LernsituationOOP.de.tnuerk.gui.prüfung
{
    partial class FrmAddMitarbeiter
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
            this.gBoxPersoenlich = new System.Windows.Forms.GroupBox();
            this.dTimeGeb = new System.Windows.Forms.DateTimePicker();
            this.btnPWAnzeigen = new System.Windows.Forms.Button();
            this.txtBoxPW = new System.Windows.Forms.MaskedTextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtBoxNachName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGeb = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxVorName = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gBoxPersoenlich
            // 
            this.gBoxPersoenlich.SuspendLayout();
            this.gBoxPersoenlich.Controls.Add(this.dTimeGeb);
            this.gBoxPersoenlich.Controls.Add(this.btnPWAnzeigen);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxPW);
            this.gBoxPersoenlich.Controls.Add(this.lblPW);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxNachName);
            this.gBoxPersoenlich.Controls.Add(this.lblEmail);
            this.gBoxPersoenlich.Controls.Add(this.lblGeb);
            this.gBoxPersoenlich.Controls.Add(this.lblAdresse);
            this.gBoxPersoenlich.Controls.Add(this.lblName);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxVorName);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxAdresse);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxEmail);
            this.gBoxPersoenlich.Location = new System.Drawing.Point(13, 14);
            this.gBoxPersoenlich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBoxPersoenlich.Name = "gBoxPersoenlich";
            this.gBoxPersoenlich.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBoxPersoenlich.Size = new System.Drawing.Size(443, 282);
            this.gBoxPersoenlich.TabIndex = 2;
            this.gBoxPersoenlich.TabStop = false;
            this.gBoxPersoenlich.Text = "Persönliche Angaben";
            // 
            // dTimeGeb
            // 
            this.dTimeGeb.Location = new System.Drawing.Point(130, 138);
            this.dTimeGeb.Name = "dTimeGeb";
            this.dTimeGeb.Size = new System.Drawing.Size(296, 26);
            this.dTimeGeb.TabIndex = 4;
            this.dTimeGeb.ValueChanged += new System.EventHandler(this.dTimeGeb_ValueChanged);
            // 
            // btnPWAnzeigen
            // 
            this.btnPWAnzeigen.Location = new System.Drawing.Point(296, 233);
            this.btnPWAnzeigen.Name = "btnPWAnzeigen";
            this.btnPWAnzeigen.Size = new System.Drawing.Size(132, 30);
            this.btnPWAnzeigen.TabIndex = 20;
            this.btnPWAnzeigen.Text = "Anzeigen";
            this.btnPWAnzeigen.UseVisualStyleBackColor = true;
            this.btnPWAnzeigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPWAnzeigen_MouseDown);
            this.btnPWAnzeigen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPWAnzeigen_MouseUp);
            // 
            // txtBoxPW
            // 
            this.txtBoxPW.Location = new System.Drawing.Point(130, 235);
            this.txtBoxPW.Name = "txtBoxPW";
            this.txtBoxPW.Size = new System.Drawing.Size(159, 26);
            this.txtBoxPW.TabIndex = 19;
            this.txtBoxPW.UseSystemPasswordChar = true;
            this.txtBoxPW.TextChanged += new System.EventHandler(this.txtBoxPW_TextChanged);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(49, 238);
            this.lblPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(78, 20);
            this.lblPW.TabIndex = 18;
            this.lblPW.Text = "Passwort:";
            // 
            // txtBoxNachName
            // 
            this.txtBoxNachName.Location = new System.Drawing.Point(280, 40);
            this.txtBoxNachName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNachName.Name = "txtBoxNachName";
            this.txtBoxNachName.Size = new System.Drawing.Size(147, 26);
            this.txtBoxNachName.TabIndex = 2;
            this.txtBoxNachName.TextChanged += new System.EventHandler(this.txtBoxNachName_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(66, 192);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblGeb
            // 
            this.lblGeb.AutoSize = true;
            this.lblGeb.Location = new System.Drawing.Point(29, 143);
            this.lblGeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeb.Name = "lblGeb";
            this.lblGeb.Size = new System.Drawing.Size(94, 20);
            this.lblGeb.TabIndex = 14;
            this.lblGeb.Text = "Geburtstag:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(54, 94);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(72, 20);
            this.lblAdresse.TabIndex = 13;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // txtBoxVorName
            // 
            this.txtBoxVorName.Location = new System.Drawing.Point(131, 40);
            this.txtBoxVorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxVorName.Name = "txtBoxVorName";
            this.txtBoxVorName.Size = new System.Drawing.Size(142, 26);
            this.txtBoxVorName.TabIndex = 1;
            this.txtBoxVorName.TextChanged += new System.EventHandler(this.txtBoxVorName_TextChanged);
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(131, 90);
            this.txtBoxAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(297, 26);
            this.txtBoxAdresse.TabIndex = 3;
            this.txtBoxAdresse.TextChanged += new System.EventHandler(this.txtBoxAdresse_TextChanged);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(131, 188);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(297, 26);
            this.txtBoxEmail.TabIndex = 5;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(12, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(219, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Mitarbeiter Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(237, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(218, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Abbrechen";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmAddMitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(470, 370);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gBoxPersoenlich);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddMitarbeiter";
            this.Text = "FrmAddMitarbeiter";
            this.gBoxPersoenlich.ResumeLayout(false);
            this.gBoxPersoenlich.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxPersoenlich;
        private System.Windows.Forms.TextBox txtBoxNachName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGeb;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxVorName;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.MaskedTextBox txtBoxPW;
        private System.Windows.Forms.Button btnPWAnzeigen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dTimeGeb;
    }
}