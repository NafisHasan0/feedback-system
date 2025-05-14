using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RET>
    {
        RET create(CLASS obj);

        RET update(CLASS obj);

        RET delete(ID id);

        List<CLASS> getAll();

        CLASS get(ID id);

    }
}
