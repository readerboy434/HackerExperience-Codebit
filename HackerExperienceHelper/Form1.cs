using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HackerExperienceHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void NewIP_Click(object sender, EventArgs e)
        {
            NewIP IPForm = new NewIP();
            IPForm.ShowDialog();
        }

        private void NewBank_Click(object sender, EventArgs e)
        {
            NewBank BankForm = new NewBank();
            BankForm.ShowDialog();
        }

        private void NewBTC_Click(object sender, EventArgs e)
        {
            NewBTC BTCForm = new NewBTC();
            BTCForm.ShowDialog();
        }
    }
}
