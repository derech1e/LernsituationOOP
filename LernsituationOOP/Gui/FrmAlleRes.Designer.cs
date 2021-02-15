namespace LernsituationOOP.Gui
{
    partial class FrmAlleRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlleRes));
            this.gBox = new System.Windows.Forms.GroupBox();
            this.listBoxAngenommen = new System.Windows.Forms.ListBox();
            this.gBoxAbgelehnt = new System.Windows.Forms.GroupBox();
            this.listBoxAbgelehnt = new System.Windows.Forms.ListBox();
            this.txtBoxInfos = new System.Windows.Forms.RichTextBox();
            this.gBoxInfos = new System.Windows.Forms.GroupBox();
            this.gBox.SuspendLayout();
            this.gBoxAbgelehnt.SuspendLayout();
            this.gBoxInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.listBoxAngenommen);
            this.gBox.Location = new System.Drawing.Point(13, 14);
            this.gBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox.Name = "gBox";
            this.gBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox.Size = new System.Drawing.Size(300, 576);
            this.gBox.TabIndex = 0;
            this.gBox.TabStop = false;
            this.gBox.Text = "Akzeptierte Reservierungen";
            // 
            // listBoxAngenommen
            // 
            this.listBoxAngenommen.FormattingEnabled = true;
            this.listBoxAngenommen.ItemHeight = 20;
            this.listBoxAngenommen.Location = new System.Drawing.Point(7, 27);
            this.listBoxAngenommen.Name = "listBoxAngenommen";
            this.listBoxAngenommen.Size = new System.Drawing.Size(286, 544);
            this.listBoxAngenommen.TabIndex = 0;
            this.listBoxAngenommen.SelectedIndexChanged += new System.EventHandler(this.listBoxAngenommen_SelectedIndexChanged);
            // 
            // gBoxAbgelehnt
            // 
            this.gBoxAbgelehnt.Controls.Add(this.listBoxAbgelehnt);
            this.gBoxAbgelehnt.Location = new System.Drawing.Point(321, 14);
            this.gBoxAbgelehnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBoxAbgelehnt.Name = "gBoxAbgelehnt";
            this.gBoxAbgelehnt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBoxAbgelehnt.Size = new System.Drawing.Size(300, 576);
            this.gBoxAbgelehnt.TabIndex = 1;
            this.gBoxAbgelehnt.TabStop = false;
            this.gBoxAbgelehnt.Text = "Abgelehnte Reservierungen";
            // 
            // listBoxAbgelehnt
            // 
            this.listBoxAbgelehnt.FormattingEnabled = true;
            this.listBoxAbgelehnt.ItemHeight = 20;
            this.listBoxAbgelehnt.Location = new System.Drawing.Point(7, 27);
            this.listBoxAbgelehnt.Name = "listBoxAbgelehnt";
            this.listBoxAbgelehnt.Size = new System.Drawing.Size(286, 544);
            this.listBoxAbgelehnt.TabIndex = 1;
            this.listBoxAbgelehnt.SelectedIndexChanged += new System.EventHandler(this.listBoxAbgelehnt_SelectedIndexChanged);
            // 
            // txtBoxInfos
            // 
            this.txtBoxInfos.Location = new System.Drawing.Point(6, 24);
            this.txtBoxInfos.Name = "txtBoxInfos";
            this.txtBoxInfos.ReadOnly = true;
            this.txtBoxInfos.Size = new System.Drawing.Size(427, 547);
            this.txtBoxInfos.TabIndex = 2;
            this.txtBoxInfos.Text = "";
            // 
            // gBoxInfos
            // 
            this.gBoxInfos.Controls.Add(this.txtBoxInfos);
            this.gBoxInfos.Location = new System.Drawing.Point(628, 14);
            this.gBoxInfos.Name = "gBoxInfos";
            this.gBoxInfos.Size = new System.Drawing.Size(439, 575);
            this.gBoxInfos.TabIndex = 3;
            this.gBoxInfos.TabStop = false;
            this.gBoxInfos.Text = "Informationen";
            // 
            // FrmAlleRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1081, 601);
            this.Controls.Add(this.gBoxInfos);
            this.Controls.Add(this.gBoxAbgelehnt);
            this.Controls.Add(this.gBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAlleRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alle Reservierungen";
            this.Load += new System.EventHandler(this.FrmAlleRes_Load);
            this.gBox.ResumeLayout(false);
            this.gBoxAbgelehnt.ResumeLayout(false);
            this.gBoxInfos.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.GroupBox gBoxAbgelehnt;
        private System.Windows.Forms.ListBox listBoxAngenommen;
        private System.Windows.Forms.ListBox listBoxAbgelehnt;
        private System.Windows.Forms.RichTextBox txtBoxInfos;
        private System.Windows.Forms.GroupBox gBoxInfos;
    }
}