using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Sound : MonoBehaviour

 
{
    public AudioSource _StartAudio;
    public AudioClip Duck;
    public AudioClip Power;
    void Start()
    {
         _StartAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
