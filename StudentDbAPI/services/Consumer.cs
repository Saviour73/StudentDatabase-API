using StudentDbAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDbAPI.services
{
    public class Consumer : IConsumer
    {
        public IOperationTransient _operationtransientprop { get; set; }

    

        public Consumer(IOperationTransient operationprop)
        {
            _operationtransientprop = operationprop;
           
            var guidinconsumer = operationprop.Operationid;

            Console.WriteLine($"guid of transientin consumer service is: {operationprop.Operationid}");
            
        }

    }
}
