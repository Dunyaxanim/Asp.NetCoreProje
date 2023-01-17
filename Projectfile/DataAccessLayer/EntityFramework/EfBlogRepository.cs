using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListCategoryByWriter(int id)
        {
            using (var context = new Context()) 
            {
                return context.Blogs.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
            }
        }
        public int GetCountBlogByWriterID(int id)
        {
            using (var context = new Context())
            {
                return context.Blogs.Where(x => x.WriterID == id).Count();
            }
        }
        public List<Blog> GetListWithCategory()
        {

            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }

        }
    }
}
