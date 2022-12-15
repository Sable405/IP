using System;  
using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.UI;  
  
public class Timer: MonoBehaviour {  
  int countDownStartValue = 120;  
  public Text timerUI;  
  
  void Start() {  
    countDownTimer();  
  }  
  
  void countDownTimer() {  
    if (countDownStartValue > 0) {  
      TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);  
      timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;  
      countDownStartValue--;  
      Invoke("countDownTimer", 1.0f);  
    } else {  
      timerUI.text = "You survived 2 Minutes Now destroy the donut";  
    }  
  }  
  void Update() {}  
}  