using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LogInForm1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            
            
            

            var ghoramiTech = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) +
                             "\\Abir\\Hossain";

            

            var location = Path.Combine(ghoramiTech, "jubayer.md");
            var data = File.ReadAllText(location);

            List<Form1.VALUE> userDataDeserializeObject =
                JsonConvert.DeserializeObject<List<Form1.VALUE>>(data);

            label_gtype.Text = userDataDeserializeObject[0].gType;
            label_sopnoid.Text = userDataDeserializeObject[0].sopnoid;
            label_uemail.Text = userDataDeserializeObject[0].uemail;





        }
    }
}
