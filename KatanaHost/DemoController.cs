using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KatanaHost
{
    public class DemoController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "Marcos" };
        }
    }
}
