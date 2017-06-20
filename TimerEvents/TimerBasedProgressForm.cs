using System;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class TimerBasedProgressForm : Form
    {
        System.Windows.Forms.Timer t;

        public TimerBasedProgressForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 10;
            if (progressBar.Value >= 100) t.Stop();
        }
    }
}
