namespace MunicipalServicesApp.Forms
{
    partial class ManageIssuesForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.lblTotalIssues = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalI = new System.Windows.Forms.Label();
            this.lblSubmitted = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblUrgent = new System.Windows.Forms.Label();
            this.lblRoads = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Old Antic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(183, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SUBMITTED MUNICIPAL ISSUES";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(72, 68);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(77, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Issues:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(75, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Location = new System.Drawing.Point(297, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShowAll.Location = new System.Drawing.Point(412, 84);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(87, 23);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvIssues
            // 
            this.dgvIssues.AllowUserToAddRows = false;
            this.dgvIssues.AllowUserToDeleteRows = false;
            this.dgvIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Location = new System.Drawing.Point(75, 225);
            this.dgvIssues.MultiSelect = false;
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.ReadOnly = true;
            this.dgvIssues.RowHeadersVisible = false;
            this.dgvIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssues.Size = new System.Drawing.Size(668, 150);
            this.dgvIssues.TabIndex = 5;
            // 
            // lblTotalIssues
            // 
            this.lblTotalIssues.AutoSize = true;
            this.lblTotalIssues.Location = new System.Drawing.Point(75, 387);
            this.lblTotalIssues.Name = "lblTotalIssues";
            this.lblTotalIssues.Size = new System.Drawing.Size(76, 13);
            this.lblTotalIssues.TabIndex = 6;
            this.lblTotalIssues.Text = "Total Issues: 0";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(75, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Report Issues";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalI
            // 
            this.lblTotalI.AutoSize = true;
            this.lblTotalI.Location = new System.Drawing.Point(75, 121);
            this.lblTotalI.Name = "lblTotalI";
            this.lblTotalI.Size = new System.Drawing.Size(76, 13);
            this.lblTotalI.TabIndex = 8;
            this.lblTotalI.Text = "Total Issues: 0";
            // 
            // lblSubmitted
            // 
            this.lblSubmitted.AutoSize = true;
            this.lblSubmitted.Location = new System.Drawing.Point(158, 121);
            this.lblSubmitted.Name = "lblSubmitted";
            this.lblSubmitted.Size = new System.Drawing.Size(66, 13);
            this.lblSubmitted.TabIndex = 9;
            this.lblSubmitted.Text = "Submitted: 0";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(239, 121);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(75, 13);
            this.lblHigh.TabIndex = 10;
            this.lblHigh.Text = "High Priority: 0";
            // 
            // lblUrgent
            // 
            this.lblUrgent.AutoSize = true;
            this.lblUrgent.Location = new System.Drawing.Point(337, 121);
            this.lblUrgent.Name = "lblUrgent";
            this.lblUrgent.Size = new System.Drawing.Size(51, 13);
            this.lblUrgent.TabIndex = 11;
            this.lblUrgent.Text = "Urgent: 0";
            // 
            // lblRoads
            // 
            this.lblRoads.AutoSize = true;
            this.lblRoads.Location = new System.Drawing.Point(78, 161);
            this.lblRoads.Name = "lblRoads";
            this.lblRoads.Size = new System.Drawing.Size(78, 13);
            this.lblRoads.TabIndex = 12;
            this.lblRoads.Text = "Road Issues: 0";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(351, 415);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(148, 23);
            this.btnViewDetails.TabIndex = 13;
            this.btnViewDetails.Text = "View Issue Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // ManageIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lblRoads);
            this.Controls.Add(this.lblUrgent);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblSubmitted);
            this.Controls.Add(this.lblTotalI);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotalIssues);
            this.Controls.Add(this.dgvIssues);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "ManageIssuesForm";
            this.Text = "Submitted Municipal Issues";
            this.Load += new System.EventHandler(this.ManageIssuesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.Label lblTotalIssues;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalI;
        private System.Windows.Forms.Label lblSubmitted;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblUrgent;
        private System.Windows.Forms.Label lblRoads;
        private System.Windows.Forms.Button btnViewDetails;
    }
}