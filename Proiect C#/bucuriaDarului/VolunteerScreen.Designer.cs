namespace bucuriaDarului
{
    partial class VolunteerScreen
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.NrTelefonSearch = new System.Windows.Forms.TextBox();
            this.CautareNrTelefon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NrTelefonSearch
            // 
            this.NrTelefonSearch.Location = new System.Drawing.Point(282, 140);
            this.NrTelefonSearch.Name = "NrTelefonSearch";
            this.NrTelefonSearch.Size = new System.Drawing.Size(125, 27);
            this.NrTelefonSearch.TabIndex = 3;
            // 
            // CautareNrTelefon
            // 
            this.CautareNrTelefon.Location = new System.Drawing.Point(394, 250);
            this.CautareNrTelefon.Name = "CautareNrTelefon";
            this.CautareNrTelefon.Size = new System.Drawing.Size(94, 29);
            this.CautareNrTelefon.TabIndex = 4;
            this.CautareNrTelefon.Text = "Cautare";
            this.CautareNrTelefon.UseVisualStyleBackColor = true;
            this.CautareNrTelefon.Click += new System.EventHandler(this.CautareNrTelefon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nr Telefon ptr cautare";
            // 
            // VolunteerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CautareNrTelefon);
            this.Controls.Add(this.NrTelefonSearch);
            this.Name = "VolunteerScreen";
            this.Text = "VolunteerScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontDialog fontDialog1;
        private TextBox NrTelefonSearch;
        private Button CautareNrTelefon;
        private Label label1;
    }
}