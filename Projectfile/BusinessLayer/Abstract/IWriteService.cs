using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriteService:IGenericServices<Writer>
    {
        List<Writer> GetWriterById(int id);
    }
}
