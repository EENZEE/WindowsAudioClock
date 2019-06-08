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
 
        public AudioClockForm()
        {
            InitializeComponent();
            myTimer.Elapsed += new ElapsedEventHandler( DisplayTimeEvent );
            myTimer.Interval = 1000;
            myTimer.Start();

        }

        public void DisplayTimeEvent( object source, ElapsedEventArgs e )
        {
            int hours = 0;
            int allMinutes = 0;
            int singleMinutes = 0;
            int decaMinutes = 0;

            string nowString = DateTime.Now.ToShortTimeString();

            // nowString = "9:20 PM";
            // lastString = "9:19 PM";

            if (nowString != lastString)
            {
                UpdateDisplay(nowString);
                lastString = nowString;
                char[] tags = {':', ' '};
                string[] timeArray = nowString.Split(tags);

                if (int.TryParse(timeArray[1], out allMinutes))
                {
                    return;
                }

                if (int.TryParse(timeArray[0], out hours))
                {
                    return;
                }

                singleMinutes = allMinutes % 10;
                decaMinutes = allMinutes - singleMinutes;

                 if (allMinutes == 0 && (hourCheckBox.Checked || quarterHourCheckBox.Checked))
                 {
                     saySomething(timeArray[0]);
                     saySomething("OCLOCK");
                     saySomething(timeArray[3]);
                     return;
                 }

                 if ((quarterHourCheckBox.Checked && 
                      (allMinutes == 15 || allMinutes == 30 || allMinutes == 45) 
                      || (halfHourCheckBox.Checked && (allMinutes == 30)) 
                      || (hourCheckBox.Checked && allMinutes == 0) 
                      || allMinutesCheckBox.Checked))  
                 {
                     saySomething(Convert.ToString(timeArray[0]));
                     saySomething(Convert.ToString(decaMinutes));
                     saySomething(Convert.ToString(singleMinutes));
                    saySomething(timeArray[2]);
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
                    file = ".\\resources\\AM.wav";
                    break;
                case "PM":
                   file = ".\\resources\\PM.wav";
                    break;
                case "00":
                case "OCLOCK":
                   file = ".\\resources\\OCLOCK.wav";
                    break;
                case "0":
                    file = ".\\resources\\OH.wav";  // fix this
                    break;
                case "1":
                    file = ".\\resources\\ONE.wav"; 
                    break;
                case "2":
                    file = ".\\resources\\TWO.wav"; 
                    break;
                case "3":
                    file = ".\\resources\\THREE.wav"; 
                    break;
                case "4":
                    file = ".\\resources\\FOUR.wav"; 
                    break;
                case "5":
                    file = ".\\resources\\FIVE.wav"; 
                    break;
                case "6":
                    file = ".\\resources\\SIX.wav"; 
                    break;
                case "7":
                    file = ".\\resources\\SEVEN.wav"; 
                    break;
                case "8":
                    file = ".\\resources\\EIGHT.wav"; 
                    break;
                case "9":
                    file = ".\\resources\\NINE.wav"; 
                    break;
                case "10":
                    file = ".\\resources\\TEN.wav"; 
                    break;
                case "11":
                    file = ".\\resources\\ELEVEN.wav"; 
                    break;
                case "12":
                    file = ".\\resources\\TWELVE.wav"; 
                    break;
                case "13":
                    file = ".\\resources\\THIRTEEN.wav";
                    break;
                case "14":
                    file = ".\\resources\\FOURTEEN.wav"; 
                    break;
                case "15":
                    file = ".\\resources\\FIFTEEN.wav"; 
                    break;
                case "16":
                    file = ".\\resources\\SIXTEEN.wav"; 
                    break;
                case "17":
                    file = ".\\resources\\SEVENTEEN.wav"; 
                    break;
                case "18":
                    file = ".\\resources\\EIGHTEEN.wav"; 
                    break;
                case "19":
                    file = ".\\resources\\NINETEEN.wav"; 
                    break;
                case "20":
                    file = ".\\resources\\TWENTY.wav"; 
                    break;
                case "30":
                    file = ".\\resources\\THIRTY.wav";
                    break;
                case "40":
                    file = ".\\resources\\FOURTY.wav";
                    break;
                case "50":
                    file = ".\\resources\\FIFTY.wav";
                    break;
                case "60":
                    file = ".\\resources\\SIXTY.wav";
                    break;
                case "70":
                    file = ".\\resources\\SEVENTY.wav";
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
