namespace Countdown_App
{
    partial class appForm
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
            this.components = new System.ComponentModel.Container();
            this.eventNameText = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.timeStartText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.dateStartLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.group1Name = new System.Windows.Forms.Label();
            this.group1Location = new System.Windows.Forms.Label();
            this.group1Date = new System.Windows.Forms.Label();
            this.group1Time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group1HMSLabel = new System.Windows.Forms.Label();
            this.group1Countdown = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group2Countdown = new System.Windows.Forms.Label();
            this.group2Location = new System.Windows.Forms.Label();
            this.group2Time = new System.Windows.Forms.Label();
            this.group2Name = new System.Windows.Forms.Label();
            this.group2Date = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.group3Countdown = new System.Windows.Forms.Label();
            this.group3Location = new System.Windows.Forms.Label();
            this.group3Time = new System.Windows.Forms.Label();
            this.group3Name = new System.Windows.Forms.Label();
            this.group3Date = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.group4Countdown = new System.Windows.Forms.Label();
            this.group4Location = new System.Windows.Forms.Label();
            this.group4Time = new System.Windows.Forms.Label();
            this.group4Name = new System.Windows.Forms.Label();
            this.group4Date = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.amCheckbox = new System.Windows.Forms.CheckBox();
            this.pmCheckbox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventNameText
            // 
            this.eventNameText.Location = new System.Drawing.Point(12, 111);
            this.eventNameText.Name = "eventNameText";
            this.eventNameText.Size = new System.Drawing.Size(299, 26);
            this.eventNameText.TabIndex = 0;
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point(12, 187);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(299, 26);
            this.locationText.TabIndex = 1;
            // 
            // timeStartText
            // 
            this.timeStartText.Location = new System.Drawing.Point(12, 342);
            this.timeStartText.Name = "timeStartText";
            this.timeStartText.Size = new System.Drawing.Size(168, 26);
            this.timeStartText.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(144, 393);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 38);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Start!";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(12, 88);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(96, 20);
            this.eventNameLabel.TabIndex = 6;
            this.eventNameLabel.Text = "Event Name";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 164);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(70, 20);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Location";
            // 
            // dateStartLabel
            // 
            this.dateStartLabel.AutoSize = true;
            this.dateStartLabel.Location = new System.Drawing.Point(12, 237);
            this.dateStartLabel.Name = "dateStartLabel";
            this.dateStartLabel.Size = new System.Drawing.Size(83, 20);
            this.dateStartLabel.TabIndex = 8;
            this.dateStartLabel.Text = "Date Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time Start (Hour)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // group1Name
            // 
            this.group1Name.AutoSize = true;
            this.group1Name.Location = new System.Drawing.Point(6, 18);
            this.group1Name.Name = "group1Name";
            this.group1Name.Size = new System.Drawing.Size(51, 20);
            this.group1Name.TabIndex = 10;
            this.group1Name.Text = "label2";
            // 
            // group1Location
            // 
            this.group1Location.AutoSize = true;
            this.group1Location.Location = new System.Drawing.Point(6, 37);
            this.group1Location.Name = "group1Location";
            this.group1Location.Size = new System.Drawing.Size(51, 20);
            this.group1Location.TabIndex = 11;
            this.group1Location.Text = "label3";
            // 
            // group1Date
            // 
            this.group1Date.AutoSize = true;
            this.group1Date.Location = new System.Drawing.Point(6, 57);
            this.group1Date.Name = "group1Date";
            this.group1Date.Size = new System.Drawing.Size(51, 20);
            this.group1Date.TabIndex = 12;
            this.group1Date.Text = "label4";
            // 
            // group1Time
            // 
            this.group1Time.AutoSize = true;
            this.group1Time.Location = new System.Drawing.Point(6, 77);
            this.group1Time.Name = "group1Time";
            this.group1Time.Size = new System.Drawing.Size(51, 20);
            this.group1Time.TabIndex = 13;
            this.group1Time.Text = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.group1HMSLabel);
            this.groupBox1.Controls.Add(this.group1Countdown);
            this.groupBox1.Controls.Add(this.group1Location);
            this.groupBox1.Controls.Add(this.group1Time);
            this.groupBox1.Controls.Add(this.group1Name);
            this.groupBox1.Controls.Add(this.group1Date);
            this.groupBox1.Location = new System.Drawing.Point(332, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 103);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // group1HMSLabel
            // 
            this.group1HMSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group1HMSLabel.Location = new System.Drawing.Point(170, 12);
            this.group1HMSLabel.Name = "group1HMSLabel";
            this.group1HMSLabel.Size = new System.Drawing.Size(379, 22);
            this.group1HMSLabel.TabIndex = 15;
            this.group1HMSLabel.Text = "(Days, Hours, Minutes, Seconds)";
            // 
            // group1Countdown
            // 
            this.group1Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group1Countdown.Location = new System.Drawing.Point(157, 37);
            this.group1Countdown.Name = "group1Countdown";
            this.group1Countdown.Size = new System.Drawing.Size(392, 62);
            this.group1Countdown.TabIndex = 14;
            this.group1Countdown.Text = "00:00:00:00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.group2Countdown);
            this.groupBox2.Controls.Add(this.group2Location);
            this.groupBox2.Controls.Add(this.group2Time);
            this.groupBox2.Controls.Add(this.group2Name);
            this.groupBox2.Controls.Add(this.group2Date);
            this.groupBox2.Location = new System.Drawing.Point(332, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "(Days, Hours, Minutes, Seconds)";
            // 
            // group2Countdown
            // 
            this.group2Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group2Countdown.Location = new System.Drawing.Point(157, 31);
            this.group2Countdown.Name = "group2Countdown";
            this.group2Countdown.Size = new System.Drawing.Size(392, 66);
            this.group2Countdown.TabIndex = 19;
            this.group2Countdown.Text = "00:00:00:00";
            // 
            // group2Location
            // 
            this.group2Location.AutoSize = true;
            this.group2Location.Location = new System.Drawing.Point(6, 38);
            this.group2Location.Name = "group2Location";
            this.group2Location.Size = new System.Drawing.Size(51, 20);
            this.group2Location.TabIndex = 11;
            this.group2Location.Text = "label6";
            // 
            // group2Time
            // 
            this.group2Time.AutoSize = true;
            this.group2Time.Location = new System.Drawing.Point(6, 78);
            this.group2Time.Name = "group2Time";
            this.group2Time.Size = new System.Drawing.Size(51, 20);
            this.group2Time.TabIndex = 13;
            this.group2Time.Text = "label7";
            // 
            // group2Name
            // 
            this.group2Name.AutoSize = true;
            this.group2Name.Location = new System.Drawing.Point(6, 19);
            this.group2Name.Name = "group2Name";
            this.group2Name.Size = new System.Drawing.Size(51, 20);
            this.group2Name.TabIndex = 10;
            this.group2Name.Text = "label8";
            // 
            // group2Date
            // 
            this.group2Date.AutoSize = true;
            this.group2Date.Location = new System.Drawing.Point(6, 58);
            this.group2Date.Name = "group2Date";
            this.group2Date.Size = new System.Drawing.Size(51, 20);
            this.group2Date.TabIndex = 12;
            this.group2Date.Text = "label9";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.group3Countdown);
            this.groupBox3.Controls.Add(this.group3Location);
            this.groupBox3.Controls.Add(this.group3Time);
            this.groupBox3.Controls.Add(this.group3Name);
            this.groupBox3.Controls.Add(this.group3Date);
            this.groupBox3.Location = new System.Drawing.Point(332, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 104);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "(Days, Hours, Minutes, Seconds)";
            // 
            // group3Countdown
            // 
            this.group3Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group3Countdown.Location = new System.Drawing.Point(160, 38);
            this.group3Countdown.Name = "group3Countdown";
            this.group3Countdown.Size = new System.Drawing.Size(389, 62);
            this.group3Countdown.TabIndex = 20;
            this.group3Countdown.Text = "00:00:00:00";
            // 
            // group3Location
            // 
            this.group3Location.AutoSize = true;
            this.group3Location.Location = new System.Drawing.Point(6, 37);
            this.group3Location.Name = "group3Location";
            this.group3Location.Size = new System.Drawing.Size(60, 20);
            this.group3Location.TabIndex = 11;
            this.group3Location.Text = "label10";
            // 
            // group3Time
            // 
            this.group3Time.AutoSize = true;
            this.group3Time.Location = new System.Drawing.Point(6, 77);
            this.group3Time.Name = "group3Time";
            this.group3Time.Size = new System.Drawing.Size(60, 20);
            this.group3Time.TabIndex = 13;
            this.group3Time.Text = "label11";
            // 
            // group3Name
            // 
            this.group3Name.AutoSize = true;
            this.group3Name.Location = new System.Drawing.Point(6, 18);
            this.group3Name.Name = "group3Name";
            this.group3Name.Size = new System.Drawing.Size(60, 20);
            this.group3Name.TabIndex = 10;
            this.group3Name.Text = "label12";
            // 
            // group3Date
            // 
            this.group3Date.AutoSize = true;
            this.group3Date.Location = new System.Drawing.Point(6, 57);
            this.group3Date.Name = "group3Date";
            this.group3Date.Size = new System.Drawing.Size(60, 20);
            this.group3Date.TabIndex = 12;
            this.group3Date.Text = "label13";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.group4Countdown);
            this.groupBox4.Controls.Add(this.group4Location);
            this.groupBox4.Controls.Add(this.group4Time);
            this.groupBox4.Controls.Add(this.group4Name);
            this.groupBox4.Controls.Add(this.group4Date);
            this.groupBox4.Location = new System.Drawing.Point(332, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(555, 103);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "(Days, Hours, Minutes, Seconds)";
            // 
            // group4Countdown
            // 
            this.group4Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group4Countdown.Location = new System.Drawing.Point(161, 36);
            this.group4Countdown.Name = "group4Countdown";
            this.group4Countdown.Size = new System.Drawing.Size(388, 59);
            this.group4Countdown.TabIndex = 21;
            this.group4Countdown.Text = "00:00:00:00";
            // 
            // group4Location
            // 
            this.group4Location.AutoSize = true;
            this.group4Location.Location = new System.Drawing.Point(6, 37);
            this.group4Location.Name = "group4Location";
            this.group4Location.Size = new System.Drawing.Size(60, 20);
            this.group4Location.TabIndex = 11;
            this.group4Location.Text = "label14";
            // 
            // group4Time
            // 
            this.group4Time.AutoSize = true;
            this.group4Time.Location = new System.Drawing.Point(6, 77);
            this.group4Time.Name = "group4Time";
            this.group4Time.Size = new System.Drawing.Size(60, 20);
            this.group4Time.TabIndex = 13;
            this.group4Time.Text = "label15";
            // 
            // group4Name
            // 
            this.group4Name.AutoSize = true;
            this.group4Name.Location = new System.Drawing.Point(6, 18);
            this.group4Name.Name = "group4Name";
            this.group4Name.Size = new System.Drawing.Size(60, 20);
            this.group4Name.TabIndex = 10;
            this.group4Name.Text = "label16";
            // 
            // group4Date
            // 
            this.group4Date.AutoSize = true;
            this.group4Date.Location = new System.Drawing.Point(6, 57);
            this.group4Date.Name = "group4Date";
            this.group4Date.Size = new System.Drawing.Size(60, 20);
            this.group4Date.TabIndex = 12;
            this.group4Date.Text = "label17";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(299, 74);
            this.welcomeLabel.TabIndex = 18;
            this.welcomeLabel.Text = "Welcome to the Countdown App! Keep track of up to four events that you can\'t wait" +
    " for!";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // amCheckbox
            // 
            this.amCheckbox.Location = new System.Drawing.Point(198, 343);
            this.amCheckbox.Name = "amCheckbox";
            this.amCheckbox.Size = new System.Drawing.Size(64, 26);
            this.amCheckbox.TabIndex = 19;
            this.amCheckbox.Text = "AM";
            this.amCheckbox.UseVisualStyleBackColor = true;
            // 
            // pmCheckbox
            // 
            this.pmCheckbox.Location = new System.Drawing.Point(257, 343);
            this.pmCheckbox.Name = "pmCheckbox";
            this.pmCheckbox.Size = new System.Drawing.Size(69, 26);
            this.pmCheckbox.TabIndex = 20;
            this.pmCheckbox.Text = "PM";
            this.pmCheckbox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 260);
            this.dateTimePicker.MinDate = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker.TabIndex = 21;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 452);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pmCheckbox);
            this.Controls.Add(this.amCheckbox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStartLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.timeStartText);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.eventNameText);
            this.Name = "appForm";
            this.Text = "Countdown App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventNameText;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox timeStartText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label dateStartLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label group1Name;
        private System.Windows.Forms.Label group1Location;
        private System.Windows.Forms.Label group1Date;
        private System.Windows.Forms.Label group1Time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label group2Location;
        private System.Windows.Forms.Label group2Time;
        private System.Windows.Forms.Label group2Name;
        private System.Windows.Forms.Label group2Date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label group3Location;
        private System.Windows.Forms.Label group3Time;
        private System.Windows.Forms.Label group3Name;
        private System.Windows.Forms.Label group3Date;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label group4Location;
        private System.Windows.Forms.Label group4Time;
        private System.Windows.Forms.Label group4Name;
        private System.Windows.Forms.Label group4Date;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label group1Countdown;
        private System.Windows.Forms.Label group2Countdown;
        private System.Windows.Forms.Label group3Countdown;
        private System.Windows.Forms.Label group4Countdown;
        private System.Windows.Forms.Label group1HMSLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox amCheckbox;
        private System.Windows.Forms.CheckBox pmCheckbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

