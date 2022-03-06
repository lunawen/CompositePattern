using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositePattern
{
    public static class Extensions
    {
        public static IEnumerable<XElement> FindElements(this XElement root, Predicate<XElement> predicate)
        {
            var stack = new Stack<XElement>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                foreach (var item in current.Elements())
                {
                    stack.Push(item);
                }
                if (predicate(current))
                {
                    yield return current;
                }
            }
        }
    }
}
