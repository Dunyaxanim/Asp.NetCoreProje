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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentdal = commentDal;
        }
        public void CommentAdd(Comment comment)
        {
           
            _commentdal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            
            return _commentdal.GetListAll(x => x.BlogID == id);

        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TDelet(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public int TGetCount()
        {
            return _commentdal.GetCount();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
