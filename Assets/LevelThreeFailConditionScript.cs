using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelThreeFailConditionScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("test");
            Destroy(collision.gameObject);
            Destroy(gameObject);

            SceneManager.LoadScene("LevelThree");

        }
    }

}
