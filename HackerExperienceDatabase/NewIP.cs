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
    public partial class NewIP : Form
    {
        public NewIP()
        {
            InitializeComponent();
        }

        public class IPAdd
        {
            public string IP { get; set; }
            public string Name { get; set; }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (IPTextBox.Text != "")
            {
                IPAdd ToAddIP = new IPAdd();
                ToAddIP.IP = Convert.ToString(IPTextBox.Text);
                ToAddIP.Name = Convert.ToString(NameTextBox.Text);

                using (FileStream fs = File.Open(@"IPs.json", FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, ToAddIP);
                    sw.WriteLine("");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("IP Field cannot be blank.");
            }

        }
    }
}
