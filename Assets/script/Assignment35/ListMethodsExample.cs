using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_35{
public class ListMethodsExample : MonoBehaviour
{
    

    void Start()
    {
        List<int>numbers= new List<int>{3, 1, 4, 1, 5, 9};

        numbers.Sort((x, y) => y.CompareTo(x));
        print(string.Join(", ",numbers));
        
    }

    

}
}