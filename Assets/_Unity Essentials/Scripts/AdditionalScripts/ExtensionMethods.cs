using UnityEngine;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{
    public static class ExtensionMethods
    {
        public static void ResetTransformation(this Transform trans)
        {
            trans.position = Vector3.zero;
            trans.localRotation = Quaternion.identity;
            trans.localScale = new Vector3(1, 1, 1);
        }
    }

    public class ExtensionMethodsSomeClass : MonoBehaviour 
    {
        private void Start () 
        {
            transform.ResetTransformation();
        }
    }
}