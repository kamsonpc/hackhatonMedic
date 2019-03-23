using Microsoft.AspNetCore.Antiforgery;
using HealthBack.Controllers;

namespace HealthBack.Web.Host.Controllers
{
    public class AntiForgeryController : HealthBackControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
