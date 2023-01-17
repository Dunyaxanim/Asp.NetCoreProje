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
    public class NewsLatterManager : INewsLatterService
    {
        INewsLatterDal _newsLatterDal;
        public NewsLatterManager(INewsLatterDal newsLatterDal)
        {
            _newsLatterDal = newsLatterDal;
        }
        public void AddNewsLatter(NewsLetter newsLatter)
        {
            _newsLatterDal.Insert(newsLatter);

        }
    }
}
