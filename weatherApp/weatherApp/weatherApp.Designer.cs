namespace weatherApp
{
    partial class weatherApp
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
            this.btnViewWeather = new System.Windows.Forms.Button();
            this.btnInputWeather = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewWeather
            // 
            this.btnViewWeather.Location = new System.Drawing.Point(73, 81);
            this.btnViewWeather.Name = "btnViewWeather";
            this.btnViewWeather.Size = new System.Drawing.Size(144, 23);
            this.btnViewWeather.TabIndex = 0;
            this.btnViewWeather.Text = "View Weather";
            this.btnViewWeather.UseVisualStyleBackColor = true;
            this.btnViewWeather.Click += new System.EventHandler(this.btnViewWeather_Click);
            // 
            // btnInputWeather
            // 
            this.btnInputWeather.Location = new System.Drawing.Point(73, 153);
            this.btnInputWeather.Name = "btnInputWeather";
            this.btnInputWeather.Size = new System.Drawing.Size(144, 23);
            this.btnInputWeather.TabIndex = 1;
            this.btnInputWeather.Text = "Input Weather";
            this.btnInputWeather.UseVisualStyleBackColor = true;
            this.btnInputWeather.Click += new System.EventHandler(this.btnInputWeather_Click);
            // 
            // weatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 283);
            this.Controls.Add(this.btnInputWeather);
            this.Controls.Add(this.btnViewWeather);
            this.Name = "weatherApp";
            this.Text = "Weather App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewWeather;
        private System.Windows.Forms.Button btnInputWeather;
    }
}

