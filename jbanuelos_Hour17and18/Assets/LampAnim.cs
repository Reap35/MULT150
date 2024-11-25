using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LampAnim : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("LampColor");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("LampScale");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("LampRotate");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("LampJump");
        }
    }
}
