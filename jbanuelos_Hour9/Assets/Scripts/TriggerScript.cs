using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider Other)
    {
        Debug.Log(Other.gameObject.name + "has entered the cube");
    }
    void OnTriggerStay (Collider Other)
    {
        Debug.Log(Other.gameObject.name + "is still in the cube");
    }
    void OnTriggerExit (Collider Other)
    {
        Debug.Log(Other.gameObject.name + "has left the cube");
    }
}
