using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //count the 7 days of a week 
        for (int d = 1; d <= 7; d++)
        {
            Debug.Log(d);
        }


        int sum = 0;
        int count = 1;
        while (count <= 10)
        {
            Debug.Log("sum" + sum + " count:" + count);
            sum = sum + count; // sum += count
            count++;
        }
        Debug.Log("final sum" + sum);

        int i = 0;
        i ++;
        Debug.Log(i);
        i --;
        Debug.Log(i);


        int health = 100;

        if (health == 0) // == eqaual, != not equal
        {
            Debug.Log("player has been unalived!");    
        }
        else if (health < 30)
        {
            Debug.Log("Danger! Low health");
        }
        else if (health == 100)
        {
            Debug.Log("player is chilling");
        }
        else
        {
            Debug.Log("player is alive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
