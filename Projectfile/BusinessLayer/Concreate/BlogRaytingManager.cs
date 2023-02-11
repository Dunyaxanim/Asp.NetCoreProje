using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    class BlogRaytingManager : IBlogRaytingService
    {
        IBlogRaytingDal _blogRaytingDal;
        public BlogRaytingManager(IBlogRaytingDal blogRaytingDal)
        {
            _blogRaytingDal = blogRaytingDal;
        }

        public List<BlogRayting> GetList()
        {
            return _blogRaytingDal.GetListAll();
        }

        public void TAdd(BlogRayting t)
        {
            throw new NotImplementedException();
        }

        public void TDelet(BlogRayting t)
        {
            throw new NotImplementedException();
        }

        public BlogRayting TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public int TGetCount()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(BlogRayting t)
        {
            throw new NotImplementedException();
        }
    }
}
