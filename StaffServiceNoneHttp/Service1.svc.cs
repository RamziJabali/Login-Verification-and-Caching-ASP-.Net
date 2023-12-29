using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StaffServiceNoneHttp
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
    }
}
