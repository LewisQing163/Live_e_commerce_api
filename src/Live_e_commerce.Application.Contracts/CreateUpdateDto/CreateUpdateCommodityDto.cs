using System;
using System.Collections.Generic;
using System.Text;

namespace Live_e_commerce.CreateUpdateDto
{
    public class CreateUpdateCommodityDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Weight { get; set; }
        public string Picture { get; set; }
        public Guid Cid { get; set; }
    }
}
