using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment29{
public class Utilities 
{
    public static int Add(params int[] numbers){
        int sum =0;
        foreach(var num in numbers){
            
            sum+=num;
        }
        return sum;
    }

    public static string RepeatString(string str,int a){
        string str1="";
        for(int i =0;i<a;i++){
            str1 += str;
        }
            return str1;
    }
}
}