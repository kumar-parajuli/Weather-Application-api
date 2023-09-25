using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weather_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ApiKey = "a9db2bfe920d645e0bf1f0b59aaeaf33";
        private void Search_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, ApiKey);
                var json = web.DownloadString(url);
                Weatherinfo.root info = JsonConvert.DeserializeObject<Weatherinfo.root>(json);


               
                picIcon.ImageLocation = backgroundImageUrl;
                //picIcon.ImageLocation = "https://openweathermap.org/img/w/02n.png" + info.weather[0].icon + ".png";
                labCondiction.Text = info.weather[0].main;
                labDetail.Text = info.weather[0].description;
                labeSunsine.Text = info.sys.sunrise.ToString();
                labeSunset.Text = info.sys.sunset.ToString();
                labWindspeed.Text = info.wind.speed.ToString();
                labPressure.Text = info.main.pressure.ToString();

            }
        }


        private void labeSunsine_Click(object sender, EventArgs e)
        {

        }
    }
}
