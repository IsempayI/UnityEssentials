using UnityEngine;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{ 
	public class Humanoid
	{
		public void Yell()
		{
			Debug.Log("Humanoid version of the Yell() method");
		}
	}

	public class HidingMembersEnemy : Humanoid
	{
		new public void Yell()
		{
			Debug.Log("Enemy version of the Yell() method");
		}
	}

	public class Orc : HidingMembersEnemy
	{
		new public void Yell()
		{
			Debug.Log("Orc version of the Yell() method");
		}
	}

	public class WarBand : MonoBehaviour
	{
		private void Start()
		{
			Humanoid human = new Humanoid();
			Humanoid enemy = new HidingMembersEnemy();
			Humanoid orc = new Orc();
			
			human.Yell();
			enemy.Yell();
			orc.Yell();
		}
	}
}