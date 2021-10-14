using System;

namespace MyNewFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage myMagicalStorage = new();
            Factory myMagicalFactory = new();
            
            //Welcome-message
            //While 
            while(true)
            {
                //Show materials in storage++
                //User picks materials++
            myMagicalStorage.UserPicksMaterial();
            //Shows earlier picked material ++

            //Material sent to factory
            myMagicalStorage.SendingMaterialsToFactory();
            myMagicalFactory.ReceivingMaterials(myMagicalStorage.materialsToSendToFactory);
            //Chosen materialn matches with products
            myMagicalFactory.MatchingRecipesWithMaterial();
            //Returning pruducts and material-leftovers
            myMagicalStorage.ReceivingMaterialLeftOvers(myMagicalFactory.fabricInFactory, myMagicalFactory.redPaintInFactory, myMagicalFactory.rubberInFactory, myMagicalFactory.screwsInFactory, myMagicalFactory.steelInFactory, myMagicalFactory.woodInFactory);
            myMagicalFactory.MaterialsHaveBeenSentAway();
                myMagicalStorage.GettingProducts(myMagicalFactory.productsMade);
                //Check if anything is possible to make with what's left in storage
                //Message material out of stock or nothing more to make. Game's ended
                Console.Clear();
                myMagicalStorage.ShowProductsMade();

                //------------Make a Method to check if anything more can be produced with what material that´s left-------------

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
