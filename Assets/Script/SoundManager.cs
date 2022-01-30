using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    public static SoundManager soundManager;
    int x=-1;

    // Start is called before the first frame update
    void Awake()
    {
        if (soundManager == null)
        {
            soundManager = this;
        }
    }
    
    void Start()
    {
        
    }

    public void Sound(int i)
    {
        if (x == i)
        {
            return;
        }
        else
        {
            if(GetComponent<AudioSource>().isPlaying == true)
            {
                GetComponent<AudioSource>().Stop();
            }
            GetComponent<AudioSource>().PlayOneShot(audioClips[i], 1F);
        }
        x = i;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<AudioSource>().isPlaying == false)
        {
            x = -1;
        }
    }
}
