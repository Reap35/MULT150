using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public int requiredCollisions = 1; // Set this to the number of collisions needed to solve the goal
    private int currentCollisions = 0; // Tracks the number of successful collisions

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        
        if (collidedWith.tag == gameObject.tag) // Check if tags match
        {
            currentCollisions++; // Increment counter for each valid collision
            
            if (currentCollisions >= requiredCollisions)
            {
                isSolved = true; // Mark the goal as solved when required collisions are reached
                GetComponent<Light>().enabled = false; // Turn off the light
            }

            Destroy(collidedWith); // Destroy the collided object
        }
    }
    /*
    public bool isSolved = false; // nothing has been scored
    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)// when the ball and trigger have sthe same tag name
        {
            isSolved = true;
            GetComponent<Light>().enabled = false; // turns the light off
            Destroy (collidedWith);   //destroys the ball 
        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
