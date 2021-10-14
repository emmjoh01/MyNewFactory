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



        public Storage() //Filling storage with materials, random amount between 0 to 15 of each
        {
            for (int i = 0; i < 6; i++)
            {
                materialsInStorage.Add((Material)i);
                materialAmountInStorage[i] = new Random().Next(0, 16);
                //Console.WriteLine($"{i+1}. {materialsInStorage[i], -15} Amount: {materialAmountInStorage[i]}");
            }
        }

        public void ShowStorage()
        {
            Console.WriteLine("-----Materials in storage-----");
            for (int i = 0; i < materialsInStorage.Count; i++)
            {
                Console.WriteLine($"{i+1}. {materialsInStorage[i], -15} Amount: {materialAmountInStorage[i]}");
            }
        }

    }
}
