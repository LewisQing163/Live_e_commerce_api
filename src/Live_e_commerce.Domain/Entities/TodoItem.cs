using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_e_commerce.Entities
{
    public class TodoItem:Volo.Abp.Domain.Entities.BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
