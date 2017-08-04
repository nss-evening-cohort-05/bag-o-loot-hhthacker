using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AddToy
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      var kid = KidsList.Show(book);
      
      Console.WriteLine ("Enter toy");
      Console.Write ("> ");
      string toyName = Console.ReadLine();
      bag.Add(toyName, kid);
    }
  }
}
