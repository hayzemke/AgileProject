using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class GTLevel
    {
        public GTLevel(List<Character> characters)
        {
                Characters = characters;
        }

        public int ID { get; set; }
        public List<Character> Characters { get; set; }= new List<Character>();
        public bool isComplete {get; private set; }

        public bool LevelUp()
        {
            if (Characters.Count <= 0)
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