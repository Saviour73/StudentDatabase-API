using StudentDbAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDbAPI.services
{
    public class OperationTransientservice : IOperationTransient
    {
        Guid _guid;

        public OperationTransientservice()
        {
            _guid = Guid.NewGuid();
        }

        public Guid Operationid => _guid;
    }

}
