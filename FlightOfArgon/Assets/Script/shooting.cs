using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour
{
    public float interval = .2f;
    public float bulletSpeed = 10;
    public Rigidbody bullet;
    bool canShoot = true;
    public Transform gunOne;
    public Transform gunTwo;
    
    


    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, gunOne.transform.position, gunOne.transform.rotation);
        bulletClone.velocity = transform.forward * bulletSpeed;
        Rigidbody bulletClone2 = (Rigidbody)Instantiate(bullet, gunTwo.position, gunTwo.transform.rotation);
        bulletClone2.velocity = transform.forward * bulletSpeed;
       


    }

    void Update()
    {
        
        if (canShoot)
        {
            canShoot = false;
            Fire();
            StartCoroutine("ShootAgain");
        }
    }

    IEnumerator ShootAgain()
    {
        yield return new  WaitForSeconds(interval);
        canShoot = true;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Enemy")
        {
            
        }
    }

}