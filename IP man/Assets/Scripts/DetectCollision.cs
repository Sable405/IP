using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour

{
  //private AudioSource _playerAudio;
 // public AudioClip crashSounds;
        private void OnTriggerEnter2D(Collider2D other) 
        {
            Destroy(other.gameObject);  
            Destroy(this.gameObject);  
           //_playerAudio.PlayOneShot(crashSounds, 1.0f);
        }
}
