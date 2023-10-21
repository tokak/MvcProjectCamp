using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        void ContentAdd(Content  content);
        Heading GetByID(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
        List<Content> GetListByHeadingID(int id);
    }
}
