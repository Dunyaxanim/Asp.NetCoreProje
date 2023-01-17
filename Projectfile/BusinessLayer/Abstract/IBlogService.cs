using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericServices<Blog>
    {
     
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetListBlogCategoryByWriterId(int id);
        List<Blog> GetBlogListByWriter(int id);
        List<Blog> GetLast3Blog();
        List<Blog> GetBlogByID(int id);
        int GetBlogCountByWriterID(int id);
    }
}
