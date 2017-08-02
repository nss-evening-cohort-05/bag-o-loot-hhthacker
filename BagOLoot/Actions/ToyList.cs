using System;
using System.Collections.Generic;

namespace BagOLoot.Actions
{
    public class ToyList
    {
        public static Child Show(ChildRegister book)
        {
            Console.Clear();
            Console.WriteLine("View toy list from which child?");

            var children = book.GetChildren().ToArray();
                foreach (Child child in children)
                {
                    Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
                }

            Console.Write ("> ");
            string childName = Console.ReadLine();
            Child kid = children[int.Parse(childIndex)-1];

            var toyList = bag.GetToysForChild(kid).ToArray();
                foreach (Toy t in toyList)
                {
                    Console.WriteLine($"{Array.IndexOf(toyList,t)+1}. {t.name}");
                }
        }

    }

}