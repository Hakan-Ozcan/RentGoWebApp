using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProgramsService
    {
        void ProgramsAdd(Programs user);
        void ProgramsDelete(Programs id);
        List<Programs> GetList();

    }
}
