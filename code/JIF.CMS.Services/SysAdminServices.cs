using JIF.CMS.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIF.CMS.Services
{
    public class SysAdminServices
    {
        public jif_sysadmin Load(int id)
        {
            return new SysAdminRepository().Load(id);
        }


        public List<jif_sysadmin> Load()
        {
            return new SysAdminRepository().Load();
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public  void Test()
        {

        }
    }
}
