﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleBot.Domain.Abstractions
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
