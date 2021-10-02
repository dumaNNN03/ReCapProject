using Entitiy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Concrete
{
    public class Color:IEntitiy
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
