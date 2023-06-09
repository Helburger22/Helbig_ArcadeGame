using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shoot : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject projectilePrefab;
    public int maxAmmo;
    public int ammo;
    public KeyCode shootKey;
    bool reloading;
    //public KeyCode reloadKey;
    public SpriteRenderer sprite;
    public PlayerController player;
    public TextMeshProUGUI ammoText;
    public string Player;
    // Start is called before the first frame update
    void Start()
    {
        UpdateAmmo();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAmmo();
        
        if (Input.GetKeyDown(shootKey) && !reloading)
        {
            

            if (ammo > 0)
            {
                //Launch a projectile from the player
                Instantiate(projectilePrefab, bulletSpawn.position, bulletSpawn.rotation);
                ammo--;
                
            }


        }
        if (ammo < 1) //Input.GetKeyDown(reloadKey)
            {
                StartCoroutine(ReloadAnim());    
        }
    }
    IEnumerator ReloadAnim()
    {
        sprite.color = Color.grey;
        reloading = true;
        yield return new WaitForSeconds(1f);
        sprite.color = Color.white;
        reloading = false;
         if (maxAmmo > 0){
             ammo = maxAmmo;

         }
         else
            {
                ammo=24;
                player.Pistol();
            }
        
        UpdateAmmo();
    }

    void UpdateAmmo()
    {
        ammoText.text = Player + " Ammo: " + ammo;
    }
}
