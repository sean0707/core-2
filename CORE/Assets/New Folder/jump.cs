﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public bool stay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ground")
        {
            stay = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            stay = false;

        }
    }
}
