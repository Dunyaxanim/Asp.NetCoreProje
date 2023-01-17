﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericServices<T>
    {
        void TAdd(T t);
        void TDelet(T t);
        void TUpdate(T t);
        List<T> GetList();
        T TGetById(int id);
        int TGetCount();
    }
}
