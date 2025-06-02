using UnityEngine;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{

    public class Player
    {
        private int experience;
        
        public int Experience
        {
            get
            {
                //Some other code
                return experience;
            }
            set
            {
                //Some other code
                experience = value;
            }
        }
        
        public int Level
        {
            get
            {
                return experience / 1000;
            }
            set
            {
                experience = value * 1000;
            }
        }
        
        public int Health{ get; set;}
    }
    
    public class Game : MonoBehaviour 
    {
        void Start () 
        {
            Player myPlayer = new Player();
            
            myPlayer.Experience = 5;
            int x = myPlayer.Experience;
        }
    }
}