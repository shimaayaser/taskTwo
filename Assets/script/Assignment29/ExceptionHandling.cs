using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment29{
public class ExceptionHandling : MonoBehaviour
{
    
    void Start()
    {
       int playerScore = 100;
       int diviser = 0;

       try{
            Debug.Log("Attempting to calculate score multiplier..."); 
            int  totalscore = playerScore / diviser;
                      
       }
        catch(DivideByZeroException  e){
            Debug.LogError("Error: Division by zero occurredwhile calculating score multiplier.");
           // Debug.LogError(e.Message);
        }
        finally{
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }
}
}