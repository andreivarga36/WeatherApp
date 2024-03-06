namespace WeatherApp
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.City = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCountry = new System.Windows.Forms.Label();
            this.labDegrees = new System.Windows.Forms.Label();
            this.labConditions = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.BackColor = System.Drawing.Color.Transparent;
            this.City.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.ForeColor = System.Drawing.Color.White;
            this.City.Location = new System.Drawing.Point(185, 60);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(39, 23);
            this.City.TabIndex = 2;
            this.City.Text = "City";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(276, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 31);
            this.textBox1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(526, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // labCountry
            // 
            this.labCountry.AutoSize = true;
            this.labCountry.BackColor = System.Drawing.Color.Transparent;
            this.labCountry.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCountry.ForeColor = System.Drawing.Color.White;
            this.labCountry.Location = new System.Drawing.Point(185, 130);
            this.labCountry.Name = "labCountry";
            this.labCountry.Size = new System.Drawing.Size(77, 23);
            this.labCountry.TabIndex = 6;
            this.labCountry.Text = "Country:";
            // 
            // labDegrees
            // 
            this.labDegrees.AutoSize = true;
            this.labDegrees.BackColor = System.Drawing.Color.Transparent;
            this.labDegrees.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDegrees.ForeColor = System.Drawing.Color.White;
            this.labDegrees.Location = new System.Drawing.Point(185, 180);
            this.labDegrees.Name = "labDegrees";
            this.labDegrees.Size = new System.Drawing.Size(73, 23);
            this.labDegrees.TabIndex = 7;
            this.labDegrees.Text = "Degrees";
            // 
            // labConditions
            // 
            this.labConditions.AutoSize = true;
            this.labConditions.BackColor = System.Drawing.Color.Transparent;
            this.labConditions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConditions.ForeColor = System.Drawing.Color.White;
            this.labConditions.Location = new System.Drawing.Point(185, 230);
            this.labConditions.Name = "labConditions";
            this.labConditions.Size = new System.Drawing.Size(93, 23);
            this.labConditions.TabIndex = 8;
            this.labConditions.Text = "Conditions";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(185, 280);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(62, 23);
            this.labDetails.TabIndex = 9;
            this.labDetails.Text = "Details";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.ForeColor = System.Drawing.Color.White;
            this.sunrise.Location = new System.Drawing.Point(185, 330);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(72, 23);
            this.sunrise.TabIndex = 10;
            this.sunrise.Text = "Sunrise:";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.ForeColor = System.Drawing.Color.White;
            this.sunset.Location = new System.Drawing.Point(185, 380);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(67, 23);
            this.sunset.TabIndex = 11;
            this.sunset.Text = "Sunset:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(297, 310);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(39, 23);
            this.labSunrise.TabIndex = 12;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(297, 360);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(39, 23);
            this.labSunset.TabIndex = 13;
            this.labSunset.Text = "N/A";
            // 
            // windspeed
            // 
            this.windspeed.AutoSize = true;
            this.windspeed.BackColor = System.Drawing.Color.Transparent;
            this.windspeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed.ForeColor = System.Drawing.Color.White;
            this.windspeed.Location = new System.Drawing.Point(472, 130);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(106, 23);
            this.windspeed.TabIndex = 14;
            this.windspeed.Text = "Wind speed:";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(472, 180);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(83, 23);
            this.pressure.TabIndex = 15;
            this.pressure.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(600, 130);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(39, 23);
            this.labWindSpeed.TabIndex = 16;
            this.labWindSpeed.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(600, 180);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(39, 23);
            this.labPressure.TabIndex = 17;
            this.labPressure.Text = "N/A";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.ForeColor = System.Drawing.Color.White;
            this.humidity.Location = new System.Drawing.Point(472, 230);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(85, 23);
            this.humidity.TabIndex = 18;
            this.humidity.Text = "Humidity:";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.White;
            this.labHumidity.Location = new System.Drawing.Point(600, 230);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(39, 23);
            this.labHumidity.TabIndex = 19;
            this.labHumidity.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 436);
            this.Controls.Add(this.labHumidity);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labConditions);
            this.Controls.Add(this.labDegrees);
            this.Controls.Add(this.labCountry);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.City);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCountry;
        private System.Windows.Forms.Label labDegrees;
        private System.Windows.Forms.Label labConditions;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label labHumidity;
    }
}

