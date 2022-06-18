using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class GTLevel
    {
        public LevelServices(List<Character> characters)
        {
                Character = characters;
        }

        public int ID { get; set; }
        public List<Character> characters { get; set; }= new List<Character>();
        public bool isComplete {get; private set; }

        public bool LevelUp()
        {
            if (characters.Count <= 0)
            {
                isComplete = true;
                return isComplete;
            }
            else
            {
                isComplete = false;
                return isComplete;
            }
        }
    }