using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminRepository : GenericRepository<Admin>, IAdminDal
    {
        public List<Admin> GetAdminById(int id)
        {
            using (var context = new Context())
            {
                return context.Admins.Where(x => x.AdminID == id).ToList();
            }
        }
    }
}
