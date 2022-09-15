namespace bucuriaDarului
{
    partial class adminStartPage
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NumeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenumeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrDeOreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeC,
            this.PrenumeC,
            this.RegDate,
            this.NrDeOreC});
            this.dataGridView.Location = new System.Drawing.Point(116, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(553, 344);
            this.dataGridView.TabIndex = 0;
            // 
            // NumeC
            // 
            this.NumeC.HeaderText = "Nume";
            this.NumeC.MinimumWidth = 6;
            this.NumeC.Name = "NumeC";
            this.NumeC.ReadOnly = true;
            this.NumeC.Width = 125;
            // 
            // PrenumeC
            // 
            this.PrenumeC.HeaderText = "Prenume";
            this.PrenumeC.MinimumWidth = 6;
            this.PrenumeC.Name = "PrenumeC";
            this.PrenumeC.ReadOnly = true;
            this.PrenumeC.Width = 125;
            // 
            // RegDate
            // 
            this.RegDate.HeaderText = "Data";
            this.RegDate.MinimumWidth = 6;
            this.RegDate.Name = "RegDate";
            this.RegDate.ReadOnly = true;
            this.RegDate.Width = 125;
            // 
            // NrDeOreC
            // 
            this.NrDeOreC.HeaderText = "Nr de ore";
            this.NrDeOreC.MinimumWidth = 6;
            this.NrDeOreC.Name = "NrDeOreC";
            this.NrDeOreC.ReadOnly = true;
            this.NrDeOreC.Width = 125;
            // 
            // adminStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 606);
            this.Controls.Add(this.dataGridView);
            this.Name = "adminStartPage";
            this.Text = "adminStartPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn NumeC;
        private DataGridViewTextBoxColumn PrenumeC;
        private DataGridViewTextBoxColumn RegDate;
        private DataGridViewTextBoxColumn NrDeOreC;
    }
}