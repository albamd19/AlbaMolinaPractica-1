﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//El coche se mueve hacia delante
        transform.Translate(20 * Time.deltaTime * Vector3.forward);
        
    }
}
