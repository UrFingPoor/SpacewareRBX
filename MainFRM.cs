using FastColoredTextBoxNS;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace SpacewareRBX
{
    public partial class MainFRM : Form
    {
        public SpaceWareAPI api = new SpaceWareAPI();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public MainFRM()
        {
            InitializeComponent();
            DownloadHandler.InitializeDownloadHandler();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
        }
        #region "Mouse/Form Events"
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void Object_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void Object_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void Object_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Advert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://solo.to/lamer");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (Config.Patched.Contains("False"))
                    statusLbl.Text = $"Status: Undetected!";
                else
                    statusLbl.Text = $"Status: Patched!";
                codeBox.Language = Language.Lua;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.StackTrace, "Oh Shit!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void inject_Click(object sender, EventArgs e)
        {
            try
            {
                if (!api.IsAPIAttached)
                    DownloadHandler.CleanUp();
                DownloadHandler.Download_Injector();
                attchedLbl.Text = "Injected: YES!";
            }
            catch { }
        }
        private void SendluaBTN_Click(object sender, EventArgs e)
        {
            api.SendLuaScript(codeBox.Text);
        }
        private void SendLuaCBTN_Click(object sender, EventArgs e)
        {
            api.SendLuaCScript(codeBox.Text);
        }
        private void OpenFIleBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
                if (ofd.ShowDialog() == DialogResult.OK)
                    api.SendLuaScript(System.IO.File.ReadAllText(ofd.FileName));
        }
        private void SaveFileBTN_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
                if (sfd.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(sfd.FileName, codeBox.Text);
        }
        private void DiscordBTN_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/3bpkkJ7Gq4");
        }
    }
}