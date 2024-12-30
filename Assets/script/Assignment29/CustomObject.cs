using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class CustomObject 
{
    public int ID{get;set;}
    public string Name {get;set;}

    public CustomObject (int ID,string Name ){
        
        this.Name=Name;
        this.ID=ID;

     }
    
    public override string ToString(){
        return $"Object [ID: {ID}, Name: {Name}]";
     }

    //  public override bool Equals(object obj){
            
    //         CustomObject a = obj as CustomObject; 
    //             if (a == null)
    //             {
    //                 return false;
    //             }

    //             if (this.Name == a.Name && this.ID== a.ID)
    //             {
    //                 return true;
    //             }
    //             return false;
    //  }
            public static bool operator ==(CustomObject c1, CustomObject c2)
            {
                if (!c1.Equals(null) && !c2.Equals(null))
                {
                    if (c1.Name.Equals(c2.Name)&& c1.ID.Equals(c2.ID)) return true;
                }
                return false;
            }

            public static bool operator !=(CustomObject custom1, CustomObject custom2)
            {
                if (!custom1.Equals(null) && !custom2.Equals(null))
                {
                    if (!custom1.Name.Equals(custom2.Name)&& custom1.ID.Equals(custom1.ID)) return true;
                }
                return false;
            }
}
}