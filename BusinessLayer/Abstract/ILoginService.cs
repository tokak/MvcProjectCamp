﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILoginService
    {
        List<Admin> GetList();
        void AdminAdd(Admin admin);
        Admin GetByID(Admin admin);
        void AdminDelete(Admin admin);
        void AdminUpdate(Admin admin);
    }
}
