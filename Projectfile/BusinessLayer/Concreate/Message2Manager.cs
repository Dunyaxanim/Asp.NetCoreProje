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
    public class Message2Manager : IMessage2Services
    {
        IMessage2Dal _message2Dal;
        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }
        public List<Message2> GetInboxListByWriter(int id)
        {
            
            return _message2Dal.GetListMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            
            return _message2Dal.GetListAll();
        }

        public List<Message2> GetListWithMessaageByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelet(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            
            return _message2Dal.GetById(id);
        }

        public int TGetCount()
        {
            return _message2Dal.GetCount();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
