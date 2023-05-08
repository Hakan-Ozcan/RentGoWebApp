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
    public class ProgramsManager : IProgramsService
    {
        IProgramsDal _programsDal;
        public ProgramsManager(IProgramsDal programsDal)
        {
            _programsDal = programsDal;
        }

        public List<Programs> GetList()
        {
            return _programsDal.List();
        }

        public void ProgramsAdd(Programs programs)
        {
            _programsDal.Insert(programs);
        }

        public void ProgramsDelete(Programs id)
        {
            _programsDal.Delete(id);
        }
    }
}
