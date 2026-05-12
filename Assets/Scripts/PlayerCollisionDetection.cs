using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    public GameTimer gameTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
         void OnCollisionEnter(Collision col){
       if (col.gameObject.CompareTag("Caja"))
        {
            gameTimer.StopTimer();
            Destroy(gameObject);
        }
        }
}
