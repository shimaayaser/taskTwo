using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class TypeManagementScript : MonoBehaviour
{
    void Start()
    {
        Cat cat=new Cat();
        Animal animal1=new Animal();
        Animal animal= cat; //Upcasting, Implicit
        animal.MakeSound();
        animal1.Move();
        Cat cat1= animal as Cat;// Downcasting, Explicit
        cat1.MakeSound();  
        cat1.Move(); 
        ICanFight cat2 = new Cat();
        ICanFight warrior= new Warrior();

        List<ICanFight> CanFight = new List<ICanFight> { cat2, warrior };

        foreach(var CanFights in CanFight ){
            if(CanFights is Cat){
                CanFights.Attack();
                Debug.Log("The object is a Cat.");   
            }
            else if (CanFights is Warrior){
                
                CanFights.Attack();
                Debug.Log("The object is a Warrior.");   
            }
         }
       
       





    }

    
}


public class Animal{
    public virtual void MakeSound() {
        Debug.Log("Animal sound");
    }
    public virtual void Move(){
        Debug.Log("Animal moves");
    }
}

public class Cat: Animal ,ICanFight{
    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }
    public override void Move(){
        Debug.Log("Cat runs quickly.");
    }
    public void Attack()
    {
        Debug.Log("Cat attacks with claws!");
    }
}

public interface ICanFight
{
    void Attack();
}
public class Warrior:ICanFight{
    public void Attack(){
        Debug.Log("Warrior attacks with a sword!");
    }
}

}