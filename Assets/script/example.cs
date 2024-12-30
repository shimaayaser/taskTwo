using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // int num =5;
        // string name="Shimaa";
        // Debug.Log(num+4);
        // Debug.Log(num*5);
        // Debug.Log(num-3);
        // Debug.Log(num/3);
        // Debug.Log(name);
        // Debug.Log(num);
        // Debug.LogWarning(" warning message");
        // Debug.LogError("unexpected message");
        int playerLive=3;
        while(playerLive>=0){
            if(playerLive==3){
                Debug.Log("Many Live");
            }
            else if(playerLive==2) {
                Debug.Log("Two Life");
            }   
            else if(playerLive==1){
                Debug.Log("The Last Life");
            }
            else{
                Debug.Log("Game Over");
            }
            --playerLive;
        };
        



    }

    
}
