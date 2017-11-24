using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebClient.ServiceDgitron;

namespace WebClient.Controllers
{

    public class TestController : ApiController
    {

        private DigitronClient _digitronClient;

        public TestController()
        {
           // _digitronClient = new DigitronClient();
        }
        
        [Route("api/test/Get")]
        public string Get()
        {
            return _digitronClient.OpaCupa();
        }

        //[HttpGet] //ako e direktno od api treba da ide so Get
        [HttpPost]
        [Route("api/test/plus")]
        public double Soberi(int value1, int value2)
        {
            return _digitronClient.Plus(value1, value2);
        }

        [HttpPost]
        [Route("api/test/minus")]
        public double Minus(int odzimanje1, int odzimanje2)
        {
            return _digitronClient.Minus(odzimanje1, odzimanje2);
        }

        [HttpPost]
        [Route("api/test/mnozi")]
        public double Mnozi(int Mnozi1, int Mnozi2)
        {
            return _digitronClient.Mnozi(Mnozi1, Mnozi2);
        }

        [HttpPost]
        [Route("api/test/Deli")]
        public double Deli(int value1, int value2)
        {
            return _digitronClient.Deli(value1, value2);
        }

       
    }
}
