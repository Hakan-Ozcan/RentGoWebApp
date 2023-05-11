using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MenuManager:IMenuService
    {
        IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public Menu GetByID(int id)
        {
            return _menuDal.Get(x => x.ID == id);
        }

        public void MenuAdd(Menu menu)
        {
            _menuDal.Insert(menu);
        }

        public void MenuDelete(Menu id)
        {
            _menuDal.Delete(id);
        }

        public List<Menu> MenuList()
        {
            return _menuDal.List();
        }

        public void MenuUpdate(Menu menu)
        {
            _menuDal.Update(menu);
        }
    }
}
