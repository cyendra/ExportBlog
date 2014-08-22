using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBlog.Service
{
    internal interface IFeedService
    {
        /// <summary>
        /// 获取文章列表
        /// </summary>
        /// <returns></returns>
        IList<FeedEntity> GetList();

        /// <summary>
        /// 获取文章内容
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool GetContent(ref FeedEntity entity,out string cate);

        /// <summary>
        /// 通过文章url获取内容
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        FeedEntity GetEntity(string url);
    }
}
