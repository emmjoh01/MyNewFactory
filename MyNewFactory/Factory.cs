using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewFactory
{
    class Factory
    {
        List<Material> _materialsInFactory= new();
        public List<Material> fabricInFactory = new(); //A list for every material to split the incomming list with every material into its own list
        public List<Material> redPaintInFactory = new();
        public List<Material> rubberInFactory = new();
        public List<Material> screwsInFactory = new();
        public List<Material> steelInFactory = new();
        public List<Material> woodInFactory = new();
        public List<string> productsMade = new List<string>();
        private bool isPossibleToProduceMore;

        public void ReceivingMaterials(List<Material> materialsToFactory)
        {
            _materialsInFactory = materialsToFactory;
            SplittingMaterials();
        }

        //Finding all materials of each and puts it in the right materiallist
        public void SplittingMaterials()
        {
            fabricInFactory.AddRange(_materialsInFactory.FindAll(x => x.Equals(Material.Fabric)));
            redPaintInFactory.AddRange(_materialsInFactory.FindAll(x => x.Equals(Material.RedPaint)));
            rubberInFactory.AddRange(_materialsInFactory.FindAll(x => x.Equals(Material.Rubber)));
            screwsInFactory.AddRange(_materialsInFactory.FindAll(x => x.Equals(Material.Screws)));
            steelInFactory.AddRange(_materialsInFactory.FindAll(x => x.Equals(Material.Steel)));
            woodInFactory.AddRange(_materialsInFactory.FindAll(x => x.Equals(Material.Wood)));
        }

        //Checking how much each recipe requier from each material and try if each list om each material contains the same amount or more.
        public bool MatchingRecipesWithMaterial(bool usersentMaterial)
        {
            isPossibleToProduceMore = false;
            if (fabricInFactory.Count >= 3 && screwsInFactory.Count>=2 && steelInFactory.Count>=1 && woodInFactory.Count >= 4)
            {
                if (usersentMaterial)
                {
                productsMade.Add("Couch");
                fabricInFactory.RemoveRange(0,3);
                screwsInFactory.RemoveRange(0, 2);
                steelInFactory.RemoveAt(0);
                woodInFactory.RemoveRange(0, 4);
                }

                isPossibleToProduceMore = true;
            }
            if(redPaintInFactory.Count >= 1 && woodInFactory.Count>=2)
            {
                if (usersentMaterial)
                {
                productsMade.Add("Tic, tac, toe wooden game");
                redPaintInFactory.RemoveAt(0);
                woodInFactory.RemoveRange(0, 2);
                }

                isPossibleToProduceMore = true;
            }
            if(redPaintInFactory.Count>=2 &&  rubberInFactory.Count>=2&&screwsInFactory.Count>=3&&steelInFactory.Count>=2)
            {
                if (usersentMaterial)
                {
                productsMade.Add("Bike");
                redPaintInFactory.RemoveRange(0, 2);
                rubberInFactory.RemoveRange(0, 2);
                screwsInFactory.RemoveRange(0, 3);
                steelInFactory.RemoveRange(0, 2);
                }

                isPossibleToProduceMore = true;
            }
            if (fabricInFactory.Count>=2 && redPaintInFactory.Count>=1)
            {
                if (usersentMaterial)
                {
                productsMade.Add("Red shirt");
                fabricInFactory.RemoveRange(0, 2);
                redPaintInFactory.RemoveAt(0);
                }

                isPossibleToProduceMore = true;
            }
            return isPossibleToProduceMore;
        }
        public void MaterialsHaveBeenSentAway()
        {
            fabricInFactory.Clear();
            redPaintInFactory.Clear();
            rubberInFactory.Clear();
            screwsInFactory.Clear();
            steelInFactory.Clear();
            woodInFactory.Clear();
        }
    }
}
