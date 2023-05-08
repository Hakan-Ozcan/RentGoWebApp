using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        void UserAdd(User user);
        User GetByID(int id);
        void UserDelete(User id);
        void UserUpdate(User user);
    }
}
