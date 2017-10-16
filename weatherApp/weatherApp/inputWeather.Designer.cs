namespace weatherApp
{
    partial class inputWeather
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
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtPercip = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.labSkies = new System.Windows.Forms.Label();
            this.labPercip = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(27, 189);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(100, 20);
            this.txtSummary.TabIndex = 10;
            this.txtSummary.Text = "Clear";
            // 
            // txtPercip
            // 
            this.txtPercip.Location = new System.Drawing.Point(25, 130);
            this.txtPercip.Name = "txtPercip";
            this.txtPercip.Size = new System.Drawing.Size(100, 20);
            this.txtPercip.TabIndex = 9;
            this.txtPercip.Text = "0";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(25, 75);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 8;
            this.txtTemp.Text = "0";
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(25, 12);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(100, 20);
            this.txtLoc.TabIndex = 6;
            this.txtLoc.Text = "Enter Location";
            // 
            // labSkies
            // 
            this.labSkies.AutoSize = true;
            this.labSkies.Location = new System.Drawing.Point(24, 173);
            this.labSkies.Name = "labSkies";
            this.labSkies.Size = new System.Drawing.Size(33, 13);
            this.labSkies.TabIndex = 14;
            this.labSkies.Text = "Skies";
            // 
            // labPercip
            // 
            this.labPercip.AutoSize = true;
            this.labPercip.Location = new System.Drawing.Point(22, 114);
            this.labPercip.Name = "labPercip";
            this.labPercip.Size = new System.Drawing.Size(65, 13);
            this.labPercip.TabIndex = 13;
            this.labPercip.Text = "Percipitation";
            this.labPercip.Visible = false;
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Location = new System.Drawing.Point(22, 59);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(67, 13);
            this.labTemp.TabIndex = 12;
            this.labTemp.Text = "Temperature";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(25, 228);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(237, 23);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(187, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(187, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // inputWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.labSkies);
            this.Controls.Add(this.labPercip);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtPercip);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtLoc);
            this.Name = "inputWeather";
            this.Text = "inputWeather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtPercip;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label labSkies;
        private System.Windows.Forms.Label labPercip;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
    }
}