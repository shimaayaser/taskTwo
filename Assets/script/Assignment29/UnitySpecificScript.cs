using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment29{
public class UnitySpecificScript : MonoBehaviour
{
    
    void  OnEnable(){
    print("GameObject Enabled");
    }
    void OnDisable(){
        print("GameObject Disabled");
    }
    void Start(){
       
        print("Game started!");
        GameObject targetObject = GameObject.Find("TargetObject");
        if(targetObject!=null){
            print($"Found TargetObject: " +targetObject.name);
        }
        GameObject jokerObject = GameObject.FindGameObjectWithTag("Joker");
        if(jokerObject!=null){
            print($"Found Joker object: " +jokerObject.name);
        }
        Light lightObject = GameObject.FindObjectOfType<Light>();
        if(lightObject!=null){
            print($"Found Light object: "+lightObject.name);
        }

    }
    void Update() {
       if(Input.GetKeyDown(KeyCode.D)){
           GameObject  targetObject  = GameObject.Find("TargetObject"); 
           if (targetObject != null)
            {
                targetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
            else
            {
                print("No TargetObject");
            }

       } 
    }
  
}
}