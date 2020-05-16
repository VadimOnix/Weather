using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherWinFormsApp;
using WeatherWinFormsApp.API;
using WeatherWinFormsApp.MODEL;
using WeatherWinFormsApp.UTILS;

namespace WeatherWinFormsApp
{
    public partial class MainForm : Form
    {
        private WeatherAPI WeatherAPI = new WeatherAPI();
        public MainForm()
        {
            InitializeComponent();
            this.Text = new ConnectChecker().IsAvailable() ? "Доступно!" : "Недоступно";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            pnSearchBorder.BackColor = Color.White;
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            pnSearchBorder.BackColor = Color.FromArgb(108, 117, 125);
        }

        private void btnSetToday_Click(object sender, EventArgs e)
        {
                pnMenuTab.Top = btnSetToday.Top;
                pnMenuTab.Height = btnSetToday.Height;
        }

        private void btnSetWeek_Click(object sender, EventArgs e)
        {
            pnMenuTab.Height = btnSetWeek.Height;
            pnMenuTab.Top = btnSetWeek.Top;
        }
    }
}

