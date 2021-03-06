using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;
    public float shotForce = 150000f;
    public float shotRate = 0.3f;
    private float shorRateTime = 0;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") &&  !PauseMenu.GameIsPaused)
        {
            if (Time.time> shorRateTime && GameManager.Instance.gunAmmo > 0)
            {
                GameManager.Instance.gunAmmo--;

                GameObject newBullet;
                newBullet = Instantiate(bullet, spawnPoint.position,spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

                shorRateTime = Time.time + shotRate;

                Destroy(newBullet, 5);
            }
       
        
        }
        
    }
}
