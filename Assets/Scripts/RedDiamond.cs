﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDiamond : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            FindObjectOfType<PlayerStatus>().coinsCollected += 10;
            Destroy(this.gameObject);
        }
    }
}
