using System;

namespace MyNewFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage myMagicalStorage = new();
            Factory myMagicalFactory = new();
            bool isPossibleToProduceMore = true;
            Console.WriteLine("Welcome to the magic Factory Game! Lets start by going to the storage and pick som material to use!");
            //While 
            while (isPossibleToProduceMore)
            {
                //Shows material and products in storage, Shows earlier picked material and lets user pick materials
                myMagicalStorage.UserPicksMaterial();

                //Material sent to factory
                myMagicalFactory.ReceivingMaterials(myMagicalStorage.materialsToSendToFactory);

                //MatchMaking materials and products, true is sent in true because it is the user who sent in these materials
                myMagicalFactory.MatchingRecipesWithMaterial(true);

                Console.Clear();
                Console.Title = "The Magic Factory";
                //Making loadingscreen a bit less boring
                char[] loading = "Looking for matching blueprint".ToCharArray();
                for (int i = 0; i < loading.Length; i++)
                {
                    Console.Write(loading[i]);
                    System.Threading.Thread.Sleep(75);
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(100);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(100);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.Write("Looking for matching blueprint");
                }
                Console.Clear();

                //Returning material-leftovers from factory
                myMagicalStorage.ReceivingMaterialLeftOvers(myMagicalFactory.fabricInFactory, myMagicalFactory.redPaintInFactory, myMagicalFactory.rubberInFactory, myMagicalFactory.screwsInFactory, myMagicalFactory.steelInFactory, myMagicalFactory.woodInFactory);

                //Emptying material in factory because it has been sent back to storage
                myMagicalFactory.MaterialsHaveBeenSentAway();

                //Reciving produced products
                myMagicalStorage.GettingProducts(myMagicalFactory.productsMade);

                //Summon all material in storage and sends to factory
                myMagicalStorage.TryToProduceWithWhatsLeft();
                myMagicalFactory.ReceivingMaterials(myMagicalStorage.allMaterialsInStorage);

                //Checks if the materials in storage is enough to produce anything, sending in false because we just want to check
                //if it's possible, not to acctuallu produce anything.
                isPossibleToProduceMore = myMagicalFactory.MatchingRecipesWithMaterial(false);

                //Emptying material in storage
                myMagicalFactory.MaterialsHaveBeenSentAway();
            }
            Console.Clear();
            myMagicalStorage.ShowProductsMade();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nothing more is possible to produce.");
            Console.ResetColor();
        }
    }
}
