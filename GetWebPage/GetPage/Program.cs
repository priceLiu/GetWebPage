using GetWebPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace GetPage
{
    class Program
    {
        static void Main(string[] args)
        {
            WebPage webInfo = new WebPage("http://zhan.renren.com/flipped2012/more?page=1&count=20");
            //"http://zhan.renren.com/ranzhi12/more?page=1&count=20"

            string context = webInfo.Context;  
            string html = webInfo.M_html;

            List<Link> result = webInfo.Links;
            IEnumerable<IGrouping<string,Link>> tmp = result.GroupBy(o => o.Tag);
            //var tmp2 = result.Where(o => o.Tag == "img" & (o.Src.IndexOf("xlarge") > -1 || o.Src.IndexOf("original") > -1)).ToList();

            var imgs = result.Where(o => o.Tag == "img").ToList();
        }
    }
}
