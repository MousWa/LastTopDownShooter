using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSound : MonoBehaviour
{
    public static AudioClip fireSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        fireSound = Resources.Load<AudioClip>("fire");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Fire":
                audioSrc.PlayOneShot(fireSound);
                break;
        }
    }
}
