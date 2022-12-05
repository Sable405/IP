using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    public GameObject ExplosionFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
     {
      if(other.gameObject.CompareTag("Asteroid"))
      {
        Instantiate(ExplosionFX, transform.position, ExplosionFX.transform.rotation);
        Destroy(this.gameObject);
      }  

     }
}
