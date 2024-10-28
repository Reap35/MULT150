using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
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
        Debug.Log("Entered" + gameObject.name);
    }
    void OnTriggerStay (Collider Other)
    {
        Debug.Log("Staying in" + gameObject.name);
    }
    void OnTriggerExit (Collider Other)
    {
        Debug.Log("Exited" + gameObject.name);
    }
}
