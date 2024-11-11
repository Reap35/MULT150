using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int lampCount = 10;
    public float spacing = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lampCount; i++)
        {
            // Calculate the new position by adding an offset along the X-axis
            Vector3 position = transform.position + new Vector3(i * spacing, 0, 0);
            
            // Instantiate the prefab at the calculated position
            Instantiate(prefab, position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // When the "B" key is pressed, it generates a prefab at the original position of the prefab.
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        // When the "Space" key is pressed, it generates a prefab at the position and rotation
        // of the GameObject this script is attached to.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
