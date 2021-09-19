using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; //Make sure to add this, or you can't use SceneManager


public class Level_1_to_Level_2_Script : MonoBehaviour
{

    //void OnTriggerEnter(Collider2D other)
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider == true)
            //other.name should equal the root of your Player object
            //if (other.name == "Player")
            if (coll.gameObject.tag == "Player")
            {
            //The scene number to load (in File->Build Settings)
            SceneManager.LoadScene(3);
        }
    }
}