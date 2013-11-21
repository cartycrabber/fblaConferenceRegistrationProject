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
        string participantsFile = @"\PARTICIPANTS.txt";

        #endregion

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
            if (!File.Exists(dataFolder + participantsFile))
            {
                File.Create(dataFolder + participantsFile).Close();
            }
//            Directory.CreateDirectory(dataFolder);
//            File.Create(dataFolder + participantsFile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeParticipant();
        }

        private void writeParticipant()
        {
            using (System.IO.StreamWriter participants = new System.IO.StreamWriter(Application.StartupPath + @"\Data\PARTICIPANTS.txt", true))
            {
                participants.WriteLine("This is a test");
            }
        }
    }
}
