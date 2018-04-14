using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace AutoShutDown
{
    public partial class Form1 : Form
    {
        private readonly PerformanceCounter _cpuCounter;
        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            GetCurrentCpuUsage();
        }

        private void LoadSettings()
        {
            tbCPUMax.Text = Properties.Settings.Default.CpuMax;
            tbTime.Text = Properties.Settings.Default.Time;
            if (Properties.Settings.Default.ActionType == 0)
                rbtnHibernate.Checked = true;
            else
                rbtnShutdown.Checked = true;
        }

        public float GetCurrentCpuUsage()
        {
            return _cpuCounter.NextValue();
        }

        private double _cpuMax;
        private double _timeInMinute;
        private double _timeInSeconds;
        private bool _running;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                if (!double.TryParse(tbCPUMax.Text, out _cpuMax) || _cpuMax < 0 || _cpuMax > 100)
                {
                    MessageBox.Show("Invalid cpuMax");
                    return;
                }
                if (!double.TryParse(tbTime.Text, out _timeInMinute) || _timeInMinute < 0 || _timeInMinute > 60)
                {
                    MessageBox.Show("Invalid Time");
                    return;
                }
                _timeInSeconds = _timeInMinute * 60;
                StartTimer();
            }
            else
            {
                tbDisplay.Text = "00:00";
                triggerTimer.Stop();
            }
            _running = !_running;
            RefreshGui();
        }

        private string GetDisplayString()
        {
            var min = (int)_timeInSeconds / 60;
            var sec = (int)_timeInSeconds - min * 60;
            return min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
        }

        private void StartTimer()
        {
            tbDisplay.Text = GetDisplayString();
            triggerTimer.Stop();
            triggerTimer.Start();
        }

        private void RefreshGui()
        {
            tbCPUMax.Enabled = !_running;
            tbTime.Enabled = !_running;
            groupBox.Enabled = !_running;
            btnStart.Text = _running ? "Stop" : "Start";

            if (!_running) Text = "AutoShutdown";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_timeInSeconds > 0)
            {
                var cpuUsage = GetCurrentCpuUsage();
                if(cpuUsage <= _cpuMax)
                    _timeInSeconds -= 1;
                else
                    _timeInSeconds = _timeInMinute * 60;
                tbDisplay.Text = GetDisplayString();
                Text = "CPU Usage: " + Math.Round(cpuUsage,2).ToString(CultureInfo.InvariantCulture) + "%";
            }  
            else
            {
                triggerTimer.Stop();
                _running = !_running;
                RefreshGui();
                if (rbtnHibernate.Checked) Hiberate();
                if (rbtnShutdown.Checked) ForceShutdown();
            }
        }

        //hibernate + shutdown funcs
        private static void ForceShutdown()
        {
            Process.Start("shutdown", "/s /f /t 0");
        }

        [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        private static void Hiberate()
        {
            SetSuspendState(true, true, true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CpuMax = tbCPUMax.Text;
            Properties.Settings.Default.Time = tbTime.Text;
            Properties.Settings.Default.ActionType = rbtnHibernate.Checked ? 0 : 1;
            Properties.Settings.Default.Save();
        }
    }
}
