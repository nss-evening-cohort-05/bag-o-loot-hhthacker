using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class RevokeToy
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Remove Toy From Which Child");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childIndex = Console.ReadLine();
      Child kid = children[int.Parse(childIndex)-1];
      
      Console.WriteLine ("Pick toy to remove");
      
      
      var toyList = bag.GetToysForChild(kid).ToArray();
      foreach (Toy t in toyList)
      {
          Console.WriteLine($"{Array.IndexOf(toyList,t)+1}. {t.name}");
      }
      
      Console.Write ("> ");
      string toyIndex = Console.ReadLine();
      Toy toy = toyList[int.Parse(toyIndex)-1];

      bag.RevokeToy(toy);
    }
  }
}
