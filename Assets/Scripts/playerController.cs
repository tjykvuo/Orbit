using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement; //Make sure to add this, or you can't use SceneManager

public class playerController : MonoBehaviour
{
    private float speed;
    private Rigidbody2D rb2d;
    public GameObject bullet; //public reference to bullet
    private const float timeToCharge = 0.05f;
    private float chargeTime = 0.0f;

    //private const float timeToCharge = 0.05f;
    //private float chargeTime = 0.0f;
    // Use this for initialization
    void Start()
    {
        speed = 10;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("RotLeft"))
            RotateLeft();
        if (Input.GetButton("RotRight"))
            RotateRight();
        if (Input.GetButton("Vertical"))
            MoveForward();
        if (Input.GetMouseButton(0))
        {
            chargeTime += Time.deltaTime;
            if (chargeTime >= timeToCharge)
            {
                chargeTime -= timeToCharge;
                Instantiate(bullet, transform.position, transform.rotation);
            }
        }
        else if (!Input.GetMouseButton(0))
        {
            chargeTime = 0.0f;
        }
    }

    void RotateLeft()
    {
        Debug.Log("Hello");

        transform.Rotate(Vector3.forward * +1);
    }
    void RotateRight()
    {
        transform.Rotate(Vector3.forward * -1);
    }
    void MoveForward()
    {
        rb2d.AddForce(transform.up * speed * 10);
    }

    private void OnBecameInvisble()
    {
        Destroy(gameObject);

    }
    //private void OnTriggerEnter2D(Collider2D collision) //check whether bullet collider has overlapped with enemy collider 
    //{
       // if (collision.gameObject.tag == "EnemyShip")  //if tag of the collider is "UFO"
       // {
         //   Debug.Log("Hello");
         //   SceneManager.LoadScene(0);
            //Destroy(collision.gameObject); //destroy the bullet 
            // Destroy(gameObject);  //destroy the enemy 
      //  }

   // }
}
