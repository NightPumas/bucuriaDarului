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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolunteerScreen));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.NrTelefonSearch = new System.Windows.Forms.TextBox();
            this.CautareNrTelefon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NrTelefonSearch
            // 
            this.NrTelefonSearch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NrTelefonSearch.Location = new System.Drawing.Point(671, 247);
            this.NrTelefonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NrTelefonSearch.Name = "NrTelefonSearch";
            this.NrTelefonSearch.Size = new System.Drawing.Size(148, 31);
            this.NrTelefonSearch.TabIndex = 3;
            // 
            // CautareNrTelefon
            // 
            this.CautareNrTelefon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CautareNrTelefon.Location = new System.Drawing.Point(739, 291);
            this.CautareNrTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CautareNrTelefon.Name = "CautareNrTelefon";
            this.CautareNrTelefon.Size = new System.Drawing.Size(80, 27);
            this.CautareNrTelefon.TabIndex = 4;
            this.CautareNrTelefon.Text = "Cautare";
            this.CautareNrTelefon.UseVisualStyleBackColor = true;
            this.CautareNrTelefon.Click += new System.EventHandler(this.CautareNrTelefon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(498, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numar de telefon:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(-2, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1034, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cautare numar de telefon voluntar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VolunteerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1034, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CautareNrTelefon);
            this.Controls.Add(this.NrTelefonSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Label label2;
    }
}