using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LoginManager : ILoginService
    {
        ILoginDal _loginDal;

        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public void AdminAdd(Admin admin)
        {
            _loginDal.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _loginDal.Delete(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _loginDal.Update(admin);
        }

        public Admin GetByID(Admin admin)
        {
            var value = _loginDal.Get(x=>x.AdminUserName==admin.AdminUserName && x.AdminPassword==admin.AdminPassword);
            return value;
        }

        public List<Admin> GetList()
        {
            return _loginDal.List();
        }
    }
}
