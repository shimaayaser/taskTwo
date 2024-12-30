using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29{
public class RecursionScript : MonoBehaviour
{
    
    void Start()
    {
        print($"FibonacciRecursive:"+ FibonacciRecursive(10));
        print($"FibonacciRecursive:"+ FibonacciRecursive(30));

        print($"FibonacciIterative:"+ FibonacciIterative(10));
        print($"FibonacciIterative:"+ FibonacciIterative(30));
    }

   

    public int FibonacciRecursive(int n)=>(n<=1)?n:(FibonacciRecursive(n-1)+FibonacciRecursive(n-2));
    public int FibonacciIterative(int n){
       if (n<=1){
        return n ;
       }
       int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int num = a + b;
            a = b;
            b = num;
        }
        return b;
}
}
}