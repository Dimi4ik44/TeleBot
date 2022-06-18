using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleBot.Domain.Abstractions;

namespace TeleBot.Domain.Models
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
