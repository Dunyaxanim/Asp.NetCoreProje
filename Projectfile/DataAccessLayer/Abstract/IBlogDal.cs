using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        Blog GetListWithCategory(int id);
        //List<Blog> GetListCategoryByWriter(int id);
        //int GetCountBlogByWriterID(int id);
    }
}
