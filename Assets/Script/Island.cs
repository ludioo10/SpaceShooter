﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour {

    void Update()
    {
        this.transform.Translate(-Vector2.up * Time.deltaTime);
        if (this.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
