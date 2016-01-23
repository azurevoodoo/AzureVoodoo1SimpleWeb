using Nancy;

namespace SimpleWebApplication
{
    public class WebModule : NancyModule
    {
        public WebModule()
        {
            Get["/"] = _ => "Welcome to the very simple web";
        }
    }
}
