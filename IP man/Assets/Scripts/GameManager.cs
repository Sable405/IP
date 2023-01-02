using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool IsGameActive;
    
    public GameObject StartScene;

    public TextMeshProUGUI GameOverText;

    public Button RestartButton;

    public Button StartButton;

    public GameObject objectToSpawn; 

    public GameObject Player;

    public GameObject UITimer;
    public Button Objective;
        
    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
          //GameTitleText.gameObject.SetActive(false);
        StartButton.gameObject.SetActive(true);
        StartScene.gameObject.SetActive(true);
        UITimer.gameObject.SetActive(false);
         Objective.gameObject.SetActive(true);
    }
    public void ST()
    {
      IsGameActive = true;
      Instantiate(objectToSpawn);
    StartButton.gameObject.SetActive(false);
    StartScene.gameObject.SetActive(false);
     Objective.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
    if (IsGameActive == false) 
    {
        
    }
     
    }
     public void GameOver()
    {
       GameOverText.gameObject.SetActive(true);
       RestartButton.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartTimer()
    {
      UITimer.gameObject.SetActive(true);
    }
    public void StoryText()
    {
        SceneManager.LoadScene(1);
    }
    
}
