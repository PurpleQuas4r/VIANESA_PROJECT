using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;
    public float shotForce = 1500f;
    public float shotRate = 0.3f;
    private float shorRateTime = 0;

    void Update()
    {
        GameObject newBullet;
        newBullet = Instantiate(bullet, spawnPoint.position,spawnPoint.rotation);

        newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);
        
    }
}
