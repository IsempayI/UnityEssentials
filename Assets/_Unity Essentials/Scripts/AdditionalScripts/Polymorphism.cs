using System;
using UnityEngine;

namespace _Unity_Essentials.Scripts.AdditionalScripts
{
    public class Animal { }
   
    [Serializable]
    public class Mammal : Animal
    {
        public void GrowFur () { }
    }
   
   public class Cat : Mammal
   {
      public void Meow () { }
   }
   public class Dog : Mammal
   {
      public void Woof () { }
   }
   
   public class RescueShelter
   {
      public Mammal[] mammals;
      
      public RescueShelter ()
      {
         mammals = new Mammal[2];
         mammals[0] = new Cat();
         mammals[1] = new Dog();
         // Compile error.
         //mammals[0].Meow();
         if(mammals[0] is Cat)
         {
             Cat cat = mammals[0] as Cat;
             cat.Meow();
         }
         if(mammals[1] is Dog)
         {
             Dog dog = (Dog)mammals[1];
             dog.Woof();
         }
      }
   }
   
   public class PetShop : MonoBehaviour
   {
      [SerializeReference]
      public Mammal mammal = new Cat();
   }
}