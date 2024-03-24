using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace CreatWebService.Sevice
{
    internal class MDCWebService
    {
        [WebService(Namespace = "http://localhost:3000/mdc")]
        [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
        [System.ComponentModel.ToolboxItem(false)]
        public class MDCCalculator : System.Web.Services.WebService
        {
            [WebMethod]
            public int CalculateMDC(int x, int y)
            {
                while (y != 0)
                {
                    int temp = y;
                    y = x % y;
                    x = temp;
                }
                return x;
            }
        }
    }
}

