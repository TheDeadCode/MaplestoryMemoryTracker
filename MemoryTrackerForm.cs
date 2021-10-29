using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaplestoryMemoryTracker
{
    public partial class MemoryTrackerForm : Form
    {
        private readonly Timer _memoryTrackerTimer = new Timer();
        private const string ProcessName = "MapleStory";

        public MemoryTrackerForm()
        {
            InitializeComponent();

            _memoryTrackerTimer.Interval = 5000; // Every 5 seconds, check status of maple
            _memoryTrackerTimer.Tick += MemoryTrackerTimerOnTick;

            _memoryTrackerTimer.Start();

            // Trigger a tick immediately;
            MemoryTrackerTimerOnTick();
        }

        private void MemoryTrackerTimerOnTick(object sender = null, EventArgs e = null)
        {
            var processList = Process.GetProcessesByName(ProcessName);

            if (processList.Length == 0)
            {
                MemoryStatusLabel.Text = @"Game not running...";
                this.ResetBackColor();
                MemoryStatusLabel.ForeColor = Color.Black;

                return;
            }

            var process = processList[0];
            process.Refresh(); // Clear cache

            var sizeInGigabytes = ToGigabyte(process.WorkingSet64);

            // Now check how unstable this is
            var maxGood = (long) (2 /* Gigabytes */ * Math.Pow(1024, 3));
            var maxForGrinding = (long) Math.Floor(2.8 * Math.Pow(1024, 3));

            string status;

            if (process.WorkingSet64 <= maxGood)
            {
                status = "All Good";
                BackColor = Color.LimeGreen;
                MemoryStatusLabel.ForeColor = Color.Black;
            } else if (process.WorkingSet64 <= maxForGrinding)
            {
                status = "Warning";
                BackColor = Color.Yellow;
                MemoryStatusLabel.ForeColor = Color.Black;
            }
            else
            {
                status = "Danger!";
                BackColor = Color.Red;
                MemoryStatusLabel.ForeColor = Color.White;
            }

            MemoryStatusLabel.Text = $@"{status} ({sizeInGigabytes} GB)";
        }

        private static string ToGigabyte(long value)
        {
            return (value / Math.Pow(1024, 3)).ToString("0.000");
        }

        private void OnForegroundCheckboxChanged(object sender, EventArgs e)
        {
            TopMost = ForceForegroundCheckbox.Checked;
        }
    }
}
