using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExportBlog.Service
{
    internal class CsdnService : IFeedService
    {
        string url = null;

        Regex reg_title = new Regex(@"");
        Regex reg_con = new Regex(@"");

        WebUtility web = null;

        IList<FeedEntity> IFeedService.GetList()
        {
            throw new NotImplementedException();
        }

        bool IFeedService.GetContent(ref FeedEntity entity)
        {
            throw new NotImplementedException();
        }

        FeedEntity IFeedService.GetEntity(string url)
        {
            throw new NotImplementedException();
        }
    }
}
