using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_3_To_EndMenu_Script : MonoBehaviour {

    //void OnTriggerEnter(Collider2D other)
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider == true)
            //other.name should equal the root of your Player object
            //if (other.name == "Player")
            if (coll.gameObject.tag == "Player")
            {
                //The scene number to load (in File->Build Settings)
                SceneManager.LoadScene(2);
            }
    }
}
