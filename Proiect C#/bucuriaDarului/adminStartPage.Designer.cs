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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NumarVoluntar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrDeOreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumarVoluntar,
            this.NumeC,
            this.RegDate,
            this.NrDeOreC});
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(67, 214);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(607, 593);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // NumarVoluntar
            // 
            this.NumarVoluntar.HeaderText = "ID Voluntar";
            this.NumarVoluntar.MinimumWidth = 6;
            this.NumarVoluntar.Name = "NumarVoluntar";
            this.NumarVoluntar.ReadOnly = true;
            this.NumarVoluntar.Visible = false;
            this.NumarVoluntar.Width = 125;
            // 
            // NumeC
            // 
            this.NumeC.HeaderText = "Nume Prenume";
            this.NumeC.MinimumWidth = 6;
            this.NumeC.Name = "NumeC";
            this.NumeC.ReadOnly = true;
            this.NumeC.Width = 202;
            // 
            // RegDate
            // 
            this.RegDate.HeaderText = "Data";
            this.RegDate.MinimumWidth = 6;
            this.RegDate.Name = "RegDate";
            this.RegDate.ReadOnly = true;
            this.RegDate.Width = 202;
            // 
            // NrDeOreC
            // 
            this.NrDeOreC.HeaderText = "Nr de ore";
            this.NrDeOreC.MinimumWidth = 6;
            this.NrDeOreC.Name = "NrDeOreC";
            this.NrDeOreC.ReadOnly = true;
            this.NrDeOreC.Width = 202;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Crimson;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label18.Location = new System.Drawing.Point(0, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1182, 51);
            this.label18.TabIndex = 38;
            this.label18.Text = "Pontaj voluntari";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.Location = new System.Drawing.Point(1048, 191);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(121, 29);
            this.logoutBtn.TabIndex = 39;
            this.logoutBtn.Text = "Deconectare";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // adminStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::bucuriaDarului.Properties.Resources.MicrosoftTeams_image__79_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1181, 831);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataGridView);
            this.Name = "adminStartPage";
            this.Text = "adminStartPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private Label label18;
        private DataGridViewTextBoxColumn NumarVoluntar;
        private DataGridViewTextBoxColumn NumeC;
        private DataGridViewTextBoxColumn RegDate;
        private DataGridViewTextBoxColumn NrDeOreC;
        private Button logoutBtn;
    }
}