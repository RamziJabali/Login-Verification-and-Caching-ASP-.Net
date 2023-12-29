using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MembersOnlyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "/currency/convert/{from}/{to}/{amount}", ResponseFormat = WebMessageFormat.Json)]
        string currenecyConverter(string from, string to, string amount);


        [WebGet(UriTemplate = "/sort/{text}")]
        [OperationContract]
        string sort(string text);

    }
}
