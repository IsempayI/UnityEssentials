using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
	[Header("Day Duration Settings")]
	[Tooltip("How many real seconds it takes for a full 24-hour day to pass.")]
	public float dayDurationInSeconds = 60f;

	private void Update()
	{
		if (dayDurationInSeconds <= 0) return;
		
		var degreesPerSecond = 360f / dayDurationInSeconds;
		
		transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
	}
}