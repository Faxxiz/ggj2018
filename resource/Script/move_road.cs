using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_road : MonoBehaviour {

    public Vector2 v;
	// Use this for initialization
	void Start () {
        v.x = -0.03f;
        v.y = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(v);
        if (transform.position.x < -0.21f)
            transform.position = new Vector3(13.7f, 1.40791f, -8.2f) ;
    }
}
