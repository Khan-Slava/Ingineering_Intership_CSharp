using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DLL
{
    public interface IRepository<T>
    {
        ReturnResult<T> GetAll();
        ReturnResult<T> Create(T data);
        ReturnResult<T> Update(T data);
       

    }
}
