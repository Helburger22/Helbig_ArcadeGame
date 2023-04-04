using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    public int maxHealth = 5;
    public int health = 5;
    public TextMeshProUGUI gameOverScreen;
    public string winnerMessage;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    public TextMeshProUGUI healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        health--;
        healthText.text = "P1 Lives: "+ health;
        Destroy(other.gameObject);
        if (health < 1)
        {
            Destroy(gameObject);
            gameOverScreen.text = winnerMessage;
            Debug.Log("Oppenent Hit");
        }
    }
    
    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        
    }
}
