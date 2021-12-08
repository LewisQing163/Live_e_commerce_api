using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Live_e_commerce.Entities
{
    public class TodoItem:BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
