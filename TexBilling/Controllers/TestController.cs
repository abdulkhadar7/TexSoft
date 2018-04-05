using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using System.Threading.Tasks;

namespace TexBilling.Controllers
{
    public class TestController : ApiController
    {
        private TestService _testService;
        public TestController(TestService testService)
        {
            _testService = testService;
        }

        public async Task<HttpResponseMessage> GetPing()
        {
            var ping = await _testService.GetPing();
            return Request.CreateResponse(HttpStatusCode.OK, ping);
        }
    }
}
