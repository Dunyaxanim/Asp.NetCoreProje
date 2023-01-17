using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IAdminService:IGenericServices<Admin>
    {
        List<Admin> GetByIdAdmin(int id);
    }
}
