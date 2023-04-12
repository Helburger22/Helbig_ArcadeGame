using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    public float zRange = 6;

    public float rotationSpeed;
    public string aimAxis;
    public string moveAxis;
    public GameObject pistol;
    public GameObject mG;
    public SpawnManager gunSpawner;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //keeps the players in bound
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        //moves the player left and right or horizontal 
        horizontalInput = Input.GetAxis(aimAxis);
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        //transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        verticalInput = Input.GetAxis(moveAxis);
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);



    }

    public void Pistol()
    {
        pistol.SetActive(true);
        
        mG.SetActive(false);
        gunSpawner.SpawnPowerup();
    }

    public void Gunner()
    {
        pistol.SetActive(false);
        mG.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gun"))
        {
            Gunner();
            Destroy(other.gameObject);
        }
    }
        
}

    



