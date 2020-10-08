namespace LernsituationOOP.de.tnuerk.gui
{
    partial class FrmPrüfen
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
            this.listBoxEinträge = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnUnCheck = new System.Windows.Forms.Button();
            this.txtBoxResInfos = new System.Windows.Forms.RichTextBox();
            this.gBoxReservierungen = new System.Windows.Forms.GroupBox();
            this.gBoxInformationen = new System.Windows.Forms.GroupBox();
            this.gBoxReservierungen.SuspendLayout();
            this.gBoxInformationen.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEinträge
            // 
            this.listBoxEinträge.FormattingEnabled = true;
            this.listBoxEinträge.ItemHeight = 20;
            this.listBoxEinträge.Location = new System.Drawing.Point(7, 27);
            this.listBoxEinträge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEinträge.Name = "listBoxEinträge";
            this.listBoxEinträge.Size = new System.Drawing.Size(236, 344);
            this.listBoxEinträge.TabIndex = 0;
            this.listBoxEinträge.SelectedIndexChanged += new System.EventHandler(this.listBoxEinträge_SelectedIndexChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Lime;
            this.btnCheck.Location = new System.Drawing.Point(788, 80);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(143, 119);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "✓";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUnCheck
            // 
            this.btnUnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.btnUnCheck.ForeColor = System.Drawing.Color.Red;
            this.btnUnCheck.Location = new System.Drawing.Point(788, 264);
            this.btnUnCheck.Name = "btnUnCheck";
            this.btnUnCheck.Size = new System.Drawing.Size(143, 119);
            this.btnUnCheck.TabIndex = 2;
            this.btnUnCheck.Text = "✗";
            this.btnUnCheck.UseVisualStyleBackColor = true;
            // 
            // txtBoxResInfos
            // 
            this.txtBoxResInfos.Location = new System.Drawing.Point(6, 27);
            this.txtBoxResInfos.Name = "txtBoxResInfos";
            this.txtBoxResInfos.ReadOnly = true;
            this.txtBoxResInfos.Size = new System.Drawing.Size(461, 355);
            this.txtBoxResInfos.TabIndex = 3;
            this.txtBoxResInfos.Text = "";
            // 
            // gBoxReservierungen
            // 
            this.gBoxReservierungen.Controls.Add(this.listBoxEinträge);
            this.gBoxReservierungen.Location = new System.Drawing.Point(12, 12);
            this.gBoxReservierungen.Name = "gBoxReservierungen";
            this.gBoxReservierungen.Size = new System.Drawing.Size(253, 388);
            this.gBoxReservierungen.TabIndex = 4;
            this.gBoxReservierungen.TabStop = false;
            this.gBoxReservierungen.Text = "Reservierungen auf";
            // 
            // gBoxInformationen
            // 
            this.gBoxInformationen.Controls.Add(this.txtBoxResInfos);
            this.gBoxInformationen.Location = new System.Drawing.Point(271, 12);
            this.gBoxInformationen.Name = "gBoxInformationen";
            this.gBoxInformationen.Size = new System.Drawing.Size(473, 388);
            this.gBoxInformationen.TabIndex = 5;
            this.gBoxInformationen.TabStop = false;
            this.gBoxInformationen.Text = "Reservierungsinformationen";
            // 
            // FrmPrüfen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 415);
            this.Controls.Add(this.gBoxInformationen);
            this.Controls.Add(this.gBoxReservierungen);
            this.Controls.Add(this.btnUnCheck);
            this.Controls.Add(this.btnCheck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrüfen";
            this.Text = "FrmPrüfen";
            this.Load += new System.EventHandler(this.FrmPrüfen_Load);
            this.gBoxReservierungen.ResumeLayout(false);
            this.gBoxInformationen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEinträge;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUnCheck;
        private System.Windows.Forms.RichTextBox txtBoxResInfos;
        private System.Windows.Forms.GroupBox gBoxReservierungen;
        private System.Windows.Forms.GroupBox gBoxInformationen;
    }
}