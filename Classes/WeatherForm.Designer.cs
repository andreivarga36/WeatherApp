﻿namespace WeatherApp
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cityInfo = new System.Windows.Forms.Label();
            this.degrees = new System.Windows.Forms.Label();
            this.conditions = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labCityInfo = new System.Windows.Forms.Label();
            this.labDegrees = new System.Windows.Forms.Label();
            this.labConditions = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.BackColor = System.Drawing.Color.Transparent;
            this.City.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.ForeColor = System.Drawing.Color.White;
            this.City.Location = new System.Drawing.Point(184, 56);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(45, 26);
            this.City.TabIndex = 2;
            this.City.Text = "City";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(284, 56);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(202, 31);
            this.textBox.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(514, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.HandleSearchButtonClick);
            // 
            // cityInfo
            // 
            this.cityInfo.AutoSize = true;
            this.cityInfo.BackColor = System.Drawing.Color.Transparent;
            this.cityInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInfo.ForeColor = System.Drawing.Color.White;
            this.cityInfo.Location = new System.Drawing.Point(185, 130);
            this.cityInfo.Name = "cityInfo";
            this.cityInfo.Size = new System.Drawing.Size(76, 23);
            this.cityInfo.TabIndex = 6;
            this.cityInfo.Text = "CityInfo:";
            // 
            // degrees
            // 
            this.degrees.AutoSize = true;
            this.degrees.BackColor = System.Drawing.Color.Transparent;
            this.degrees.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degrees.ForeColor = System.Drawing.Color.White;
            this.degrees.Location = new System.Drawing.Point(185, 180);
            this.degrees.Name = "degrees";
            this.degrees.Size = new System.Drawing.Size(78, 23);
            this.degrees.TabIndex = 7;
            this.degrees.Text = "Degrees:";
            // 
            // conditions
            // 
            this.conditions.AutoSize = true;
            this.conditions.BackColor = System.Drawing.Color.Transparent;
            this.conditions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditions.ForeColor = System.Drawing.Color.White;
            this.conditions.Location = new System.Drawing.Point(185, 230);
            this.conditions.Name = "conditions";
            this.conditions.Size = new System.Drawing.Size(98, 23);
            this.conditions.TabIndex = 8;
            this.conditions.Text = "Conditions:";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.BackColor = System.Drawing.Color.Transparent;
            this.details.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.Color.White;
            this.details.Location = new System.Drawing.Point(185, 280);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(67, 23);
            this.details.TabIndex = 9;
            this.details.Text = "Details:";
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
            this.labSunrise.Location = new System.Drawing.Point(287, 330);
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
            this.labSunset.Location = new System.Drawing.Point(287, 380);
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
            this.windspeed.Location = new System.Drawing.Point(510, 130);
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
            this.pressure.Location = new System.Drawing.Point(510, 180);
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
            this.labWindSpeed.Location = new System.Drawing.Point(622, 130);
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
            this.labPressure.Location = new System.Drawing.Point(622, 180);
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
            this.humidity.Location = new System.Drawing.Point(510, 230);
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
            this.labHumidity.Location = new System.Drawing.Point(622, 230);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(39, 23);
            this.labHumidity.TabIndex = 19;
            this.labHumidity.Text = "N/A";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(398, 180);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 73);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 20;
            this.picIcon.TabStop = false;
            // 
            // labCityInfo
            // 
            this.labCityInfo.AutoSize = true;
            this.labCityInfo.BackColor = System.Drawing.Color.Transparent;
            this.labCityInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCityInfo.ForeColor = System.Drawing.Color.White;
            this.labCityInfo.Location = new System.Drawing.Point(287, 130);
            this.labCityInfo.Name = "labCityInfo";
            this.labCityInfo.Size = new System.Drawing.Size(39, 23);
            this.labCityInfo.TabIndex = 21;
            this.labCityInfo.Text = "N/A";
            // 
            // labDegrees
            // 
            this.labDegrees.AutoSize = true;
            this.labDegrees.BackColor = System.Drawing.Color.Transparent;
            this.labDegrees.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDegrees.ForeColor = System.Drawing.Color.White;
            this.labDegrees.Location = new System.Drawing.Point(287, 180);
            this.labDegrees.Name = "labDegrees";
            this.labDegrees.Size = new System.Drawing.Size(39, 23);
            this.labDegrees.TabIndex = 22;
            this.labDegrees.Text = "N/A";
            // 
            // labConditions
            // 
            this.labConditions.AutoSize = true;
            this.labConditions.BackColor = System.Drawing.Color.Transparent;
            this.labConditions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConditions.ForeColor = System.Drawing.Color.White;
            this.labConditions.Location = new System.Drawing.Point(287, 230);
            this.labConditions.Name = "labConditions";
            this.labConditions.Size = new System.Drawing.Size(39, 23);
            this.labConditions.TabIndex = 23;
            this.labConditions.Text = "N/A";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(287, 280);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(39, 23);
            this.labDetails.TabIndex = 24;
            this.labDetails.Text = "N/A";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 436);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labConditions);
            this.Controls.Add(this.labDegrees);
            this.Controls.Add(this.labCityInfo);
            this.Controls.Add(this.picIcon);
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
            this.Controls.Add(this.details);
            this.Controls.Add(this.conditions);
            this.Controls.Add(this.degrees);
            this.Controls.Add(this.cityInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.City);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label degrees;
        private System.Windows.Forms.Label conditions;
        private System.Windows.Forms.Label details;
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
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label cityInfo;
        private System.Windows.Forms.Label labCityInfo;
        private System.Windows.Forms.Label labDegrees;
        private System.Windows.Forms.Label labConditions;
        private System.Windows.Forms.Label labDetails;
    }
}

