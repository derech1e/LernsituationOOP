namespace LernsituationOOP
{
    partial class FrmHaupt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMieten = new System.Windows.Forms.Button();
            this.btnMitarbeiter = new System.Windows.Forms.Button();
            this.btnGeprüfteRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMieten
            // 
            this.btnMieten.Location = new System.Drawing.Point(13, 14);
            this.btnMieten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMieten.Name = "btnMieten";
            this.btnMieten.Size = new System.Drawing.Size(179, 132);
            this.btnMieten.TabIndex = 0;
            this.btnMieten.Text = "Auto Reservieren";
            this.btnMieten.UseVisualStyleBackColor = true;
            this.btnMieten.Click += new System.EventHandler(this.btnMieten_Click);
            // 
            // btnMitarbeiter
            // 
            this.btnMitarbeiter.Location = new System.Drawing.Point(200, 14);
            this.btnMitarbeiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMitarbeiter.Name = "btnMitarbeiter";
            this.btnMitarbeiter.Size = new System.Drawing.Size(179, 132);
            this.btnMitarbeiter.TabIndex = 1;
            this.btnMitarbeiter.Text = "Mitarbeiter/ Reservierungen Prüfen";
            this.btnMitarbeiter.UseVisualStyleBackColor = true;
            this.btnMitarbeiter.Click += new System.EventHandler(this.btnMitarbeiter_Click);
            // 
            // btnGeprüfteRes
            // 
            this.btnGeprüfteRes.Location = new System.Drawing.Point(387, 14);
            this.btnGeprüfteRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeprüfteRes.Name = "btnGeprüfteRes";
            this.btnGeprüfteRes.Size = new System.Drawing.Size(179, 132);
            this.btnGeprüfteRes.TabIndex = 2;
            this.btnGeprüfteRes.Text = "Geprüfte Reservierungen";
            this.btnGeprüfteRes.UseVisualStyleBackColor = true;
            this.btnGeprüfteRes.Click += new System.EventHandler(this.btnGeprüfteRes_Click);
            // 
            // FrmHaupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 160);
            this.Controls.Add(this.btnGeprüfteRes);
            this.Controls.Add(this.btnMitarbeiter);
            this.Controls.Add(this.btnMieten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHaupt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Übersicht Wählen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHaupt_FormClosing);
            this.Load += new System.EventHandler(this.FrmHaupt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMieten;
        private System.Windows.Forms.Button btnMitarbeiter;
        private System.Windows.Forms.Button btnGeprüfteRes;
    }
}

