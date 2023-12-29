using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StaffServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string DownloadData(string completeURI)
        {
            Uri uri = new Uri("https://" + completeURI);// creating uri
            WebClient webClient = new WebClient();//making instantiating webclient 
            string downloadedWeb = webClient.DownloadString(uri);//downloading uri as string
            return downloadedWeb;//returning it 
        }

        public List<string> Weather5day(string zipcode)
        {
            const string API_KEY = "2e75ee7603fa06447e9d6c346a1aea3b"; // my api key, DO NOT USE FOR YOUR OWN
            string baseURL = "https://api.openweathermap.org";
            string completeURL = string.Concat(baseURL, $"/data/2.5/forecast?zip={zipcode.Trim()},us&appid={API_KEY}").Trim();
            List<string> weatherForecast = new List<string>(); //LIST OF STRINGS for 5 day weather, will be used to add weatherforecasts
            Uri uri = new Uri(completeURL);

            var request = WebRequest.Create(uri);
            var response = request.GetResponse();
            var jsonResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //deserializing the object, need to know what the Json format of the reponse looks like before hand
            //to be able to get the data correctly
            var weatherReportFull = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
            // getting first days date from weather forecast list 
            var previousDate = DateTime.Parse(weatherReportFull.list[0].dt_txt.ToString());
            //creating first days weather foreast into a string 
            string todaysWeatherToString = "Date: " + weatherReportFull.list[0].dt_txt.ToString() + "\n";
            todaysWeatherToString += "Temperature: " + weatherReportFull.list[0].main.temp + "\n";
            todaysWeatherToString += "Max Temperature: " + weatherReportFull.list[0].main.temp_max + "\n";
            todaysWeatherToString += "Min Temperature: " + weatherReportFull.list[0].main.temp_min + "\n";
            todaysWeatherToString += "Weather Description: " + weatherReportFull.list[0].weather[0].description + "\n";
            //adding todays weather string to weatherforecast list
            //list will be 5 elements big for the 5 days weather it's getting
            weatherForecast.Add(todaysWeatherToString);
            //looping through weather report list and checking by date of the first day 
            foreach (var todaysWeather in weatherReportFull.list)
            {
                //getting date bye parsing the date string by format of the string 
                var todaysDate = DateTime.Parse(todaysWeather.dt_txt.ToString()).Date;
                //comparing todays date by the previous forecasts date 
                //if todays date is  day bigger from todays date 
                if (todaysDate > previousDate)
                {
                    //parsing new dates weather forecast 
                    todaysWeatherToString = "Date: " + todaysWeather.dt_txt.ToString() + "\n";
                    todaysWeatherToString += "Temperature: " + todaysWeather.main.temp + "\n";
                    todaysWeatherToString += "Max Temperature: " + todaysWeather.main.temp_max + "\n";
                    todaysWeatherToString += "Min Temperature: " + todaysWeather.main.temp_min + "\n";
                    todaysWeatherToString += "Weather Description: " + todaysWeather.weather[0].description + "\n";
                    weatherForecast.Add(todaysWeatherToString);
                    previousDate = todaysDate;
                }
            }
            //returning weatherforecast list 
            return weatherForecast;
        }

        public string f2c(string fahrenheit)
        {
            double value = (double.Parse(fahrenheit) - 32.0) * (5.0 / 9.0);
            Console.WriteLine(value);
            return value.ToString();
        }
        public string c2f(string celsius)
        {
            double value = (double.Parse(celsius) * (9.0 / 5.0)) + 32.0;
            return value.ToString();
        }
        public string sort(string text)
        {
            string[] numbers = text.Split(',');
            Console.WriteLine(numbers);
            Array.Sort(numbers);
            Console.WriteLine(numbers);
            return string.Join(",", numbers);
        }
    }
}
