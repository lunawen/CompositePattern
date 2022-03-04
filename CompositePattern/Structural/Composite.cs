﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Structural
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.Name);
            foreach (var component in children)
            {
                component.PrimaryOperation(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
