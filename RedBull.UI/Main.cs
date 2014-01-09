namespace RedBull.UI
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        public Main()
        {
            this.InitializeComponent();

            _elapsedSeconds = 0;
        }

        private uint m_previousExecutionState;

        private int _elapsedSeconds;


        private void Main_Load(object sender, EventArgs e)
        {
            btnInsomnia.BackColor = Color.LightGray;
            btnCure.BackColor = Color.LightGray;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            this.WakeUp();
        }

        private void StayAwake()
        {
            this.m_previousExecutionState = NativeMethods.SetThreadExecutionState(NativeMethods.ES_DISPLAY_REQUIRED | NativeMethods.ES_CONTINUOUS);
        }
        
        private void WakeUp()
        {
            NativeMethods.SetThreadExecutionState(NativeMethods.ES_CONTINUOUS);
        }

        private void btnInsomnia_Click(object sender, EventArgs e)
        {
            this.StayAwake();

            _elapsedSeconds = 0;

            timer.Start();
            
            btnInsomnia.Enabled = false;
            btnCure.Enabled = true;
            btnInsomnia.BackColor = Color.Green;
        }

        private void btnCure_Click(object sender, EventArgs e)
        {
            this.WakeUp();

            timer.Stop();

            lblTimer.Text = "I could sleep...";

            btnInsomnia.Enabled = true;
            btnCure.Enabled = false;
            btnInsomnia.BackColor = Color.LightGray;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _elapsedSeconds++;

            var minutes = _elapsedSeconds / 60;

            lblTimer.Text = string.Format("Can't sleep, it's been {0} minutes", minutes);
        }

        internal static class NativeMethods
        {
            // Import SetThreadExecutionState Win32 API and necessary flags 
            public const uint ES_CONTINUOUS = 0x80000000;

            public const int ES_AWAYMODE_REQUIRED = 0x00000040;

            public const uint ES_SYSTEM_REQUIRED = 0x00000001;

            public const uint ES_DISPLAY_REQUIRED = 0x00000002;

            [DllImport("kernel32.dll")]
            public static extern uint SetThreadExecutionState(uint esFlags);
        }
    }
}