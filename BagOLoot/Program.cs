using System;
using System.Collections.Generic;
using System.Linq;
using BagOLoot.Actions;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            ChildRegister book = new ChildRegister();
            ToyRegister bag = new ToyRegister();
            Child name = new Child();
            Toy toy = new Toy();

            // Choice will hold the number entered by the user
            // after main menu ws displayed
            int choice;

            do
            {
                // Show the main menu
                choice = menu.Show();

                switch (choice)
                {
                    // Menu option 1: Add a child
                    case 1:
                        CreateChild.DoAction(book);
                        break;

                    // Menu option 2: Assign toy to a child
                    case 2:
                        AddToy.DoAction(bag, book);
                        break;

                    //Menu option 3: Revoke toy from child
                    case 3:
                        RevokeToy.DoAction(bag, book);
                        break;
                    
                    //Menu option 4: Review child's toy list
                    case 4:
                        ToyList.DoAction(bag, book);
                        break;

                    // //Menu option 5: Child toy delivery complete
                    // case 5:
                    //     ChildRegister.GetChildren(child);
                    //     break;

                    // //Menu option 6: Yuletime delivery report
                    // case 6: 
                    //     ToyRegister.GetToysForChild(kid);
                    //     break;

                }
            } while (choice <= 6);
        }
    }
}
