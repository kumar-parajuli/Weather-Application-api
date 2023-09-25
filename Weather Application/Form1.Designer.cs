namespace Weather_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.labCondiction = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.labDetail = new System.Windows.Forms.Label();
            this.labeSunsine = new System.Windows.Forms.Label();
            this.labeSunset = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labWindspeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "City name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(182, 83);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(201, 29);
            this.TBCity.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(406, 83);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 29);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search...";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // labCondiction
            // 
            this.labCondiction.AutoSize = true;
            this.labCondiction.BackColor = System.Drawing.Color.Transparent;
            this.labCondiction.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondiction.ForeColor = System.Drawing.Color.White;
            this.labCondiction.Location = new System.Drawing.Point(85, 181);
            this.labCondiction.Name = "labCondiction";
            this.labCondiction.Size = new System.Drawing.Size(83, 23);
            this.labCondiction.TabIndex = 3;
            this.labCondiction.Text = "Condiction";
            this.labCondiction.Click += new System.EventHandler(this.label2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(81, 319);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 23);
            this.label.TabIndex = 4;
            this.label.Text = "Sunset :";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.Transparent;
            this.lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.White;
            this.lable.Location = new System.Drawing.Point(85, 266);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(67, 23);
            this.lable.TabIndex = 5;
            this.lable.Text = "Sunrise:";
            // 
            // labDetail
            // 
            this.labDetail.AutoSize = true;
            this.labDetail.BackColor = System.Drawing.Color.Transparent;
            this.labDetail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetail.ForeColor = System.Drawing.Color.White;
            this.labDetail.Location = new System.Drawing.Point(85, 222);
            this.labDetail.Name = "labDetail";
            this.labDetail.Size = new System.Drawing.Size(60, 23);
            this.labDetail.TabIndex = 6;
            this.labDetail.Text = "Details:";
            // 
            // labeSunsine
            // 
            this.labeSunsine.AutoSize = true;
            this.labeSunsine.BackColor = System.Drawing.Color.Transparent;
            this.labeSunsine.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeSunsine.ForeColor = System.Drawing.Color.White;
            this.labeSunsine.Location = new System.Drawing.Point(178, 266);
            this.labeSunsine.Name = "labeSunsine";
            this.labeSunsine.Size = new System.Drawing.Size(35, 23);
            this.labeSunsine.TabIndex = 7;
            this.labeSunsine.Text = "N/A";
            this.labeSunsine.Click += new System.EventHandler(this.labeSunsine_Click);
            // 
            // labeSunset
            // 
            this.labeSunset.AutoSize = true;
            this.labeSunset.BackColor = System.Drawing.Color.Transparent;
            this.labeSunset.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeSunset.ForeColor = System.Drawing.Color.White;
            this.labeSunset.Location = new System.Drawing.Point(178, 319);
            this.labeSunset.Name = "labeSunset";
            this.labeSunset.Size = new System.Drawing.Size(35, 23);
            this.labeSunset.TabIndex = 8;
            this.labeSunset.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wind Speed :";
            // 
            // labWindspeed
            // 
            this.labWindspeed.AutoSize = true;
            this.labWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindspeed.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindspeed.ForeColor = System.Drawing.Color.White;
            this.labWindspeed.Location = new System.Drawing.Point(579, 236);
            this.labWindspeed.Name = "labWindspeed";
            this.labWindspeed.Size = new System.Drawing.Size(35, 23);
            this.labWindspeed.TabIndex = 10;
            this.labWindspeed.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(450, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pressure:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(560, 286);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(35, 23);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            this.labPressure.Click += new System.EventHandler(this.label5_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picIcon.ErrorImage")));
            this.picIcon.Location = new System.Drawing.Point(443, 134);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(132, 79);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labWindspeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeSunset);
            this.Controls.Add(this.labeSunsine);
            this.Controls.Add(this.labDetail);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labCondiction);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label labCondiction;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label labDetail;
        private System.Windows.Forms.Label labeSunsine;
        private System.Windows.Forms.Label labeSunset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labWindspeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

