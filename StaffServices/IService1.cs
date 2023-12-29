using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StaffServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //Assignment 4 mandatory services

        [OperationContract]
        [WebGet(UriTemplate = "/weather/forecast/{zipcode}", ResponseFormat = WebMessageFormat.Json)]
        List<string> Weather5day(string zipcode);

        [OperationContract]
        [WebGet(UriTemplate = "/fah/to/cel/{fahrenheit}")]
        string f2c(string fahrenheit);

        [WebGet(UriTemplate = "/cel/to/fah/{celsius}")]
        [OperationContract]
        string c2f(string celsius);

        [OperationContract]
        string DownloadData(string completeURI);
    }
}
