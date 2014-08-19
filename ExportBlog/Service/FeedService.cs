using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBlog.Service
{
    /// <summary>
    /// 资源抓取服务
    /// </summary>
    public class FeedService
    {
        IFeedService service = null;
        Exception excep = null;

        public FeedService(Source src, string user)
        {
            user = user.ToLower();
            try
            {
                switch (src)
                {
                    case Source.csdn:
                        service = new CsdnService(user);
                        break;
                }
            }
            catch (Exception ex)
            {
                excep = ex;
            }
        }
        private IList<FeedEntity> _list = null;

        public IList<FeedEntity> GetList()
        {
            if (_list == null)
            {
                if (excep != null)
                {
                    _list = new List<FeedEntity>();
                }
                else
                {
                    _list = service.GetList();
                }
            }
            return _list;
        }
        public bool GetContent(ref FeedEntity entity)
        {
            if (entity.Content != string.Empty) return true;

            System.Threading.Thread.Sleep(2000);

            return service.GetContent(ref entity);
        }

        public FeedEntity GetEntity(string url)
        {
            if (_list == null)
            {
                _list = new List<FeedEntity>();
            }
            foreach (var m in _list)
            {
                if (m.Url == url)
                    return m;
            }
            var entity = service.GetEntity(url);
            entity.Url = url;
            _list.Add(entity);
            return entity;
        }
    }
}
