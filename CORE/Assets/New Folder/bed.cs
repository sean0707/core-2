﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed : MonoBehaviour
{
    public bool save;

    // Start is called before the first frame update
    void Start()
    {
        save = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (other.tag == "Player")
            {
                if (save)
                {
                    HP.manager.currentHealth = 100;
                    save = !save;
                }
            }
        }
    }
}
