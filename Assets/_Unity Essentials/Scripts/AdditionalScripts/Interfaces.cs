using UnityEngine;
using System.Collections.Generic;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{ 
	public interface IDamageable
	{
		Vector3 Position { get; }
		void Damage(float damage);
	}

	public class PlayerHealth : MonoBehaviour, IDamageable
	{
		public float startingHealth = 100f;
		private float m_CurrentHealth;

		public Vector3 Position
		{
			get { return transform.position; }
		}

		private void Start()
		{
			m_CurrentHealth = startingHealth;
		}

		public void Damage(float damage)
		{
			m_CurrentHealth -= damage;
		}
	}

	public class Explosion : MonoBehaviour
	{
		public float range = 10f;
		public float damage = 35f;
		private List<IDamageable> m_AllDamageables = new List<IDamageable>();

		private void Start()
		{
			MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
			for (int i = 0; i < allScripts.Length; i++)
			{
				if (allScripts[i] is IDamageable)
					m_AllDamageables.Add(allScripts[i] as IDamageable);
			}
		}

		public void Explode()
		{
			for (int i = 0; i < m_AllDamageables.Count; i++)
			{
				if (Vector3.Distance(m_AllDamageables[i].Position, transform.position) < range)
					m_AllDamageables[i].Damage(damage);
			}
		}
	}

	public class ProtonShield : IDamageable
	{
		public float hitPoints = 10f;

		public Vector3 Position { get; }

		public void Damage(float damage)
		{
			hitPoints -= damage;
		}
	}

	public class ShieldedPlayer : MonoBehaviour
	{
		[SerializeReference]
		public IDamageable shield = new ProtonShield();
	}
}