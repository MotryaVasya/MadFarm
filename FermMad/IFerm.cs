using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    internal interface IFerm
    {
        int max_count_animals { get; }
        List<IAnimal> animals { get; }
    }

}
