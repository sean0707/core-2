﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public bool N;
    public int  C;
    public int pt;
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
        if (other.tag == "Player")
        {
            if (TMP.ctrl.p < C)
            {
                GetComponent<SphereCollider>().enabled = false;
                N = true;
            }
            TMP.ctrl.s = pt;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            N = false;
            GetComponent<Collider>().enabled = true;
        }
    }
}
