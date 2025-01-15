using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_35
{
public class BoxingUnboxing : MonoBehaviour
{
    void Start()
    {
        int health = 100;
        object boxing_health= health; //boxing
        int unboxing_health =(int)boxing_health;
        unboxing_health+=80;

        Debug.Log($"the orginal health:{health}");
        Debug.Log($"the boxing health:{boxing_health}");
        Debug.Log($"the unboxing health:{unboxing_health}");
    }

    
}

}