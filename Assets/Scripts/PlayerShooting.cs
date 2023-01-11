using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotSpawn;
    public Transform weapon;
    public Camera mainCamera;
    public float fireRate;
    public float delay;
    public float bulletSpeed;

    private float nextFire;

    private void Start()
    {
        nextFire = Time.time + delay;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            // Aim the shotSpawn object at the middle of the screen
            Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2));
            shotSpawn.LookAt(ray.origin + ray.direction * 10);
            weapon.LookAt(ray.origin + ray.direction * 10);

            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(projectile, shotSpawn.position, shotSpawn.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed);
    }
}
