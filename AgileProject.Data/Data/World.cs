using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class World
    {
        public World(List<GTLevel> levels)
        {
            Levels = levels;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool HasTravelledTo { get; set; }
        public List<GTLevel> Levels { get; set; }

    }