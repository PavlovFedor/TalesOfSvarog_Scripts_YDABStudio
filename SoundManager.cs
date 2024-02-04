using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] sound;
    public AudioSource a;
    // Start is called before the first frame update
    public void oneSound()
    {
        a.clip = sound[0];
        a.Play();
    }
    public void twoSound()
    {
        a.clip = sound[1];
        a.Play();
    }
    public void treeSound()
    {
        a.clip = sound[2];
        a.Play();
    }
    public void fourSound()
    {
        a.clip = sound[3];
        a.Play();
    }
    public void fiveSound()
    {
        a.clip = sound[4];
        a.Play();
    }
}