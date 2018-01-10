using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TimerForTomato
{
    public partial class Form1 : Form
    {
        System.Timers.Timer WorkTimer = new System.Timers.Timer();
        System.Timers.Timer BreakTimer = new System.Timers.Timer();
        int CircleCount = 0;
        NotifyIcon notifyIcon;

        public Form1()
        {
            InitializeComponent();

            notifyIcon = new NotifyIcon();
            //进程在通知区域中的图标  
            notifyIcon.Icon = SystemIcons.WinLogo;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (WorkTime.Text.Equals("") || BreakTime.Text.Equals("") || TomatoCircle.Text.Equals(""))
            {
                MessageBox.Show(this, "Please set the fucking time!", "You should set the fucking time you want to", MessageBoxButtons.OK);
                return;
            }

            WorkTimer.Interval = double.Parse(WorkTime.Text) * 1000 * 60;
            WorkTimer.Elapsed += StartBreakTimer;
            WorkTimer.AutoReset = false;

            BreakTimer.Interval = double.Parse(BreakTime.Text) * 1000 * 60;
            BreakTimer.Elapsed += StartWorkTimer;
            BreakTimer.AutoReset = false;

            CircleCount = int.Parse(TomatoCircle.Text);

            WorkTimer.Start();
        }

        private void StartBreakTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            SetNotifyIcon("Take a break!");

            BreakTimer.Start();
        }

        private void StartWorkTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (CircleCount != 0)
            {
                CircleCount -= CircleCount > 0 ? 1 : 0;
                SetNotifyIcon("Start working!");
                WorkTimer.Start();
            }
            else
                return;
        }

        void SetNotifyIcon(string Text)
        {
            //弹出气泡的提示文本  
            notifyIcon.BalloonTipText = Text + " " + DateTime.Now;
            //弹出气泡的标题  
            notifyIcon.BalloonTipTitle = "计时器提示！";
            //弹出气泡上显示的图标  
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            //进程提示文本  
            notifyIcon.Text = "计时器进程";            
            //在任务栏中显示气泡提示,持续时间为1000毫秒             
            notifyIcon.ShowBalloonTip(100);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            WorkTimer.Dispose();
            BreakTimer.Dispose();
            notifyIcon.Dispose();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();   //隐藏窗体
                notifyIcon.Visible = true; //使托盘图标可见
            }
        }
    }
}
