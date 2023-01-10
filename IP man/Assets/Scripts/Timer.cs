using System;  
using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.UI;  
using TMPro;
  
public class Timer: MonoBehaviour {  
  public Button Continue;
  int countDownStartValue = 120;  
  public Text timerUI;  
  
  void Start() {  
    countDownTimer();  
    Continue.gameObject.SetActive(false);
  }  
  
  void countDownTimer() {  
    if (countDownStartValue > 0) {  
      TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);  
      timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;  
      countDownStartValue--;  
      Invoke("countDownTimer", 1.0f);  
      
    } else {  
      StartCoroutine(ContinueRoutine());
      timerUI.text = "You survived 2 Minutes Now destroy the donut";             
    }  

  }
  IEnumerator ContinueRoutine()
        {
            yield return new WaitForSeconds(5);
            Continue.gameObject.SetActive(true);
        }
    void Update() {}  

}  