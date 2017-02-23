using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseToObj : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Camera.main.ScreenToWorldPoint(pos);
        Vector3 pos = GetPos();
        Vector3 position = Camera.main.ScreenToWorldPoint(pos); ;
		transform.position=new Vector3(position.x,0.3f,position.z);
    }

    private static Vector3 GetPos()
    {
        return Input.mousePosition;
    }
}
