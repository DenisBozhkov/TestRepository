using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDB<T>
        where T : BaseModel
    {
        void Create(T model);
        T Read(Guid id);
        IList<T> ReadAll();
        void Update(T model);
        void Delete(Guid id);
    }
}
