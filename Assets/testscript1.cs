﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1")){
            print("script works");
        }
         if(Input.GetKeyDown("2")){
            print("2 button hit");
        }
    }
}
