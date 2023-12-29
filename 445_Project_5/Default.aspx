<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_445_Project_5._Default" enableEventValidation="false"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        table, th, td {
            border: 1px solid black;
        }
    </style>
    <div class="jumbotron">
        <h1>Landing Page</h1>
        <div id="WelcomeUserDiv" runat="server">
            <p>
                <asp:Label ID="Label_Welcome" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label_UserName" runat="server"></asp:Label>
            </p>
        </div>
        <table>
            <tr>
                <td>
                    <h2>Staff 1:</h2>
                    <p>How Can I Access Staff 1 page?</p>
                    <p>Log in using:</p>
                    <p>username: &quot;TA1&quot; </p>
                    <p>password: &quot;TAPassword1&quot;</p>
                    <h2>WebDownloading:</h2>
                    <p class="lead">Description: It takes a URL in string as input and returns the content at the given URL.</p>
                    <p class="lead">URL for the service : <a href="http://webstrar23.fulton.asu.edu/page3/Service1.svc">http://webstrar23.fulton.asu.edu/page3/Service1.svc</a></p>
                    <p class="lead">Method: String WebDownloading(String URL);</p>

                </td>
                <td>
                    <h2>Staff 1:</h2>
                    <p>How Can I Access Staff 1 page?</p>
                    <p>Log in using:</p>
                    <p>username: &quot;TA1&quot; </p>
                    <p>password: &quot;TAPassword1&quot;</p>
                    <h2>Weather Service:</h2>
                    <p class="lead">
                        Description: Creates a 5-day weather forecast service of zipcode location based on the OpenWeather Free API
                    </p>
                    <p class="lead">
                        URL for the service : <a href="http://webstrar23.fulton.asu.edu/page9/Service1.svc">http://webstrar23.fulton.asu.edu/page9/Service1.svcc</a>
                    </p>
                    <p class="lead">
                        Method: List&lt;String&gt; WeatherService(String ZipCode);
                    </p>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>Staff 2:</h2>
                    <p>How Can I Access Staff 2 page?</p>
                    <p>Log in using:</p>
                    <p>username: &quot;TA2&quot; </p>
                    <p>password: &quot;TAPassword2&quot;</p>
                    <h2>fahrenheit to celsius service:</h2>
                    <p class="lead">
                        Description: Allows user to convert fahrenheit to celsius and returns a string of the conversion
                    </p>
                    <p>
                        URL for the service: <a href="http://webstrar23.fulton.asu.edu/page9/Service1.svc">http://webstrar23.fulton.asu.edu/page9Service1.svc</a>
                    </p>
                    <p>
                        Method: string f2c(string fahrenheit);
                    </p>
                </td>
                <td>
                    <h2>Staff 2:</h2>
                    <p>How Can I Access Staff 2 page?</p>
                    <p>Log in using:</p>
                    <p>username: &quot;TA2&quot; </p>
                    <p>password: &quot;TAPassword2&quot;</p>
                    <h2>celsius to fahrenheit service:</h2>
                    <p class="lead">
                        Description: Allows user to convert celsius to fahrenheit and returns a string of the conversion
                    </p>
                    <p class="lead">
                        URL for the service: <a href="http://webstrar23.fulton.asu.edu/page9/Service1.svc">http://webstrar23.fulton.asu.edu/page9/Service1.svc</a>
                    </p>
                    <p class="lead">
                        Method: string c2f(string celsius);
                    </p>
                </td>
            </tr>
            <tr>
                <td>
                    <h2>Member:</h2>
                    <p>How Can I Access Members page?</p>
                    <p>Create:</p>
                    <p>username: Your own user name</p>
                    <p>password: Your own password</p>
                    <p>Once you have made your user name and password click register! Check persistant Cookie to keep you logged in for 30 minutes!</p>
                    <h2>Sort Text service:</h2>
                    <p>
                        Description: Allows user to enter text EX: "5,4,3,2,1" and it will sort it -> "1,2,3,4,5"
                    </p>
                    <p>URL for the service: <a href="http://webstrar23.fulton.asu.edu/page8/Service1.svc">http://webstrar23.fulton.asu.edu/page8/Service1.svc</a></p>
                    <p class="lead">
                        Method:  string sort(string text);
                    </p>
                    <p class="lead">
                        Enter numbers separated by ',' to sort
                    </p>
                    <p class="lead">
                        You will get the result back sorted and seperated by commas.</p>
                </td>
                <td>
                    <h2>Member:</h2>
                    <p>How Can I Access Members page?</p>
                    <p>Create:</p>
                    <p>username: Your own user name</p>
                    <p>password: your own password</p>
                    <p>Once you have made your user name and password click register! Check persistant Cookie to keep you logged in for 30 minutes!</p>
                    <h2>Currency Service:</h2>
                    <p class="lead">
                        Description: Allows user to pick and convert from 5 currencies of their choice and allows them to enter an amount they would like to convert.
                    </p>
                    <p class="lead">
                        &nbsp;Based on <a href="https://fixer.io">https://fixer.io</a> free API allowed only 100 uses per month
                    </p>
                    <p class="lead"><a href="http://webstrar23.fulton.asu.edu/page8/Service1.svc">http://webstrar23.fulton.asu.edu/page8/Service1.svc</a></p>
                    <p class="lead">
                        Method: string currenecyConverter(string from, string to, string amount);
                    </p>
                </td>
            </tr>
        </table>

    </div>

</asp:Content>
