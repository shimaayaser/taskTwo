using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class TestUtilitiesScript : MonoBehaviour
{
 
    void Start()
    {
        int Sum= Utilities.Add(1,2,3,4,5,6);
        Debug.Log($"The sum of the numbers is: {Sum}");
        string repeatString =Utilities.RepeatString("Hello",3);
        Debug.Log($"Repeated string: {repeatString}");
    }
}
}