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

namespace MembersOnlyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string sort(string text)
        {
            string[] numbers = text.Split(',');
            Console.WriteLine(numbers);
            Array.Sort(numbers);
            Console.WriteLine(numbers);
            return string.Join(",", numbers);
        }

        //contains API call to data.fixer.io to get currency value exclusively in europen base currency value for the following 
        //currencies. I will convert from and to by getting the currencies chosen by the user in europen value and making the conversion myself
        public string currenecyConverter(string from, string to, string amount)
        {
            double convertingFrom;
            double convertingTo;
            double amountDouble = double.Parse(amount);
            const string API_KEY = "67bd014498a40709d04e731dff00c823"; //API KEY LIMITED AT A 100 free api calls per month, please do not take the key
            string baseURL = "http://data.fixer.io";
            string completeURL = string.Concat(baseURL, $"/api/latest?access_key={API_KEY}").Trim();
            Uri uri = new Uri(completeURL);

            var request = WebRequest.Create(uri);
            var response = request.GetResponse();
            var jsonResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //deserializing the object, need to know what the Json format of the reponse looks like before hand
            //to be able to get the data correctly
            var currencyReport = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
            //reason for this is to convert from european base to "from" base currency
            //by getting the currency by country currency accronym I have the european base value of the currency
            //API is free but limited and won't allow currency conversion
            //therefore I will convert it myself 
            //inorder to reduce lines i will hardcode the currency acronym
            switch (from)
            {
                case "USD":
                    convertingFrom = currencyReport.rates.USD;
                    break;
                case "AUD":
                    convertingFrom = currencyReport.rates.AUD;
                    break;
                case "GBP":
                    convertingFrom = currencyReport.rates.GBP;
                    break;
                case "CAD":
                    convertingFrom = currencyReport.rates.CAD;
                    break;
                case "JPY":
                    convertingFrom = currencyReport.rates.JPY;
                    break;
                default:
                    convertingFrom = 0;
                    break;
            }
            //reason for this is as mentioned before, I have to convert to the next currency
            //by getting the currency value by country currency accronym 
            switch (to)
            {
                case "USD":
                    convertingTo = currencyReport.rates.USD;
                    break;
                case "AUD":
                    convertingTo = currencyReport.rates.AUD;
                    break;
                case "GBP":
                    convertingTo = currencyReport.rates.GBP;
                    break;
                case "CAD":
                    convertingTo = currencyReport.rates.CAD;
                    break;
                case "JPY":
                    convertingTo = currencyReport.rates.JPY;
                    break;
                default:
                    convertingTo = 0;
                    break;
            }
            //formula to convert from and to 
            var formula = convertingTo / convertingFrom * amountDouble;
            return formula.ToString();
        }
    }
}
