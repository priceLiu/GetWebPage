using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPage
{
    class Program
    {
        static void Main(string[] args)
        {
            WebPage webInfo = new WebPage("网址");

            string context = webInfo.Context;//不包含html标签的所有内容  

            string html = webInfo.M_html;//包含html标签的内容  
        }
    }
}
