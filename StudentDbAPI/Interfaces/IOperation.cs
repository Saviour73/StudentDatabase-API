using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDbAPI.Interfaces
{
    public interface IOperation
    {
        Guid Operationid { get; }
    }

    public interface IOperationTransient : IOperation
    {

    }
}
