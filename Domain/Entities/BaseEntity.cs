using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    /*Classe abstrata não pode ser instanciada, serve para ser herdada por outras classes*/
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset DataCreated { get; set; }
        public DateTimeOffset DataUpdated { get; set;}
        public DateTimeOffset DataDeleted { get; set;}
    }
}
