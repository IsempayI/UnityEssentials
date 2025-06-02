using UnityEngine;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{
    public class GenericsSomeClass 
    {
        public T GenericMethod<T>(T param)
        {
            return param;
        }
    }

    public class GenericsSomeOtherClass : MonoBehaviour 
    {
        private void Start () 
        {
            GenericsSomeClass myClass = new GenericsSomeClass();
            myClass.GenericMethod<int>(5);
        }
    }

    public class GenericsGenericClass <T>
    {
        T item;

        public void UpdateItem(T newItem)
        {
            item = newItem;
        }
    }

    public class GenericsGenericClassExample : MonoBehaviour 
    {
        private void Start () 
        {        
            GenericsGenericClass<int> myClass = new GenericsGenericClass<int>();
            myClass.UpdateItem(5);
        }
    }
}