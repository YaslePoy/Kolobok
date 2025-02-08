using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOutHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Component added");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            Lifes.Singleton.SubstractLife();
        }
    }
    
    
}
