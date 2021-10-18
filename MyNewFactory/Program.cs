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
            Console.WriteLine("Welcome to the magic Factory Game! Lets start by going to the storage and pick som material ti use!");
            //While 
            while (isPossibleToProduceMore)
            {
                //Shows material and products in storage, Shows earlier picked material and lets user pick materials
                myMagicalStorage.UserPicksMaterial();

                //Material sent to factory
                myMagicalFactory.ReceivingMaterials(myMagicalStorage.materialsToSendToFactory);

                //MatchMaking materials and products
                myMagicalFactory.MatchingRecipesWithMaterial(true);

                //Returning pruducts and material-leftovers
                myMagicalStorage.ReceivingMaterialLeftOvers(myMagicalFactory.fabricInFactory, myMagicalFactory.redPaintInFactory, myMagicalFactory.rubberInFactory, myMagicalFactory.screwsInFactory, myMagicalFactory.steelInFactory, myMagicalFactory.woodInFactory);
                myMagicalFactory.MaterialsHaveBeenSentAway();
                myMagicalStorage.GettingProducts(myMagicalFactory.productsMade);
                //Check if anything is possible to make with what's left in storage
                //Message material out of stock or nothing more to make. Game's ended
                //Console.Clear();
                //myMagicalStorage.ShowProductsMade();

                ////------------Make a Method to check if anything more can be produced with what material that´s left-------------

                //Console.WriteLine("Press any key to continue.");
                //Console.ReadKey();
                myMagicalStorage.TryToProduceWithWhatsLeft();
                myMagicalFactory.ReceivingMaterials(myMagicalStorage.allMaterialsInStorage);
                isPossibleToProduceMore = myMagicalFactory.MatchingRecipesWithMaterial(false);
                myMagicalFactory.MaterialsHaveBeenSentAway();
            }
            Console.Clear();
            myMagicalStorage.ShowProductsMade();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nothing more is possible to produce.");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
