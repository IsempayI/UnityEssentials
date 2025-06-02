using UnityEngine;

public class DoorOpener : MonoBehaviour
{
   private Animator doorAnimator;
   
   private void Start()
   {
       doorAnimator = GetComponent<Animator>();
   }
   
   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player") && doorAnimator != null) doorAnimator.SetTrigger("Door_Open");
   }
}