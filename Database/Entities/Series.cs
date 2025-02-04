using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Series : BaseBasicEntity
    {
        public string CoverPath { get; set; }
        public string Link { get; set; }
        public int MainCategoryId { get; set; } //FK
        public int? SecondaryCategoryId { get; set; } //FK
        public int ProducerId { get; set; } //FK

        //Navigation Property
        public Category MainCategory { get; set; }
        public Category SecondaryCategory { get; set; }
        public Producer Producer { get; set; }
    }
}
