using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    Vector3 pos;
    // Use this for initialization
    void Start () {
        Vector3 pos = transform.position;
	} 
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        if (InputManager.vertical() > 0)
        {
            pos.y += 0.1f;
            transform.position = pos;
        }
        else if(InputManager.vertical() < 0)
        {
            pos.y -= 0.1f;
            transform.position = pos;
        }
	}
}
