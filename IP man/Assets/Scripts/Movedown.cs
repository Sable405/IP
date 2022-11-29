using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedown : MonoBehaviour
{
    public float moveSpeed =10;
    
    private PlayerController _playerScript; 

    // Start is called before the first frame update
    void Start()
    {
       
        _playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       // if(!_playerScript.isGameOver)
        { 
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
           // transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        
    }
}
