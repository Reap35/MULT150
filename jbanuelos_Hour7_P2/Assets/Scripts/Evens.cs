using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int c = 22; c <= 100; c+=2)
        {
            Debug.Log(c);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
