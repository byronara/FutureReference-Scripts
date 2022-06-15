using System.Collections;
using System.Collection.Generic;
using UnityEngine;

public class JumpSoundPlay : MonoBehaviour
{
    private AudioSource ThisSource = null;
    
    void Awake()
    {
        ThisSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayClip();
        }
    }

    public IEnumerator CheckComplete()
    {
        yield return new WaitUntil(() => ThisSource.isPlaying == false);
        print("AudioSource playback complete!"); // Just a printf to see if the sound is playing
    }

    public void PlayClip()
    {
        StopAllCoroutines();
        ThisSource.Play();
        StartCoroutine(CheckComplete());
    }

}