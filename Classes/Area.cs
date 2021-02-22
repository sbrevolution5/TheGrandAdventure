using System.Collections.Generic;
namespace TheGrandAdventure.Classes
{
    public class Area
    {
        //fields
        private string Name;
        private string initialDescription = "This room has no initial description yet, silly developer";
        private string description = "This room has no description yet, silly developer";
        private List<Area> exits= new List<Area>(); 
        private List<Creature> denizens = new List<Creature>();
        private List<Item> items = new List<Item>();
        //methods

    }
}