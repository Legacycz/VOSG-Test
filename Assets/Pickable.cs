﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<CompleteProject.PlayerHealth>().TakeDamage(-15);
            Destroy(gameObject);
        }
	}
}
