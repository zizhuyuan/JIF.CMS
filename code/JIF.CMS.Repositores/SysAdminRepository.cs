using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIF.CMS.Repositores
{
    public class SysAdminRepository
    {
        public jif_sysadmin Load(int id)
        {
            return new Entities().jif_sysadmin.SingleOrDefault(d=>d.Id == id);
        }

        public List<jif_sysadmin> Load()
        {
            return new Entities().jif_sysadmin.ToList();
        }
    }
}
