using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;

namespace ExportBlog.Service
{
    internal class CsdnService : IFeedService
    {
        String site = "http://blog.csdn.net/";
        string url = null;

        Regex reg_title = new Regex(@"<span class=""link_title""><a href=""(.+?)"">([^<]+?)</a></span>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex reg_con = new Regex(@"<div id=""article_content"" class=""article_content"">([\s\S]+)</div>\s*<!-- Baidu Button BEGIN -->", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex reg_cate = new Regex(@"<span class=""link_categories"">\s*分类：\s*<a.+?>([^<]+?)</a>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
       
        Regex reg_code1 = new Regex(@"(<(pre|textarea) [^>]+?>)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex reg_code2 = new Regex(@"(</(pre|textarea))>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex reg_img = new Regex(@"<img[^>]+?src=['""]([^>]+?)['""][^>]+?>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex reg_br = new Regex(@"<(/p|/div|br[\s/]*)>[\r\n]*?", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex reg_html = new Regex(@"<.+?>", RegexOptions.Compiled);

        WebUtility web = null;

        public CsdnService(string un)
        {
            url = site + un + "/article/list/{0}?viewmode=contents";
            web = new WebUtility();
        }

        public IList<FeedEntity> GetList()
        {
            var list = new List<FeedEntity>();

            int p = 0;
            for (int i = 1; p == 0 || i <= p; i++)
            {
                web.URL = string.Format(url, i);
                string html = web.Get();
                if (p == 0)
                {
                    var mp = Regex.Match(html, @"共(\d+)页");
                    if (mp.Success) p = App.ToInt(mp.Groups[1].Value);
                    else p = 1;
                }
                var mats = reg_title.Matches(html);
                if (mats.Count == 0) break;
                foreach (Match mat in mats)
                {
                    var fd = new FeedEntity();
                    fd.Url = site + mat.Groups[1].Value;
                    fd.Title = mat.Groups[2].Value.Trim();
                    list.Add(fd);
                }
            }
            return list;
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
            Match matc = reg_cate.Match(html);
            string res = "";
            if (matc.Success)
            {
                res = matc.Groups[1].Value.Trim();
            }
            entity.Cate = res;
            var mats = reg_img.Matches(entity.Content);
            foreach (Match mt in mats)
            {
                entity.Images.Add(mt.Groups[1].Value);
            }
            return mat.Success;
        }

        public FeedEntity GetEntity(string url)
        {
            var entity = new FeedEntity();

            web.URL = url;
            string html = web.Get();
            Match mat = reg_title.Match(html);
            if (mat.Success)
            {
                entity.Title = mat.Groups[2].Value.Trim();
            }
            mat = reg_con.Match(html);
            if (mat.Success)
            {
                entity.Content = mat.Groups[1].Value.Trim();
            }
            return entity;
        }

        int GetImageCount(ref FeedEntity entity)
        {
            return entity.Images.Count;
        }
        Image DownloadImage(ref FeedEntity entity, int idx)
        {
            if (idx >= entity.Images.Count || idx < 0) return null;
            WebUtility imgWeb = new WebUtility();
            imgWeb.URL = entity.Images[idx];
            Image img = imgWeb.GetImage();
            return img;
        }
    }
}
