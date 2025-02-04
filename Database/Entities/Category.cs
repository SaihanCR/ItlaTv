using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Category : BaseBasicEntity
    {
        //Navigation Property
        public ICollection<Series> SeriesMainlist { get; set; }
        public ICollection<Series> SeriesSecondaryList { get; set; }
    }
}
