using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBlog.Service
{
    public class FeedEntity
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsDown { get; set; }
        public FeedEntity()
        {
            Content = string.Empty;
            IsDown = true;
        }
        public void Dispose()
        {
            Url = null;
            Title = null;
            Content = null;
        }
    }
    public enum Source
    {
        //[Description("CSDN")]
        csdn
    }
}
