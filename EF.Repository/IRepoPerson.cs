using EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repository
{
    public interface IRepoPerson
    {
        Person GetById(int id);
    }
}
