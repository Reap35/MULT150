using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunction : MonoBehaviour
{
    private int num1;
    // Start is called before the first frame update
    void Start()
    {
        int num2;
        Debug.Log("Start runs before an object Updates");
        
    }
    public int runSpeed;
    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is called once a frame");
        // Debug.Log("spam! @#%*&@#$%");
    }
}
