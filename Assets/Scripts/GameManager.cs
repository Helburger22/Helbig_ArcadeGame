using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public bool isGameActive;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            StartGame();
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // or if (Input.GetButtonUp("Cancel")) {
            Application.Quit();
        }

    }

    public void StartGame(){
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
    }
}
