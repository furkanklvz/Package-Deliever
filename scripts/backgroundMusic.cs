using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    public AudioSource mainMusic;
    void Start()
    {
        mainMusic.Play();
    }
}
