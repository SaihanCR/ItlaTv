using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Producer : BaseBasicEntity
    {
        //Navigation Property
        public ICollection<Series> SeriesList { get; set; }  
    }
}
