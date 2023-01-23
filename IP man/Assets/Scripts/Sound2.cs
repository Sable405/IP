using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sound2 : MonoBehaviour

{
  
  public AudioSource _StartAudio;
    public AudioClip Explode;



 // private AudioSource _playerAudio;
 // public AudioClip crashSounds;
   void Start()
    {

        _StartAudio = GetComponent<AudioSource>();
    }
        private void OnTriggerEnter2D(Collider2D other) 
        {
           _StartAudio.PlayOneShot(Explode, 1.0f);
        }
}
