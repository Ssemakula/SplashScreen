using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class SplashScreen : Form
    {
        static SplashScreen splashScreen = null;
        static Thread oThread = null;

        //Fading
        private double dblOpacityIncrement = .05;
        private double dblOpacityDecrement = .08;
        private const int TIMER_INTERVAL = 50;

        //Status string
        private string statusString;

        //Status indicators
        private double completedFraction = 0.0;
        private Rectangle progressRect;

        private int iActualTicks; 

        public SplashScreen()
        {
            InitializeComponent();
            this.ClientSize = this.BackgroundImage.Size;
            this.Opacity = 0.0;
            splashTimer.Interval = TIMER_INTERVAL;
            splashTimer.Start();
        }

        static public double Progress
        {
            get
            {
                if(splashScreen != null)
                    return splashScreen.completedFraction;
                return 1.0;
            }
            set
            {
                if(splashScreen != null)
                    splashScreen.completedFraction = value;
            }
        }

        static private void ShowForm()
        {
            splashScreen = new SplashScreen();
            Application.Run(splashScreen);
        }

        static public void CloseForm()
        {
            if (splashScreen != null) 
            { 
                //Slowly fade
                splashScreen.dblOpacityIncrement = -splashScreen.dblOpacityDecrement;
            }
            oThread = null; //No longer needed
            splashScreen = null; //?? Better to destroy?
            //splashScreen.Close();
        }

        static public void ShowSplashScreen()
        {
            //Launch once
            if (splashScreen != null)
                return;
            oThread = new Thread(new ThreadStart(SplashScreen.ShowForm))
            {
                IsBackground = true
            };
            oThread.SetApartmentState(ApartmentState.STA);
            oThread.Start();
            while (splashScreen == null || splashScreen.IsHandleCreated)
                System.Threading.Thread.Sleep(TIMER_INTERVAL);
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //Draw the filler rectangle
            int width = (int)Math.Floor(statusPanel.ClientRectangle.Width * completedFraction);
            int height = statusPanel.ClientRectangle.Height;
            int x = statusPanel.ClientRectangle.X;
            int y = statusPanel.ClientRectangle.Y;

            if(dblOpacityIncrement > 0)
            {
                if (this.Opacity < 1)
                    this.Opacity += dblOpacityIncrement;
            }
            else
            {
                if (this.Opacity > 0)
                    this.Opacity += dblOpacityIncrement;
                else
                    this.Close();
            }
            statusLabel.Text = statusString;
            if (width > 0 && height > 0)
            {
                progressRect = new Rectangle(x, y, width, height);
                if (!statusPanel.IsDisposed)
                {
                    Graphics g = statusPanel.CreateGraphics();
                    LinearGradientBrush background =
                        new LinearGradientBrush(progressRect,
                            Color.FromArgb(50, 50, 200),
                            Color.FromArgb(150, 150, 255),
                            LinearGradientMode.Horizontal);
                    g.FillRectangle(background, progressRect);
                    g.Dispose();
                }
            }
        }

        static public void SetStatus(string newStatus)
        {
            if (splashScreen == null)
                return;
            splashScreen.statusString = newStatus;
        }
    }
}
