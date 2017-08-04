using System;

namespace BagOLoot.Actions
{
    public class ToyList
    {
        public static void DoAction(SantasNiceList book, SantasToyBag bag)
        {
            var kidChoice = KidsList.Show(book);

            var toyList = bag.GetToysForChild(kidChoice).ToArray();
            foreach (Toy t in toyList)
            {
                Console.WriteLine($"{Array.IndexOf(toyList,t)+1}. {t.name}");
            }

            Console.ReadLine();
        }

    }

}