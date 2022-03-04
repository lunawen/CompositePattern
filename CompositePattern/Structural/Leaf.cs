using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Structural
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.Name);
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
