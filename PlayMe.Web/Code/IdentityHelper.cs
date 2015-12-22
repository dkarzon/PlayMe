using System.Web;

namespace PlayMe.Web.Code
{
    public class IdentityHelper : IIdentityHelper
    {
        public string GetCurrentIdentityName()
        {
            return HttpContext.Current.Request.UserHostName;
        }
    }
}