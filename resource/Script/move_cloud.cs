using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cloud : MonoBehaviour {

    public Vector2 v;
    // Use this for initialization
    void Start () {
        v.x = -0.005f;
        v.y = 0;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(v);
        if (transform.position.x < -37.25f)
            transform.position = new Vector3(18.3f, -0.6947938f, -7.66f);
    }
}
