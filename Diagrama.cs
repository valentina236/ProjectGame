using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Diagrama : Form
    {
        List<PlayerData> playerDatas = new List<PlayerData>();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Diagrama(List<PlayerData> playerDatas)
        {
            InitializeComponent();
            this.playerDatas = playerDatas;
            DisplayDiagram();
        }

        private void Diagrama_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 40;

            // create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // bottom-left corner

            // create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
                }
            }
        }

        private void DisplayDiagram() 
        {
            foreach (PlayerData playerData in playerDatas)
            {
                chart1.Series["SeriesCorrectAnswers"].Points.AddXY(playerData.PlayerName, playerData.CorrectAnswers);
                chart1.Series["SeriesIncorrectAnswers"].Points.AddXY(playerData.PlayerName, playerData.IncorrectAnswers);
            }
            chart1.Update();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
