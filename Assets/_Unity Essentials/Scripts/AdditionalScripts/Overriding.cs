using UnityEngine;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{
	public class OverridingFruit
	{
		public OverridingFruit()
		{
			Debug.Log("1st Fruit Constructor Called");
		}

		public virtual void Chop()
		{
			Debug.Log("The fruit has been chopped.");
		}

		public virtual void SayHello()
		{
			Debug.Log("Hello, I am a fruit.");
		}
	}

	public class OverridingApple : OverridingFruit
	{
		public OverridingApple()
		{
			Debug.Log("1st Apple Constructor Called");
		}

		public override void Chop()
		{
			base.Chop();
			Debug.Log("The apple has been chopped.");
		}

		public override void SayHello()
		{
			base.SayHello();
			Debug.Log("Hello, I am an apple.");
		}
	}

	public class OverridingFruitSalad : MonoBehaviour
	{
		private void Start()
		{
			OverridingApple myApple = new OverridingApple();
			myApple.SayHello();
			myApple.Chop();

			OverridingFruit myFruit = new OverridingApple();
			myFruit.SayHello();
			myFruit.Chop();
		}
	}
}