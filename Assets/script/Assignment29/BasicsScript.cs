using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment29{

public class BasicsScript : MonoBehaviour
{
    
    void Start()
    {
        var num=5;
        var sentencies ="The number " ;
        var boolnum =true;

        string text= num%2==0? "even number":"odd number";
        string massage=$"{sentencies}{num} is : {text}";
        Debug.Log(massage);

        Debug.Log($"The current date is :{DateTime.Now}");
        Debug.Log($"The current time is :{DateTime.Now.ToShortTimeString().ToString()}");
         Debug.Log($"The current day is :{DateTime.Now.DayOfWeek}");



    }

   
    void Update()
    {
        
    }
}
}