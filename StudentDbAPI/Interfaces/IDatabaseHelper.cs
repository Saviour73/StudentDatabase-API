using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDbAPI.Interfaces
{
    public interface IDatabaseHelper
    {
        public DataTable ExecuteQuery(string query);
    }
}
