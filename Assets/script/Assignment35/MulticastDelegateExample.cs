using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_35
{
public class MulticastDelegateExample : MonoBehaviour
{
    public delegate void MathOperation(int number);
    void DoubleNumber(int number)=>Debug.Log($"Double:{number*2}");
    void SquareNumber(int number)=>Debug.Log($"Square:{number*number}");
    void CubeNumber(int number)=>Debug.Log($"Cube:{number*number*number}");
    MathOperation operation;
    void Start()
    {
       

        operation += DoubleNumber;
        operation += SquareNumber;
        operation += CubeNumber;
        
        operation(5);
    }

}
}