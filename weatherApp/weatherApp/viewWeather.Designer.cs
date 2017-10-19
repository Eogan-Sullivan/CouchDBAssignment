namespace weatherApp
{
    partial class viewWeather
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
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPercip = new System.Windows.Forms.TextBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.labTemp = new System.Windows.Forms.Label();
            this.labPercip = new System.Windows.Forms.Label();
            this.labSkies = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(22, 12);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(100, 20);
            this.txtLoc.TabIndex = 0;
            this.txtLoc.Text = "Enter Location";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(184, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(22, 87);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 2;
            this.txtTemp.Text = "0";
            this.txtTemp.Visible = false;
            // 
            // txtPercip
            // 
            this.txtPercip.Location = new System.Drawing.Point(22, 142);
            this.txtPercip.Name = "txtPercip";
            this.txtPercip.Size = new System.Drawing.Size(100, 20);
            this.txtPercip.TabIndex = 3;
            this.txtPercip.Text = "0";
            this.txtPercip.Visible = false;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(22, 201);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(100, 20);
            this.txtSummary.TabIndex = 4;
            this.txtSummary.Text = "Clear";
            this.txtSummary.Visible = false;
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Location = new System.Drawing.Point(19, 71);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(67, 13);
            this.labTemp.TabIndex = 6;
            this.labTemp.Text = "Temperature";
            this.labTemp.Visible = false;
            // 
            // labPercip
            // 
            this.labPercip.AutoSize = true;
            this.labPercip.Location = new System.Drawing.Point(19, 126);
            this.labPercip.Name = "labPercip";
            this.labPercip.Size = new System.Drawing.Size(65, 13);
            this.labPercip.TabIndex = 7;
            this.labPercip.Text = "Percipitation";
            this.labPercip.Visible = false;
            // 
            // labSkies
            // 
            this.labSkies.AutoSize = true;
            this.labSkies.Location = new System.Drawing.Point(21, 185);
            this.labSkies.Name = "labSkies";
            this.labSkies.Size = new System.Drawing.Size(33, 13);
            this.labSkies.TabIndex = 8;
            this.labSkies.Text = "Skies";
            this.labSkies.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(22, 248);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(237, 23);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(184, 201);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // viewWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 283);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.labSkies);
            this.Controls.Add(this.labPercip);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtPercip);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLoc);
            this.Name = "viewWeather";
            this.Text = "Search Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtPercip;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label labPercip;
        private System.Windows.Forms.Label labSkies;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnViewAll;
    }
}