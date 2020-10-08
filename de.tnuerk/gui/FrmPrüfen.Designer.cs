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
            this.SuspendLayout();
            // 
            // listBoxEinträge
            // 
            this.listBoxEinträge.FormattingEnabled = true;
            this.listBoxEinträge.ItemHeight = 20;
            this.listBoxEinträge.Location = new System.Drawing.Point(18, 18);
            this.listBoxEinträge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEinträge.Name = "listBoxEinträge";
            this.listBoxEinträge.Size = new System.Drawing.Size(236, 544);
            this.listBoxEinträge.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(713, 503);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 65);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "✓";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnUnCheck
            // 
            this.btnUnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnCheck.Location = new System.Drawing.Point(831, 503);
            this.btnUnCheck.Name = "btnUnCheck";
            this.btnUnCheck.Size = new System.Drawing.Size(112, 65);
            this.btnUnCheck.TabIndex = 2;
            this.btnUnCheck.Text = "✗";
            this.btnUnCheck.UseVisualStyleBackColor = true;
            // 
            // FrmPrüfen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 580);
            this.Controls.Add(this.btnUnCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.listBoxEinträge);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrüfen";
            this.Text = "FrmPrüfen";
            this.Load += new System.EventHandler(this.FrmPrüfen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEinträge;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUnCheck;
    }
}