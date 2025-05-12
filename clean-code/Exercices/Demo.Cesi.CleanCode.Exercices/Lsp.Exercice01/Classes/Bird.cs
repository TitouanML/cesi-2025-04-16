﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Exercice01.Classes
{
    public class Bird
    {
        public virtual void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }

    public class FlyingBird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

}
