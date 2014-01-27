using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FBLA_Project
{
    public partial class mainForm : Form
    {

        #region Variables

        static string dataFolder = Application.StartupPath + @"\Data";
        static string conferencesFile = @"\CONFERENCES.txt";
        static string typeFile = @"\TYPE.txt";
        static string participantsFile = @"\PARTICIPANTS.txt";
        static string workshopsFile = @"\WORKSHOPS.txt";
        static string workshopRegistrationsFile = @"\WKSHP_REGISTRATIONS.txt";
        static string[] conferences;
        static string[] participantTypes;
        static string[] registeredParticipants;
        static String[] workshops;
        static int lastPartNum = 1;
        List<string> conferenceInfoList = new List<string>();
        List<string> conferenceNameList = new List<string>();
        List<string> typeList = new List<string>();
        List<string> typeDescList = new List<string>();
        List<string[]> workshopList = new List<string[]>();
        List<string> workshopNameList = new List<string>();
        List<string> workshopDescList = new List<string>();
        List<string[]> chosenWorkshopsList = new List<string[]>();

        #endregion

        public mainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
            if (!File.Exists(dataFolder + conferencesFile))
            {
                File.WriteAllText(dataFolder + conferencesFile, "//Conference Code, Location, Beginning Date, End Date");
            }
            if (!File.Exists(dataFolder + typeFile))
            {
                File.WriteAllText(dataFolder + typeFile, "//Type Code, Type Description");
            }
            if (!File.Exists(dataFolder + participantsFile))
            {
                File.WriteAllText(dataFolder + participantsFile, "//Participant Number, Conference Code, Participant Type, First Name, Last Name, Chapter Number");
            }
            if (!File.Exists(dataFolder + workshopsFile))
            {
                File.WriteAllText(dataFolder + workshopsFile, "//Workshop Code, Conference Code, Workshop Name, Workshop Description, Workshop Date, Workshop Time");
            }
            if (!File.Exists(dataFolder + workshopRegistrationsFile))
            {
                File.WriteAllText(dataFolder + workshopRegistrationsFile, "//Participant ID, Workshop Code");
            }
            conferences = File.ReadAllLines(dataFolder + conferencesFile);
            participantTypes = File.ReadAllLines(dataFolder + typeFile);
            registeredParticipants = File.ReadAllLines(dataFolder + participantsFile);
            workshops = File.ReadAllLines(dataFolder + workshopsFile);
            foreach (var participant in registeredParticipants)
            {
                if (!participant.StartsWith("//"))
                {
                    string[] splitParticipants = participant.Split(',');
                    lastPartNum = Convert.ToInt32(splitParticipants[0]) + 1;
                }
            }
            foreach (var conference in conferences)
            {
                if (!conference.StartsWith("//"))
                {
                    string[] splitConference = conference.Split(',');
                    conferenceInfoList.AddRange(splitConference);
                    conferenceNameList.Add(splitConference[1]);
                }
            }
            foreach (var type in participantTypes)
            {
                if (!type.StartsWith("//"))
                {
                    string[] splitType = type.Split(',');
                    typeList.AddRange(splitType);
                    typeDescList.Add(splitType[1]);
                }
            }
            foreach (var workshop in workshops)
            {
                if (!workshop.StartsWith("//"))
                {
                    string[] splitWorkshop = workshop.Split(',');
                    splitWorkshop[2] = splitWorkshop[2].Trim();
                    workshopList.Add(splitWorkshop);
                    workshopNameList.Add(splitWorkshop[2].Trim());
                    workshopDescList.Add(splitWorkshop[3]);
                }
            }
            conferencesComboBox.Items.AddRange(conferenceNameList.ToArray());    
            typeComboBox.Items.AddRange(typeDescList.ToArray());
            workshopComboBox.Items.AddRange(workshopNameList.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "First Name" && lastNameTextBox.Text != "Last Name" && conferencesComboBox.Text != "Conference" && typeComboBox.Text != "Type")
            {
                string conferenceID = conferenceInfoList[conferenceInfoList.IndexOf(conferencesComboBox.Text) - 1];
                string typeID = typeList[typeList.IndexOf(typeComboBox.Text) - 1];
                writeParticipant(firstNameTextBox.Text, lastNameTextBox.Text, conferenceID, typeID, chaptNumTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error");
            }
        }

        private void writeParticipant(string firstName, string lastName, string conference, string participantType, string chaptNum)
        {
            using (System.IO.StreamWriter workshops = new System.IO.StreamWriter(dataFolder + workshopRegistrationsFile, true))
            {
                foreach (var chosen in chosenWorkshopsList)
                {
                    Debug.WriteLine("Chosen: " + chosen[0]);
                    workshops.WriteLine(lastPartNum + ", " + chosen[0]);
                }
                workshops.Close();
            }
            using (System.IO.StreamWriter participants = new System.IO.StreamWriter(dataFolder + participantsFile, true))
            {
                participants.WriteLine(lastPartNum + ", " + conference + ", " + participantType + ", " + firstName + ", " + lastName + ", " + chaptNum);
                lastPartNum++;
                participants.Close();
            }
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "First Name")
                firstNameTextBox.Clear();
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Last Name")
                lastNameTextBox.Clear();
        }

        private void chaptNumTextBox_Enter(object sender, EventArgs e)
        {
            if (chaptNumTextBox.Text == "Chapter #")
                chaptNumTextBox.Clear();
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
                firstNameTextBox.Text = "First Name";
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
                lastNameTextBox.Text = "Last Name";
        }

        private void chaptNumTextBox_Leave(object sender, EventArgs e)
        {
            if (chaptNumTextBox.Text == "")
                chaptNumTextBox.Text = "Chapter #";
        }

        private void workshopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workshopTextBox.Text = workshopDescList[workshopNameList.FindIndex(x => x.Contains(workshopComboBox.Text.Trim()))];
            workshopDateTime.Text = "Date and Time: " + workshopList[workshopList.FindIndex(x => x.Contains(workshopComboBox.Text.Trim()))][4] + ", " + workshopList[workshopList.FindIndex(x => x.Contains(workshopComboBox.Text.Trim()))][5];
            if (chosenWorkshopsList.Contains(workshopList[workshopList.FindIndex(x => x.Contains(workshopComboBox.Text))]))
                workButton.Text = "Remove";
            else
                workButton.Text = "Add";
        }

        private void typeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void conferencesComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chaptNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            if (workButton.Text == "Add")
            {
                Debug.WriteLine("Adding workshop");
                if (workshopComboBox.Text != "Workshops" && !chosenWorkshopsList.Contains(workshopList[workshopList.FindIndex(x => x.Contains(workshopComboBox.Text))]))
                {
                    chosenWorkshopsList.Add(workshopList[workshopList.FindIndex(x => x.Contains(workshopComboBox.Text))]);
                    chosenWorkBox.Items.Add(workshopComboBox.Text);
                }
                workButton.Text = "Remove";
            }
            else
            {
                Debug.WriteLine("Removing workshop");
                if (chosenWorkshopsList.Contains(workshopList[workshopList.FindIndex(x => x.Contains(workshopComboBox.Text))]))
                {
                    Debug.WriteLine("Removing 2");
                    chosenWorkshopsList.Remove(workshopList[workshopList.FindIndex(x => x.Contains(workshopComboBox.Text))]);
                    chosenWorkBox.Items.Remove(workshopComboBox.Text);
                }
                workButton.Text = "Add";
            }
        }
    }
}
