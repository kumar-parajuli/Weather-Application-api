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
//using System.Net;
//using DotNetEnv;

namespace Weather_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           // DotNetEnv.Env.Load();
        }

        //string ApiKey = Env.GetString("API_KEY");
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
                string iconCode = info.weather[0].icon;
                string backgroundImageUrl = "";

                switch (iconCode)
                //{
                //    case "01d": // Clear sky (day)
                //        backgroundImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR3DBsgS34d7tvk8UOsLGNeoNNegZSAeAzkIwz9pnJgAp9OpBXgBSD0cDA_QzodjBmGIao&usqp=CAU";
                //        break;
                //    case "01n": // Clear sky (night)
                //        backgroundImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fclear-sky&psig=AOvVaw0i05cP2DSte6aSTy8OoJg2&ust=1695718817355000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIj13ICzxYEDFQAAAAAdAAAAABAE";
                //        break;
                //    case "02d": // Few clouds (day)
                //        backgroundImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ07XLt4Gc2-c0uHE2QFa3j78IjXBZ8Dys33S_ahgAl_jninMDFUVzQ2ddrezGwmZhHGMk&usqp=CAU";
                //        break;
                //    case "02n": // Few clouds (night)
                //        backgroundImageUrl = "https://images.pexels.com/photos/209831/pexels-photo-209831.jpeg?auto=compress&cs=tinysrgb&w=600";
                //        break;
                //    case "03d": // Scattered clouds (day)
                //    case "03n": // Scattered clouds (night)
                //        backgroundImageUrl = "https://images.pexels.com/photos/209831/pexels-photo-209831.jpeg?auto=compress&cs=tinysrgb&w=600";
                //        break;
                //    case "04d": // Broken clouds (day)
                //    case "04n": // Broken clouds (night)
                //        backgroundImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk3bMBxipgc69eDCjdDSQTmFPkWKD1E6HxfUlV8PX89w&s";
                //        break;
                //    case "09d": // Shower rain (day)
                //    case "09n": // Shower rain (night)
                //        backgroundImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQlqE-HZWwduYgmBodub_aVZTsz9z47XdkzRWq0iNw8MjAWEa0oLrSFWMS-wzjBV_dg4x4&usqp=CAU";
                //        break;

                {
                    case "01d": // Clear sky (day)
                        backgroundImageUrl = WeatherBackgroundUrls.ClearDay;
                        break;
                    case "01n": // Clear sky (night)
                        backgroundImageUrl = WeatherBackgroundUrls.ClearNight;
                        break;
                    case "02d": // Few clouds (day)
                        backgroundImageUrl = WeatherBackgroundUrls.FewCloudsDay;
                        break;
                    case "02n": // Few clouds (night)
                        backgroundImageUrl = WeatherBackgroundUrls.FewCloudsNight;
                        break;
                    case "03d": // Scattered clouds (day)
                    case "03n": // Scattered clouds (night)
                        backgroundImageUrl = WeatherBackgroundUrls.ScatteredClouds;
                        break;
                    case "04d": // Broken clouds (day)
                    case "04n": // Broken clouds (night)
                        backgroundImageUrl = WeatherBackgroundUrls.BrokenClouds;
                        break;
                    case "09d": // Shower rain (day)
                    case "09n": // Shower rain (night)
                        backgroundImageUrl = WeatherBackgroundUrls.ShowerRain;
                        break;

                    default:
                        backgroundImageUrl = "https://openweathermap.org/img/w/02n.png";
                        break;
                }



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
