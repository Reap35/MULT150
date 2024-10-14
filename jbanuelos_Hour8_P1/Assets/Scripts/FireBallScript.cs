using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    int playerHealth = 100;
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball(10, playerHealth);
        Debug.Log("Player health: " + x);

        int y = TakeDamageFromFireball(25, x);
        Debug.Log("Player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("Player health: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
