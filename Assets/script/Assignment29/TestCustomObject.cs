using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class TestCustomObject : MonoBehaviour
{
    void Start()
    {
        CustomObject customobject=new CustomObject(1,"Example");
        CustomObject customobject2=new CustomObject(1,"Example");
        print(customobject);
        
        print($"Are objects equal {customobject==customobject2}");
        print($"Are objects not equal {customobject!=customobject2}");
    }

    void Update()
    {
        
    }
}
}