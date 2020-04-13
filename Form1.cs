﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Countdown_App
{
    public partial class appForm : Form
    {
        public appForm()
        {
            InitializeComponent();
        }

        List<Event> eventList = new List<Event>();



        DateTime today;

        DateTime _group1EventDateTime;
        DateTime _group2EventDateTime;
        DateTime _group3EventDateTime;
        DateTime _group4EventDateTime;

        TimeSpan diff1;
        TimeSpan diff2;
        TimeSpan diff3;
        TimeSpan diff4;

        int t1days = 0;
        int t1hour = 0;
        int t1minute = 0;
        int t1second = 0;

        int t2days = 0;
        int t2hour = 0;
        int t2minute = 0;
        int t2second = 0;

        int t3days = 0;
        int t3hour = 0;
        int t3minute = 0;
        int t3second = 0;

        int t4days = 0;
        int t4hour = 0;
        int t4minute = 0;
        int t4second = 0;

        string _g1Time = "00:00:00:00";
        string _g2Time = "00:00:00:00";
        string _g3Time = "00:00:00:00";
        string _g4Time = "00:00:00:00";


        public string SetTime(int day, int hour, int minute, int second)
        {
            string d = day.ToString();
            string h = hour.ToString();
            string m = minute.ToString();
            string s = second.ToString();

            if(day <10)
            {
                d = "0" + day.ToString();
            }

            if(hour < 10)
            {
                h = "0" + hour.ToString();
            }

            if( minute < 10)
            {
                m = "0" + minute.ToString();
            }

            if(second < 10)
            {
                s = "0" + second.ToString();
            }

            return d + ":" + h + ":" + m + ":" + s;
        }
       
        private void addButton_Click(object sender, EventArgs e)
        {
            today = DateTime.Now;

            if (eventList.Count < 4)
            {
                if (int.TryParse(timeStartText.Text, out int n) && n > 0 && n < 13)
                {

                    if ((amCheckbox.Checked && pmCheckbox.Checked) || (!pmCheckbox.Checked && !amCheckbox.Checked))
                    {
                        welcomeLabel.Text = "Please select only AM OR PM, not both";
                        amCheckbox.Checked = false;
                        pmCheckbox.Checked = false;
                    }
                    else
                    {

                        Event eventCountdown = new Event(eventNameText.Text, locationText.Text,
                             dateTimePicker.Value, timeStartText.Text);

                        eventList.Add(eventCountdown);

                        if (groupBox1.Visible == false)
                        {
                            groupBox1.Visible = true;
                            group1Name.Text = eventNameText.Text;
                            group1Location.Text = locationText.Text;
                            group1Date.Text = dateTimePicker.Value.ToShortDateString();

                            if (amCheckbox.Checked)
                            {
                                group1Time.Text = timeStartText.Text + " " + "AM";
                            }
                            else
                            {
                                group1Time.Text = timeStartText.Text + " " + "PM";
                            }

                            int hour = int.Parse(timeStartText.Text);


                            if (amCheckbox.Checked)
                            {
                                if (hour != 12)
                                {
                                    _group1EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, int.Parse(timeStartText.Text), 0, 0);
                                }
                                else
                                {
                                    _group1EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
                                }
                            }
                            else
                            {
                                if (hour != 12)
                                {
                                    _group1EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, (int.Parse(timeStartText.Text)+12), 0, 0);
                                }
                                else
                                {
                                    _group1EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 12, 0, 0);
                                }
                            }

                            diff1 = _group1EventDateTime - today;

                            _g1Time = SetTime(diff1.Days, diff1.Hours, diff1.Minutes, diff1.Seconds);
                            group1Countdown.Text = _g1Time;
                            t1days = diff1.Days;
                            t1hour = diff1.Hours;
                            t1minute = diff1.Minutes;
                            t1second = diff1.Seconds;
                            
                            

                            timer1.Enabled = true;
                            

                            
                        }
                        else if (groupBox2.Visible == false)
                        {
                            groupBox2.Visible = true;
                            group2Name.Text = eventNameText.Text;
                            group2Location.Text = locationText.Text;
                            group2Date.Text = dateTimePicker.Value.ToShortDateString();
                            if (amCheckbox.Checked)
                            {
                                group2Time.Text = timeStartText.Text + " " + "AM";
                            }
                            else
                            {
                                group2Time.Text = timeStartText.Text + " " + "PM";
                            }

                            int hour = int.Parse(timeStartText.Text);


                            if (amCheckbox.Checked)
                            {
                                if (hour != 12)
                                {
                                    _group2EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, int.Parse(timeStartText.Text), 0, 0);
                                }
                                else
                                {
                                    _group2EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
                                }
                            }
                            else
                            {
                                if (hour != 12)
                                {
                                    _group2EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, (int.Parse(timeStartText.Text) + 12), 0, 0);
                                }
                                else
                                {
                                    _group2EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 12, 0, 0);
                                }
                            }

                            diff2 = _group2EventDateTime - today;

                            
                            _g2Time = SetTime(diff2.Days, diff2.Hours, diff2.Minutes, diff2.Seconds);
                            group2Countdown.Text = _g2Time;
                            t2days = diff2.Days;
                            t2hour = diff2.Hours;
                            t2minute = diff2.Minutes;
                            t2second = diff2.Seconds;
                            
                            

                            timer2.Enabled = true;
                            
                        }
                        else if (groupBox3.Visible == false)
                        {
                            groupBox3.Visible = true;
                            group3Name.Text = eventNameText.Text;
                            group3Location.Text = locationText.Text;
                            group3Date.Text = dateTimePicker.Value.ToShortDateString();
                            if (amCheckbox.Checked)
                            {
                                group3Time.Text = timeStartText.Text + " " + "AM";
                            }
                            else
                            {
                                group3Time.Text = timeStartText.Text + " " + "PM";
                            }

                            int hour = int.Parse(timeStartText.Text);


                            if (amCheckbox.Checked)
                            {
                                if (hour != 12)
                                {
                                    _group3EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, int.Parse(timeStartText.Text), 0, 0);
                                }
                                else
                                {
                                    _group3EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
                                }
                            }
                            else
                            {
                                if (hour != 12)
                                {
                                    _group3EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, (int.Parse(timeStartText.Text) + 12), 0, 0);
                                }
                                else
                                {
                                    _group3EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 12, 0, 0);
                                }
                            }

                            diff3 = _group3EventDateTime - today;

                            
                            _g3Time = SetTime(diff3.Days, diff3.Hours, diff3.Minutes, diff3.Seconds);
                            group3Countdown.Text = _g3Time;
                            t3days = diff3.Days;
                            t3hour = diff3.Hours;
                            t3minute = diff3.Minutes;
                            t3second = diff3.Seconds;
                            
                            

                            timer3.Enabled = true;
                           
                        }
                        else
                        {
                            groupBox4.Visible = true;
                            group4Name.Text = eventNameText.Text;
                            group4Location.Text = locationText.Text;
                            group4Date.Text = dateTimePicker.Value.ToShortDateString();
                            if (amCheckbox.Checked)
                            {
                                group4Time.Text = timeStartText.Text + " " + "AM";
                            }
                            else
                            {
                                group4Time.Text = timeStartText.Text + " " + "PM";
                            }

                            int hour = int.Parse(timeStartText.Text);


                            if (amCheckbox.Checked)
                            {
                                if (hour != 12)
                                {
                                    _group4EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, int.Parse(timeStartText.Text), 0, 0);
                                }
                                else
                                {
                                    _group4EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
                                }
                            }
                            else
                            {
                                if (hour != 12)
                                {
                                    _group4EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, (int.Parse(timeStartText.Text) + 12), 0, 0);
                                }
                                else
                                {
                                    _group4EventDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 12, 0, 0);
                                }
                            }

                            diff4= _group4EventDateTime - today;

                           
                            _g4Time = SetTime(diff4.Days, diff4.Hours, diff4.Minutes, diff4.Seconds);
                            group4Countdown.Text = _g4Time;
                            t4days = diff4.Days;
                            t4hour = diff4.Hours;
                            t4minute = diff4.Minutes;
                            t4second = diff4.Seconds;
                            
                            

                            timer4.Enabled = true;
                            
                        }

                        eventNameText.Clear();
                        locationText.Clear();
                        dateTimePicker.ResetText();
                        timeStartText.Clear();
                        amCheckbox.Checked = false;
                        pmCheckbox.Checked = false;
                        welcomeLabel.Text = "Welcome to the Countdown App! Keep track of up to four events that you can't wait for!";

                    }
                }
                else
                {
                    welcomeLabel.Text = "Please enter a valid hour";
                }
            }
            else
            {
                welcomeLabel.Text = "Sorry! Only four events can be added!";
                eventNameText.Clear();
                locationText.Clear();
                dateTimePicker.ResetText();
                timeStartText.Clear();
                amCheckbox.Checked = false;
                pmCheckbox.Checked = false;
            }

            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1days == 0 && t1second == 0 && t1minute == 0 && t1hour == 0)
            {
                group1Countdown.Text = "It's Time!";
                timer1.Enabled = false;
            }
            else
            {

                if (t1second == 0 && t1minute > 0)
                {
                    t1minute = t1minute - 1;
                    t1second = 60;
                }

                if (t1minute == 0 && t1hour > 0)
                {
                    t1hour = t1hour - 1;
                    t1minute = 60;
                }

                if(t1hour == 0 && t1days >0)
                {
                    t1days = t1days - 1;
                    t1hour = 24;
                }

                t1second = t1second - 1;

                group1Countdown.Text = SetTime(t1days, t1hour, t1minute, t1second);
            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t2days ==0 && t2second == 0 && t2minute == 0 && t2hour == 0)
            {
                group2Countdown.Text = "It's Time!";
                timer2.Enabled = false;
            }
            else
            {

                if (t2second == 0 && t2minute > 0)
                {
                    t2minute = t2minute - 1;
                    t2second = 60;
                }

                if (t2minute == 0 && t2hour > 0)
                {
                    t2hour = t2hour - 1;
                    t2minute = 60;
                }

                if(t2hour == 0 && t2days >0)
                {
                    t2days = t2days - 1;
                    t2hour = 24; 
                }

                t2second = t2second - 1;

                group2Countdown.Text = SetTime(t2days, t2hour, t2minute, t2second);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (t3days ==0 && t3second == 0 && t3minute == 0 && t3hour == 0)
            {
                group3Countdown.Text = "It's Time!";
                timer3.Enabled = false;
            }
            else
            {
                if (t3second == 0 && t3minute > 0)
                {
                    t3minute = t3minute - 1;
                    t3second = 60;
                }

                if (t3minute == 0 && t3hour > 0)
                {
                    t3hour = t3hour - 1;
                    t3minute = 60;
                }

                if(t3hour ==0 && t3days>0)
                {
                    t3days = t3days - 1;
                    t3hour = 24;
                }

                t3second = t3second - 1;

                group3Countdown.Text = SetTime(t3days, t3hour, t3minute, t3second);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (t4days ==0 && t4second == 0 && t4minute == 0 && t4hour == 0)
            {
                group4Countdown.Text = "It's Time!";
                timer4.Enabled = false;
            }

            else
            {

                if (t4second == 0 && t4minute > 0)
                {
                    t4minute = t4minute - 1;
                    t4second = 60;
                }

                if (t4minute == 0 && t4hour > 0)
                {
                    t4hour = t4hour - 1;
                    t4minute = 60;
                }

                if(t4hour ==0 && t4days >0)
                {
                    t4days = t4days - 1;
                    t4hour = 24;
                }

                t4second = t4second - 1;

                group4Countdown.Text = SetTime(t4days, t4hour, t4minute, t4second);
            }
        }
    }
}
       
