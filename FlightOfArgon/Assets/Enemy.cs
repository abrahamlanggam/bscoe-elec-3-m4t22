using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 100;
    public GameObject explosionPrefab;
    ScoreManager scoreM;
    GameManagerScript gameM;
   
	// Use this for initialization
	void Start () {
        scoreM = FindObjectOfType<ScoreManager>();
        gameM = FindObjectOfType<GameManagerScript>();
        
        
    }
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {

            
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            scoreM.AddScore();
            gameObject.SetActive(false);
            Invoke("Respawn",7);
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            
            health -= Random.Range(20, 50);
        }

    }

    void Respawn()
    {
        health = 100;
        gameObject.SetActive(true);
    }
 


}
