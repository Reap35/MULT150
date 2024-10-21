using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCredit : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleAudio();
        }
    }

    public void ToggleAudio()
    {
        if (audioSource.isPlaying == true)
        {
                audioSource.Stop();
        }
            else
                audioSource.Play();
    }

}
