using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyShip : MonoBehaviour{
    public float speed;
    public Transform player;
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
        transform.eulerAngles = new Vector3(0, 0, z);
        rb2d.AddForce(gameObject.transform.up * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision) //check whether bullet collider has overlapped with enemy collider 
    {
       if (collision. tag == "bullet")  //if tag of the collider is "bullet"
       {
            Destroy(collision.gameObject); //destroy the bullet 
            Destroy(gameObject);  //destroy the enemy 
       }




        if (collision.gameObject.tag == "Player")  //if tag of the collider is "Player"
        {
                SceneManager.LoadScene(0);
            //Destroy(collision.gameObject); //destroy the bullet 
            // Destroy(gameObject);  //destroy the enemy 
        }

    }

}

