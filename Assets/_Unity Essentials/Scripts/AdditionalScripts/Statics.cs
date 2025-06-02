using UnityEngine;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{
	public class Enemy
    {
        public static int enemyCount = 0;

        public Enemy() => enemyCount++;
    }
	
	public class StaticsGame
    {
        private void Start () 
        {
            Enemy enemy1 = new Enemy();
            Enemy enemy2 = new Enemy();
            Enemy enemy3 = new Enemy();
            int x = Enemy.enemyCount;
        }
    }
    
    public class StaticsPlayer : MonoBehaviour 
    {
        public static int playerCount = 0;

        private void Start()
        {
            playerCount++;
        }
    }
    
    public class PlayerManager : MonoBehaviour 
    {
        private void Start()
        {
            int x = StaticsPlayer.playerCount;
        }
    }
    
    public static class Utilities 
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    
    public class UtilitiesExample : MonoBehaviour 
    {
        private void Start()
        {
            int x = Utilities.Add (5, 6);
        }
    }
}