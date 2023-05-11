using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMenuService
    {
        List<Menu> MenuList();
        void MenuAdd(Menu menu);
        Menu GetByID(int id);
        void MenuDelete(Menu id);
        void MenuUpdate(Menu menu);
    }
}
