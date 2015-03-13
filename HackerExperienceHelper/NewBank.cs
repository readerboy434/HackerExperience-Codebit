using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace HackerExperienceHelper
{
    public partial class NewBank : Form
    {
        public static Dictionary<string, string> Banks;
        public NewBank()
        {
            InitializeComponent();
        }

        public class BankAdd
        {
            public string Number { get; set; }
            public string IP { get; set; }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (AccountNumberTextBox.Text != "" && BankIPTextBox.Text != "")
            {
                BankAdd ToAddBank = new BankAdd();
                ToAddBank.Number = Convert.ToString(AccountNumberTextBox.Text);
                ToAddBank.IP = Convert.ToString(BankIPTextBox.Text);

                var IPFinal = JsonConvert.SerializeObject(ToAddBank, Formatting.Indented);
                File.WriteAllText("Banks.json", IPFinal);

                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled out.");
            }
        }
    }
}
