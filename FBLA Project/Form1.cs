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

namespace FBLA_Project
{
    public partial class Form1 : Form
    {

        #region Variables

        string dataFolder = Application.StartupPath + @"\Data";
        string conferencesFile = @"\CONFERENCES.txt";
        string typeFile = @"\TYPE.txt";
        string participantsFile = @"\PARTICIPANTS.txt";
        string workshopsFile = @"\WORKSHOPS.txt";
        string workshopRegistrationsFile = @"\WKSHP_REGISTRATIONS.txt";
        string[] conferences = { "Test Conference 1", "Test Conference 2", "Test Conference 3" };
        string[] participantTypes = { "Member", "Advisor", "Guest" };

        #endregion

        public Form1()
        {
            InitializeComponent();
            conferencesComboBox.Items.AddRange(conferences);
            typeComboBox.Items.AddRange(participantTypes);
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
            writeParticipant(firstNameTextBox.Text, lastNameTextBox.Text, conferencesComboBox.Text, typeComboBox.Text);
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
