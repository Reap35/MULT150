using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health;
        health = 100;
        
        int potion = 20;

        health = health - 30; // health -= 30;
        health = health + potion; // health + potion

        Debug.Log("health is " + health);
        Debug.Log("potion is " + potion); 

        int damage = 30; // positive or negative whole numbers
        float speed = 10.0f; // decimal values, must be terminated with f
        double rocketSpeed = 1004.4234243; // similar to float, but holds larger values
        bool gameover = false; // true or false
        char someCharacter = 'A'; // simple character enclosed in single quotes
        string manyCharacters = "The night is dark and full of terrors";
        // multiple characters enclosed in double quotes
        Debug.Log("damage value is " + damage);
        Debug.Log("speed is " + speed);
        Debug.Log("rocketSpeed is " + rocketSpeed);
        Debug.Log("is the game over? " + gameover);
        Debug.Log("someCharacter: " + someCharacter);
        Debug.Log("manyCharacter: " + manyCharacters);
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("spam! @#%*&@#$%");
    }
}
