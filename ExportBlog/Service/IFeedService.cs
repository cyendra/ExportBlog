using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        bool GetContent(ref FeedEntity entity);

        /// <summary>
        /// 通过文章url获取内容
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        FeedEntity GetEntity(string url);

        /// <summary>
        /// 获取文本中的图片数
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int GetImageCount(ref FeedEntity entity);

        /// <summary>
        /// 下载指定编号的图片
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="idx"></param>
        /// <returns></returns>
        Image DownloadImage(ref FeedEntity entity,int idx);
    }
}
