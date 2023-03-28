using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound=10;
    private float lowerBound=-10;
    private float rightBound = 60;
    private float leftBound = -60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroys game object after it reaches past the players view in the game decided by the topBound variable
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //Destroys game object after it reaches past the player decided by the lowerBound variable
        else if(transform.position.z<lowerBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x<rightBound) 
        {
            Destroy(gameObject);
        }
        else if(transform.position.x<leftBound) {
            Destroy(gameObject);
        }
        
    }
}
