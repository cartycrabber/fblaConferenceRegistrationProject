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
    public partial class ReportsForm : Form
    {
        string dataFolder;
        string participantsFile;
        string workshopRegistrationFile;
        List<string> reportList = new List<string>();
        List<string> conferencesList;
        List<string> typeList;
        string[] workshopsRegArr;
        string[] participantsArr;
        Form mainForm;

        public ReportsForm(Form form, List<string> conference, List<string> conferenceList, List<string> type, List<string> workshops, string data, string participants, string workshopRegistration)
        {
            InitializeComponent();
            reportList.Clear();
            reportListBox.Items.Clear();
            label1.Visible = false;
            sortChapterButton.Visible = false;
            sortTypeButton.Visible = false;
            mainForm = form;
            dataFolder = MainForm.dataFolder;
            participantsFile = MainForm.participantsFile;
            workshopRegistrationFile = MainForm.workshopRegistrationsFile;
            conferencesList = MainForm.conferenceInfoList;
            typeList = MainForm.typeList;
            Debug.WriteLine("Reports Form Intializing");
            foreach(string conf in conferenceList)
            {
                Debug.WriteLine(conf);
                ToolStripMenuItem x = new ToolStripMenuItem();
                x.Text = conf;
                x.Click += new EventHandler(confToolTipClick);
                conferenceParticipantsToolStripMenuItem.DropDownItems.Add(x);
            }
            foreach(string work in workshops)
            {
                ToolStripMenuItem x = new ToolStripMenuItem();
                x.Text = work;
                x.Click += new EventHandler(workToolTipClick);
                workshopParticipantsToolStripMenuItem.DropDownItems.Add(x);
            }
            workshopsRegArr = File.ReadAllLines(dataFolder + workshopRegistrationFile);
            participantsArr = File.ReadAllLines(dataFolder + participantsFile);
        }
        void confToolTipClick(object sender, EventArgs e)
        {
            label1.Visible = true;
            sortChapterButton.Visible = true;
            sortTypeButton.Visible = true;
            writeConferneceReport(sender);
        }
        void workToolTipClick(object sender, EventArgs e)
        {
            label1.Visible = false;
            sortChapterButton.Visible = false;
            sortTypeButton.Visible = false;
            writeWorkshopReport(sender);
        }

        void writeConferneceReport(object conference)
        {
            reportListBox.Items.Clear();
            reportList.Clear();
            string conferenceID = conferencesList[conferencesList.FindIndex(x => x.Contains(conference.ToString())) - 1];
            foreach(string participants in participantsArr)
            {
                string[] splitPart = participants.Split(',');
                if(splitPart[1].Trim() == conferenceID.Trim())
                {
                    reportList.Add(splitPart[0] + ", " + splitPart[2] + ", " + splitPart[3] + ", " + splitPart[4] + ", " + splitPart[5]);
                }
            }
            reportListBox.Items.AddRange(reportList.ToArray());
        }

        void writeWorkshopReport(object workshop)
        {
            reportListBox.Items.Clear();
            reportList.Clear();
            string workshopID = MainForm.workshopList[MainForm.workshopList.FindIndex(x => x.Contains(workshop.ToString()))][0].Trim();
            foreach (string work in workshopsRegArr)
            {
                string[] splitWork = work.Split(',');
                if (splitWork[1].Trim() == workshopID)
                {
                    foreach (string participants in participantsArr)
                    {
                        string[] splitPart = participants.Split(',');
                        if(splitPart[0].Trim() == splitWork[0].Trim())
                        {
                            reportList.Add(splitPart[2] + ", " + splitPart[3] + ", " + splitPart[4] + ", " + splitPart[5]);
                        }
                    }
                }
            }
            reportListBox.Items.AddRange(reportList.OrderBy(r => r.Split(',')[2]).ToArray());
        }

        private void sortTypeButton_Click(object sender, EventArgs e)
        {
            reportListBox.Items.Clear();
            reportListBox.Items.AddRange(sortByType(reportList).ToArray());
        }

        private void sortChapterButton_Click(object sender, EventArgs e)
        {
            reportListBox.Items.Clear();
            reportListBox.Items.AddRange(sortByChapter(reportList).ToArray());
        }

        private List<string> sortByType(List<string> list)
        {
            return list.OrderBy(r => r.Split(',')[1]).ThenBy(r2 => r2.Split(',')[3]).ToList();
        }

        private List<string> sortByChapter(List<string> list)
        {
            return list.OrderBy(r => r.Split(',')[4]).ThenBy(r => r.Split(',')[1]).ThenBy(r => r.Split(',')[3]).ToList();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            reportList.Clear();
            reportListBox.Items.Clear();
            label1.Visible = false;
            sortChapterButton.Visible = false;
            sortTypeButton.Visible = false;
            Hide();
            mainForm.Show();
        }

        private void searchTextbox_Enter(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "Search Participant Name")
            {
                searchTextbox.Text = "";
                searchTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextbox_Leave(object sender, EventArgs e)
        {
            if(searchTextbox.Text == "")
            {
                searchTextbox.Text = "Search Participant Name";
                searchTextbox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            bool partFound = false;
            string partID = null;
            string partChap = null;
            string partType = null;
            string partConf = null;
            string partName = null;
            foreach(string participant in participantsArr)
            {
                string[] splitPart = participant.Split(',');
                if (splitPart[3].TrimStart() + splitPart[4].TrimEnd() == searchTextbox.Text)
                {
                    partFound = true;
                    partID = splitPart[0].Trim();
                    partChap = splitPart[5].Trim();
                    partType = splitPart[2].Trim();
                    partConf = splitPart[1].Trim();
                    partName = splitPart[3].TrimStart() + splitPart[4].TrimEnd();
                    break;
                }
            }
            if (partFound)
            {
                reportList.Clear();
                reportListBox.Items.Clear();
                reportList.Add(partName);
                reportList.Add("Chapter: " + partChap);
                reportList.Add("Participant Type: " + MainForm.participantTypes.First(x => x.Contains(partType)).Split(',')[1]);
                reportList.Add("Conference: " + MainForm.conferences.First(x => x.Contains(partConf)).Split(',')[1]);
                reportList.Add("");
                reportList.Add("Registered Workshops: ");
                foreach(string work in workshopsRegArr)
                {
                    if(work.Split(',')[0] == partID)
                    {
                        reportList.Add(MainForm.workshops.First(x => x.Contains(work.Split(',')[1])).Split(',')[2].Trim() + ", " + MainForm.workshops.First(x => x.Contains(work.Split(',')[1])).Split(',')[4].Trim() + ", " + MainForm.workshops.First(x => x.Contains(work.Split(',')[1])).Split(',')[5].Trim());
                    }
                }
            }
            else
                MessageBox.Show("Participant Not Found. Did you spell it correctly?", "Error");
            reportListBox.Items.AddRange(reportList.ToArray());
        }
    }
}
