using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Drawing;

namespace ExportBlog.Service
{
    public class FeedEntity
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsDown { get; set; }
        public string Cate { get; set; }
        public List<Image> Images { get; set; }
        public FeedEntity()
        {
            Content = string.Empty;
            IsDown = true;
            Images = new List<Image>();
        }
        public void Dispose()
        {
            Url = null;
            Title = null;
            Content = null;
            Cate = null;
            Images = null;
        }
    }
    public enum Source
    {
        [Description("博客园")]
        cnblogs = 1,
        [Description("ITEYE")]
        iteye,
        [Description("新浪")]
        sina,
        [Description("搜狐")]
        sohu,
        [Description("和讯")]
        hexun,
        [Description("ChinaUnix")]
        chinaunix,
        [Description("网易")]
        _163,
        [Description("51CTO")]
        _51cto,
        [Description("CSDN")]
        csdn,
        [Description("开源中国")]
        oschina,
    }
}
