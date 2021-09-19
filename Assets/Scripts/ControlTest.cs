using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTest : MonoBehaviour {
    // Use this for initialization
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(1))
            {
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 tmpDir = mousePosition - transform.position;
                transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed * 1f / tmpDir.magnitude * Time.deltaTime);
            }
        }
    }
