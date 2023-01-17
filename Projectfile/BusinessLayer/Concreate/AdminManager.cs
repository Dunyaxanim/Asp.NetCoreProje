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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public List<Admin> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Admin t)
        {
            throw new NotImplementedException();
        }

        public void TDelet(Admin t)
        {
            throw new NotImplementedException();
        }

        public Admin TGetById(int id)
        {

            return _adminDal.GetById(id);
        }
        
        public int TGetCount()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Admin t)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetByIdAdmin(int id)
        {
            return _adminDal.GetAdminById(id);
        }
    }
}
