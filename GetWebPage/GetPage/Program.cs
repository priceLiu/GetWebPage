using GetWebPage;
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
            WebPage webInfo = new WebPage("http://msdn.microsoft.com/zh-cn/library/system.web.httputility(v=vs.110).aspx");

            string context = webInfo.Context;  
            string html = webInfo.M_html;

            List<Link> result = webInfo.Links;

            IEnumerable<IGrouping<string,Link>> tmp = result.GroupBy(o => o.Tag);

        }
    }
}
