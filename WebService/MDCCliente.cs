using CreatWebService.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace MDCClient
{
    internal class MDCClient
    {
        static void Main(string[] args)
        {
            try
            {
                MDCWebService.MDCCalculator client = new MDCWebService.MDCCalculator();
                int x = 640; // Largura 
                int y = 480; // Altura 
                int mdc = client.CalculateMDC(x, y);
                double aspectRatioX = (double)x / mdc;
                double aspectRatioY = (double)y / mdc;
                Console.WriteLine($"Aspect Ratio: {aspectRatioX}:{aspectRatioY}");
            }
            catch (SoapException ex)
            {
                Console.WriteLine($"SOAP Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
