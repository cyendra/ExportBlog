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
        Regex reg_title2 = new Regex(@"");
        Regex reg_con = new Regex(@"");

        WebUtility web = null;

        public CsdnService(string un)
        {
            url = "";
            web = new WebUtility();
        }
        
        IList<FeedEntity> GetList()
        {
            var list = new List<FeedEntity>();
            int p = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (p > 0 && i > p) break;
                web.URL = string.Format(url, i);
                string html = web.Get();
                if (p == 0)
                {
                    var mp = Regex.Match(html, @"");
                    if (mp.Success) p = App.ToInt(mp.Groups[1].Value);
                    else p = 1;
                }
                var mats = reg_title.Match(html);
                if (mats.Count == 0) break;
                foreach (Match mat in mats)
                {
                   
                }
            }
        }

        public bool GetContent(ref FeedEntity entity)
        {
            web.URL = entity.Url;
            string html = web.Get();
            Match mat = reg_con.Match(html);
            if (mat.Success)
            {
                entity.Content = mat.Groups[1].Value.Trim();
            }
            return mat.Success;
        }

        public FeedEntity GetEntity(string url)
        {
            var entity = new FeedEntity();
            web.URL = url;
            string html = web.Get();
            Match mat = reg_title2.Match(html);
            if (mat.Success)
            {
                entity.Title = mat.Groups[1].Value.Trim();
            }
            mat = reg_con.Match(html);
            if (mat.Success)
            {
                entity.Content = mat.Groups[1].Value.Trim();
            }
            return entity;
        }
    }
}
