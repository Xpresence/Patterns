﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    class Memento
    {
        public HeroStats Stats { get; private set; }

        public Memento (HeroStats stats)
        {
            this.Stats = Prototype.Prototype.DeepClone(stats);
        }
    }

    class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
