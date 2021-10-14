using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewFactory
{
    class Factory
    {
        List<Material> materialsInFabric = new();
        public List<Material> fabricInFactory = new();
        public List<Material> redPaintInFactory = new();
        public List<Material> rubberInFactory = new();
        public List<Material> screwsInFactory = new();
        public List<Material> steelInFactory = new();
        public List<Material> woodInFactory = new();
        public List<string> productsMade = new List<string>();

        public void ReceivingMaterials(List<Material> materialsToFactory)
        {
            materialsInFabric = materialsToFactory;
            SplittingMaterials(materialsInFabric);
        }

        public void SplittingMaterials(List<Material> materialsToFactory)
        {
            fabricInFactory.AddRange(materialsToFactory.FindAll(x => x.Equals(Material.Fabric)));
            redPaintInFactory.AddRange(materialsToFactory.FindAll(x => x.Equals(Material.RedPaint)));
            rubberInFactory.AddRange(materialsToFactory.FindAll(x => x.Equals(Material.Rubber)));
            screwsInFactory.AddRange(materialsToFactory.FindAll(x => x.Equals(Material.Screws)));
            steelInFactory.AddRange(materialsToFactory.FindAll(x => x.Equals(Material.Steel)));
            woodInFactory.AddRange(materialsToFactory.FindAll(x => x.Equals(Material.Wood)));
        }

        public void MatchingRecipesWithMaterial()
        {
            if (fabricInFactory.Count >= 3 && screwsInFactory.Count>=2 && steelInFactory.Count>=1 && woodInFactory.Count >= 4)
            {
                productsMade.Add("Couch");
                fabricInFactory.RemoveRange(0,2);
                screwsInFactory.RemoveRange(0, 1);
                steelInFactory.RemoveAt(0);
                woodInFactory.RemoveRange(0, 3);
            }
            if(redPaintInFactory.Count >= 1 && woodInFactory.Count>=2)
            {
                productsMade.Add("Tic, tac, toe wooden game");
            }
            if(redPaintInFactory.Count>=2 &&  rubberInFactory.Count>=2&&screwsInFactory.Count>=3&&steelInFactory.Count>=2)
            {
                productsMade.Add("Bike");
                redPaintInFactory.RemoveRange(0, 1);
                rubberInFactory.RemoveRange(0, 1);
                screwsInFactory.RemoveRange(0, 2);
                steelInFactory.RemoveRange(0, 1);
            }
            if (fabricInFactory.Count>=2 && redPaintInFactory.Count>=1)
            {
                productsMade.Add("Red shirt");
                fabricInFactory.RemoveRange(0, 1);
                redPaintInFactory.RemoveAt(0);
            }
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




//ProvidedRubber.AddRange(MaterialsForProduction.FindAll(x => x.Equals(Material.rubber)));
//ProvidedSteel.AddRange(MaterialsForProduction.FindAll(x => x.Equals(Material.steel)));