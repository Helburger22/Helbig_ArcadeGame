using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds1 : MonoBehaviour
{
    public float xBound;
    public float zBound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > xBound)
        {
            Destroy(gameObject);
        }

        else if(transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
        
        else if(transform.position.z>zBound)
        {
            
            Destroy(gameObject);
        }

        else if(transform.position.z<-zBound)
        {
            
            Destroy(gameObject);
        }
    }
}
