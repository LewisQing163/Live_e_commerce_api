using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Live_e_commerce.Entities
{
    /// <summary>
    /// 规格表
    /// </summary>
    [Table("Specification")]
    public class Specification:BasicAggregateRoot<Guid>
    {
        public int Long { get; set; }//长度
        public int Width { get; set; }//宽
        public int High { get; set; }//高
        public int Weight { get; set; }//重量
        public string SpecificationRemark { get; set; }//备注
    }
}
