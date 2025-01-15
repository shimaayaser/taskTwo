using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment_35{
public class ListMethodsExample : MonoBehaviour
{
    

    void Start()
    {
        List<int>numbers= new List<int>{3, 1, 4, 1, 5, 9};
        List<int>numbers2= new List<int>{3, 1, 4, 1, 5, 9, 2, 6};
        List<int>filteredNumbers = numbers2.FindAll(number => number % 2 == 0);
        numbers.Sort((x, y) => y.CompareTo(x));
        print(string.Join(", ",numbers));
        print(string.Join(", ",filteredNumbers));
        
    }

    

}
}