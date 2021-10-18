using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewFactory
{
    class Storage
    {
        private List<Material> materialsInStorage = new();
        int[] materialAmountInStorage = new int[6];
        public List<Material> materialsToSendToFactory = new();
        List<string> productsDone = new();
        bool isPossibleToProduceMore;
        List<string> PossibleToProduce = new();
        public List<Material> allMaterialsInStorage = new();

        public Storage() //Filling storage with materials, random amount between 0 to 15 of each
        {
            for (int i = 0; i < 6; i++)
            {
                materialsInStorage.Add((Material)i);
                materialAmountInStorage[i] = new Random().Next(5, 16);
            }
        }

        public void ShowStorage()
        {
            Console.WriteLine("-----Materials in storage-----");
            for (int i = 0; i < materialsInStorage.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {materialsInStorage[i],-15} Amount: {materialAmountInStorage[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("-----Products you've made-----");
            for (int i = 0; i < productsDone.Count; i++)
            {
                Console.WriteLine(productsDone[i]);
            }
        }

        public void ShowMaterialsToSend()
        {
            Console.WriteLine("-----Materials to send-----");
            for (int i = 0; i < materialsToSendToFactory.Count; i++)
            {
                Console.WriteLine(materialsToSendToFactory[i]);
            }
        }

        public void UserPicksMaterial()
        {
            Console.Title = "The Magical Storage";
            materialsToSendToFactory.Clear();
            while (true)
            {
                Console.Clear();
                ShowStorage();
                Console.WriteLine();
                ShowMaterialsToSend();
                Console.WriteLine("Enter the number for which material you want to send to the factory (press a to send all): ");
                var inputKey = Console.ReadKey(true).KeyChar;
                if (inputKey == 'a')
                {
                    materialsToSendToFactory = (TryToProduceWithWhatsLeft());
                    for (int i = 0; i < materialAmountInStorage.Length; i++)
                    {
                        materialAmountInStorage[i] = 0;
                    }
                    break;
                }
                if (char.IsDigit(inputKey)) 
                {
                    int userInput = int.Parse(inputKey.ToString());
                    userInput--;
                    if (userInput < 6) //only choices 1-6 (indexes 0-5)
                    {

                        if (materialAmountInStorage[userInput] > 0)
                        {
                            materialsToSendToFactory.Add((Material)userInput);
                            materialAmountInStorage[userInput]--;

                        }
                        
                    }

                    else
                    {
                        break;
                    }
                    
                }
                else
                {
                    break;
                }

            }
        }

        public void SendingMaterialsToFactory()
        {
            Console.Clear();
            string transportingMaterial = "Material is being transported...";
            char[] transportingMaterialLetters = transportingMaterial.ToCharArray();
            for (int i = 0; i < transportingMaterialLetters.Length; i++)
            {
                Console.Write(transportingMaterialLetters[i]);
                System.Threading.Thread.Sleep(30);
            }
            Console.Clear();
                Console.WriteLine("Material has been delivered!");
                System.Threading.Thread.Sleep(2000);
        }

        //To get the right amount of materials back in storage to use.
        public void ReceivingMaterialLeftOvers(List<Material> fabricleft, List<Material> redPaint, List<Material> rubber, List<Material> screws, List<Material> steel, List<Material> wood)
        {
            materialAmountInStorage[0] += fabricleft.Count;
            materialAmountInStorage[1] += redPaint.Count;
            materialAmountInStorage[2] += rubber.Count;
            materialAmountInStorage[3] += screws.Count;
            materialAmountInStorage[4] += steel.Count;
            materialAmountInStorage[5] += wood.Count;
        }

        public void GettingProducts(List<string> productsMade )
        {
            productsDone = productsMade;
        }

        public void ShowProductsMade()
        {
            Console.WriteLine("Products that you've produced:");
            for (int i = 0; i < productsDone.Count; i++)
            {
                Console.WriteLine(productsDone[i]);
            }
        }

        public List<Material> TryToProduceWithWhatsLeft()
        {
            allMaterialsInStorage.Clear();
            for (int i = 0; i < materialsInStorage.Count; i++)
            {
                for (int y = 0; y < materialAmountInStorage[i]; y++)
                {
                    if (y <= materialAmountInStorage[i])
                    {
                        allMaterialsInStorage.Add(materialsInStorage[i]);
                    }
                }
            }
            return allMaterialsInStorage;
        }

    }
}
