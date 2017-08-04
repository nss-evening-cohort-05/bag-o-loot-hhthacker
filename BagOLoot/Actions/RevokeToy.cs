using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class RevokeToy
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      var kid = KidsList.Show(book);
      
      
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
