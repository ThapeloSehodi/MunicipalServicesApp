namespace MunicipalServicesApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.lblEventsComingSoon = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.lblStatusComingSoon = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(298, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MUNICIPAL SERVICES";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Citizen Service Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Location = new System.Drawing.Point(268, 100);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(223, 23);
            this.btnReportIssues.TabIndex = 2;
            this.btnReportIssues.Text = "Report an Issue";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Enabled = false;
            this.btnEvents.Location = new System.Drawing.Point(302, 164);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(161, 23);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Local Events & Announcements";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // lblEventsComingSoon
            // 
            this.lblEventsComingSoon.Location = new System.Drawing.Point(336, 225);
            this.lblEventsComingSoon.Name = "lblEventsComingSoon";
            this.lblEventsComingSoon.Size = new System.Drawing.Size(89, 23);
            this.lblEventsComingSoon.TabIndex = 4;
            this.lblEventsComingSoon.Text = "Coming Soon";
            this.lblEventsComingSoon.UseVisualStyleBackColor = true;
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.Enabled = false;
            this.btnServiceStatus.Location = new System.Drawing.Point(321, 276);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(129, 23);
            this.btnServiceStatus.TabIndex = 5;
            this.btnServiceStatus.Text = "Service Request Status";
            this.btnServiceStatus.UseVisualStyleBackColor = true;
            // 
            // lblStatusComingSoon
            // 
            this.lblStatusComingSoon.AutoSize = true;
            this.lblStatusComingSoon.Location = new System.Drawing.Point(355, 322);
            this.lblStatusComingSoon.Name = "lblStatusComingSoon";
            this.lblStatusComingSoon.Size = new System.Drawing.Size(70, 13);
            this.lblStatusComingSoon.TabIndex = 6;
            this.lblStatusComingSoon.Text = "Coming Soon";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(299, 417);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(217, 13);
            this.lblFooter.TabIndex = 8;
            this.lblFooter.Text = "Municipal Services Application | South Africa";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatusComingSoon);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.lblEventsComingSoon);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button lblEventsComingSoon;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Label lblStatusComingSoon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFooter;
    }
}

