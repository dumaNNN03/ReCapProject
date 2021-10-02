using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Color:IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
