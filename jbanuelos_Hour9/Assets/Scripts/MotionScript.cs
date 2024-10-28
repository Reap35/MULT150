using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Horizontal") / 100; 
        // moves from x axes, ("Horizontal") is for left and right arrow, /100 is to slow down the speed
        float mY = Input.GetAxis("Vertical") / 100;
        //moves from y axes, ("Vertical") is for up and down arrow, /100 ditto

        transform.Translate(mX, mY, 0);
    }
}
