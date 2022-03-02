using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class looseCollider : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("collider");
       SceneManager.LoadScene("loose Game");

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");

    }
}
