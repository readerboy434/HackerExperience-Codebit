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
    public partial class NewBTC : Form
    {
        public NewBTC()
        {
            InitializeComponent();
        }

        public class BTCAdd
        {
            public string PublicKey { get; set; }
            public string PrivateKey { get; set; }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PublicTextBox.Text != "" && PrivateTextBox.Text != "")
            {
                BTCAdd ToAddBTC = new BTCAdd();
                ToAddBTC.PublicKey = Convert.ToString(PublicTextBox.Text);
                ToAddBTC.PrivateKey = Convert.ToString(PrivateTextBox.Text);

                using (FileStream fs = File.Open(@"BTC.json", FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, ToAddBTC);
                    sw.WriteLine("");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled out.");
            }
        }
    }
}
