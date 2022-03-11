using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCo
{
    public partial class MainForm : Form
    {
        private static MainForm _instance;

        private bool SideMenuHidden;

        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainForm();
                }
                return _instance;
            }
        }

        private MainForm()
        {
            InitializeComponent();
            SideMenuHidden = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SideMenuHidden)
            {
                pnlSideMenu.Width = pnlSideMenu.Width + 10;
                if (pnlSideMenu.Width >= 152)
                {
                    SideMenuHidden = false;
                    timer1.Stop();
                }
            }
            else
            {
                pnlSideMenu.Width = pnlSideMenu.Width - 10;
                if (pnlSideMenu.Width <= 52)
                {
                    SideMenuHidden = true;
                    timer1.Stop();
                }
            }
        }

        private void lbSideMenuLogo_MouseEnter(object sender, EventArgs e)
        {
            if (SideMenuHidden)
            {
                timer1.Start();
            }
        }

        private void lbSideMenuLogo_MouseLeave(object sender, EventArgs e)
        {
            if (!SideMenuHidden)
            {
                timer1.Start();
            }
        }
    }
}
