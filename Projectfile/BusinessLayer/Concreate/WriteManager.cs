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
    public class WriteManager : IWriteService
    {
        IWriterDal _writeDal;
        public WriteManager(IWriterDal writerDal)
        {
            _writeDal = writerDal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
         
            return _writeDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Writer t)
        {
          
            _writeDal.Insert(t);
        }

        public void TDelet(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            
            return _writeDal.GetById(id);
        }

        public int TGetCount()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
          
            _writeDal.Update(t);
        }
    }
}
