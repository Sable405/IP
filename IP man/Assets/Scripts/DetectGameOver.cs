using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectGameOver : MonoBehaviour

{
public Button RestartButton;
   public TextMeshProUGUI GameOverText;
  
        private void OnTriggerEnter2D(Collider2D other) 
        {
    
       GameOverText.gameObject.SetActive(true);
       RestartButton.gameObject.SetActive(true);   
        }
}
