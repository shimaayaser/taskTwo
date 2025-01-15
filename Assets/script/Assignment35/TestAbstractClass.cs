using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_35{

public class TestAbstractClass : MonoBehaviour
{
    
    AbstractBaseClass printcode;

    
    void Start()
    {
        
        printcode = new DerivedClassExample();

        printcode.PerformAction();
        printcode.PrintInfo();
    }
}
public abstract  class AbstractBaseClass 
{
 
    public abstract void PerformAction();

    public  void PrintInfo(){
        Debug.Log($"This is a concrete method in the abstract base class.");
    }


}


public class DerivedClassExample: AbstractBaseClass{
      
       public override void PerformAction(){
        Debug.Log($"PerformAction is implemented in the derived class.");
       }
}
}