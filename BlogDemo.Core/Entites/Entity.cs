﻿using BlogDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDemo.Core.Entites
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
