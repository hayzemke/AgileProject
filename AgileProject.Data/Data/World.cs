using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class World
    {
        public World(List<Level> levels)
        {
            Levels = levels;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool HasTravelledTo { get; set; }
        public List<Level> Levels { get; set; }

    }