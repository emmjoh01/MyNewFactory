using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewFactory
{
    class Recipes
    {
        public List<Recipes> allRecipes = new();

        private string ProductName { get; }

        private int RequierdAmountOfFabric { get; }
        private int RequierdAmountOfRedPaint { get; }
        private int RequierdAmountOfRubber { get; }
        private int RequierdAmountOfScrews { get; }
        private int RequierdAmountOfSteel { get; }
        private int RequierdAmountOfWood { get; }

        public Recipes()
        {

        }
        public Recipes(string productName, int requierdFabric, int requierdRedPaint, int requierdRubber, int requierdScrews, int requierdSteel, int requierdWood)
        {
            ProductName = productName;
            RequierdAmountOfFabric = requierdFabric;
            RequierdAmountOfRedPaint = requierdRedPaint;
            RequierdAmountOfRubber = requierdRubber;
            RequierdAmountOfScrews = requierdScrews;
            RequierdAmountOfSteel = requierdSteel;
            RequierdAmountOfWood = requierdWood;
        }

        public void RecipeCreater()
        {
            Recipes bike = new Recipes("Bike", 0, 2, 2, 3, 2, 0);
            allRecipes.Add(bike);
            Recipes redPhotoFrame = new Recipes("Red Photo-frame", 0, 1, 0, 1, 0, 2);
            allRecipes.Add(redPhotoFrame);
            Recipes ticTacToeWoodGame = new Recipes("Tic, tac, toe wooden game", 0, 1, 0, 0, 0, 2);
            allRecipes.Add(ticTacToeWoodGame);
            Recipes thermosForDrinks = new Recipes("Thermos for drinks", 0, 1, 1, 0, 1, 0);
            allRecipes.Add(thermosForDrinks);
            Recipes couch = new Recipes("Couch", 3, 0, 0, 2, 1, 4);
            allRecipes.Add(couch);
            Recipes redShirt = new Recipes("Red shirt", 2, 1, 0, 0, 0, 0);
            allRecipes.Add(redShirt);
        }
    }
}
