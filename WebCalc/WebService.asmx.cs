using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebCalc
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Calc(int num1, int num2, string opt)
        {
            int result = 0;
            switch (opt)
            {
                case "+":
                    result = (num1 + num2);
                    break;
                case "-":
                    result = (num1 - num2);
                    break;
                case "*":
                    result = (num1 * num2);
                    break;
                case "/":
                    result = (num1 / num2);
                    break;
                default:
                    result = 0;
                    break;
            }

            return result.ToString();

        }
    }
}
