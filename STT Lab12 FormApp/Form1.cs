using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace STT_Lab12_FormApp
{
    public partial class Form1 : Form
    {
        private DateTime _targetTime;
        private readonly System.Windows.Forms.Timer _timer;
        private readonly Random _rand = new Random();
        private bool _alarmAcknowledged = false;


        public Form1()
        {
            InitializeComponent();

            // Initialize and configure the timer.
            _timer = new System.Windows.Forms.Timer
            {
                Interval = 1000  // tick every second
            };
            _timer.Tick += Timer_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(
                    txtTime.Text,
                    "HH:mm:ss",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out _targetTime))
            {
                MessageBox.Show(
                    "Invalid time format. Please enter in HH:MM:SS.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            txtTime.Enabled = false;
            btnStart.Enabled = false;

            lblStatus.Text = $"Alarm is set for {_targetTime:HH:mm:ss}";

            _timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Center the button horizontally on load
            btnStart.Location = new System.Drawing.Point(
                (this.ClientSize.Width - btnStart.Width) / 2,
                btnStart.Location.Y
            );
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= _targetTime)
            {
                _timer.Stop();
                this.BackColor = SystemColors.Control;
                // Start beeping in a background thread
                Thread beepThread = new Thread(() =>
                {
                    while (!_alarmAcknowledged)
                    {
                        Console.Beep(3000, 500); // frequency: 3000Hz, duration: 500ms
                        Thread.Sleep(100);       // wait between beeps
                    }
                });
                beepThread.IsBackground = true;
                beepThread.Start();

                MessageBox.Show(
                    $"⏰ Alarm! It’s now {_targetTime:HH:mm:ss}",
                    "Alarm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _alarmAcknowledged = true; // stops the beep loop
                return;
            }

            this.BackColor = Color.FromArgb(
                _rand.Next(100,256),
                _rand.Next(100,256),
                _rand.Next(100,256));
        }
    }
}
