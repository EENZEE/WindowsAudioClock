using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;


namespace WindowsFormsApplication1
{
    public delegate void UpdateDisplayCallBack(string text);

    public partial class AudioClockForm : Form
    {
        System.Media.SoundPlayer player =
           new System.Media.SoundPlayer();
        public static System.Timers.Timer myTimer = new System.Timers.Timer();
        private string lastString;
//        private string soundPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + System.IO.Path.DirectorySeparatorChar + "sounds" + System.IO.Path.DirectorySeparatorChar;
        static string resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources");
        static string soundPath = System.IO.Path.Combine(resFolder, "sounds") + System.IO.Path.DirectorySeparatorChar;

        public AudioClockForm()
        {
            InitializeComponent();
            myTimer.Elapsed += new ElapsedEventHandler( DisplayTimeEvent );
            myTimer.Interval = 1000;
            myTimer.Start();

        }

        public void DisplayTimeEvent( object source, ElapsedEventArgs e )
        {
            int allMinutes = 0;
            int singleMinutes = 0;
            int decaMinutes = 0;

            string nowString = DateTime.Now.ToShortTimeString();

            

            //nowString = "12:00 PM";
            //lastString = "11:59 AM";

            if (nowString != lastString)
            {
                UpdateDisplay(nowString);
                lastString = nowString;
                char[] tags = {':', ' '};
                string[] timeArray = nowString.Split(tags);

                if (!int.TryParse(timeArray[1], out allMinutes))
                {
                    return;
                }

                singleMinutes = allMinutes % 10;
                decaMinutes = allMinutes - singleMinutes;

                 if (allMinutes == 0 && (hourCheckBox.Checked || quarterHourCheckBox.Checked))
                 {
                     saySomething(timeArray[0]);
                     saySomething("OCLOCK");
//                     saySomething(timeArray[3]);
                     return;
                 }

                 if ((quarterHourCheckBox.Checked && 
                      (allMinutes == 15 || allMinutes == 30 || allMinutes == 45) 
                      || (halfHourCheckBox.Checked && (allMinutes == 30)) 
                      || (hourCheckBox.Checked && allMinutes == 0) 
                      || allMinutesCheckBox.Checked))  
                 {
                    
                     saySomething(Convert.ToString(timeArray[0]));
                    if (allMinutes > 19)
                    {
                        saySomething(Convert.ToString(decaMinutes));
                        saySomething(Convert.ToString(singleMinutes));
                        saySomething(timeArray[2]);
                    }
                    else
                    {
                        saySomething(Convert.ToString(allMinutes));
                    }
                 }
            }
        }

        private void UpdateDisplay(string text)
        {

            if (timeLabel.InvokeRequired)
            {
                UpdateDisplayCallBack d = new UpdateDisplayCallBack(this.UpdateDisplay);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.timeLabel.Text = text;
            }

            
        }

        private void saySomething(string something)
        {
            string file = null;

            switch (something)
            {
                case "AM":
                    file = soundPath + "AM.wav";
                    break;
                case "PM":
                   file = soundPath + "PM.wav";
                    break;
                case "00":
                case "OCLOCK":
                   file = soundPath + "OCLOCK.wav";
                    break;
                case "0":
                    file = soundPath + "OH.wav";  // fix this
                    break;
                case "1":
                    file = soundPath + "ONE.wav"; 
                    break;
                case "2":
                    file = soundPath + "TWO.wav"; 
                    break;
                case "3":
                    file = soundPath + "THREE.wav"; 
                    break;
                case "4":
                    file = soundPath + "FOUR.wav"; 
                    break;
                case "5":
                    file = soundPath + "FIVE.wav"; 
                    break;
                case "6":
                    file = soundPath + "SIX.wav"; 
                    break;
                case "7":
                    file = soundPath + "SEVEN.wav"; 
                    break;
                case "8":
                    file = soundPath + "EIGHT.wav"; 
                    break;
                case "9":
                    file = soundPath + "NINE.wav"; 
                    break;
                case "10":
                    file = soundPath + "TEN.wav"; 
                    break;
                case "11":
                    file = soundPath + "ELEVEN.wav"; 
                    break;
                case "12":
                    file = soundPath + "TWELVE.wav"; 
                    break;
                case "13":
                    file = soundPath + "THIRTEEN.wav";
                    break;
                case "14":
                    file = soundPath + "FOURTEEN.wav"; 
                    break;
                case "15":
                    file = soundPath + "FIFTEEN.wav"; 
                    break;
                case "16":
                    file = soundPath + "SIXTEEN.wav"; 
                    break;
                case "17":
                    file = soundPath + "SEVENTEEN.wav"; 
                    break;
                case "18":
                    file = soundPath + "EIGHTEEN.wav"; 
                    break;
                case "19":
                    file = soundPath + "NINETEEN.wav"; 
                    break;
                case "20":
                    file = soundPath + "TWENTY.wav"; 
                    break;
                case "30":
                    file = soundPath + "THIRTY.wav";
                    break;
                case "40":
                    file = soundPath + "FOURTY.wav";
                    break;
                case "50":
                    file = soundPath + "FIFTY.wav";
                    break;
                case "60":
                    file = soundPath + "SIXTY.wav";
                    break;
                case "70":
                    file = soundPath + "SEVENTY.wav";
                    break;
            }

            if (file != null)
            {
                playSound(file);
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            DisplayTimeEvent(sender, null);
        }

        private void playSound(string path)
        {
            player.SoundLocation = path;
            player.Load();
            player.PlaySync();
            player.Dispose();
        }

        private void AudioClockForm_Load(object sender, EventArgs e)
        {


        }
    }
}
