﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FBLA_Project
{
    public partial class Form1 : Form
    {

        #region Variables

        static string dataFolder = Application.StartupPath + @"\Data";
        static string conferencesFile = @"\CONFERENCES.txt";
        static string typeFile = @"\TYPE.txt";
        static string participantsFile = @"\PARTICIPANTS.txt";
        static string workshopsFile = @"\WORKSHOPS.txt";
        static string workshopRegistrationsFile = @"\WKSHP_REGISTRATIONS.txt";
        static string[] conferences = File.ReadAllLines(dataFolder + conferencesFile);
        static string[] participantTypes = File.ReadAllLines(dataFolder + typeFile);
        List<string> conferenceInfoList = new List<string>();
        List<string> conferenceNameList = new List<string>();
        List<string> typeList = new List<string>();
        List<string> typeDescList = new List<string>();

        #endregion

        public Form1()
        {
            InitializeComponent();
            foreach (var conference in conferences)
            {
                string[] splitConference = conference.Split(',');
                conferenceInfoList.AddRange(splitConference);
                conferenceNameList.Add(splitConference[1]);
            }
            foreach (var type in participantTypes)
            {
                string[] splitType = type.Split(',');
                typeList.AddRange(splitType);
                typeDescList.Add(splitType[1]);
            }
            conferencesComboBox.Items.AddRange(conferenceNameList.ToArray());    
            typeComboBox.Items.AddRange(typeDescList.ToArray());
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
            if (!File.Exists(dataFolder + conferencesFile))
            {
                File.Create(dataFolder + conferencesFile).Close();
            }
            if (!File.Exists(dataFolder + typeFile))
            {
                File.Create(dataFolder + typeFile).Close();
            }
            if (!File.Exists(dataFolder + participantsFile))
            {
                File.Create(dataFolder + participantsFile).Close();
            }
            if (!File.Exists(dataFolder + workshopsFile))
            {
                File.Create(dataFolder + workshopsFile).Close();
            }
            if (!File.Exists(dataFolder + workshopRegistrationsFile))
            {
                File.Create(dataFolder + workshopRegistrationsFile).Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "First Name" && lastNameTextBox.Text != "Last Name" && conferencesComboBox.Text != "Conference" && typeComboBox.Text != "Type")
            {
                
                writeParticipant(firstNameTextBox.Text, lastNameTextBox.Text, conferencesComboBox.Text, typeComboBox.Text);
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error");
            }
        }

        private void writeParticipant(string firstName, string lastName, string conference, string participantType)
        {
            using (System.IO.StreamWriter participants = new System.IO.StreamWriter(Application.StartupPath + @"\Data\PARTICIPANTS.txt", true))
            {
                participants.WriteLine(firstName + ", " + lastName + ", " + conference + ", " + participantType);
            }
        }
    }
}
