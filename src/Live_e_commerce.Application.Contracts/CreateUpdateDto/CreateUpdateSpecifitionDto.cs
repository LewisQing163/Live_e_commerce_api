﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Live_e_commerce.CreateUpdateDto
{
   public  class CreateUpdateSpecifitionDto
    {
        public int Long { get; set; }//长度
        public int Width { get; set; }//宽
        public int High { get; set; }//高
        public int Weight { get; set; }//重量
        public string SpecificationRemark { get; set; }//备注
    }
}
