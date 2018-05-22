using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject LB;
    public GameObject RB;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.W))
        {
            LB.GetComponent<Rigidbody>().velocity = new Vector3(0, 4);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            LB.GetComponent<Rigidbody>().velocity = new Vector3(0, -4);
        }

        else LB.GetComponent<Rigidbody>().velocity = new Vector3(0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            RB.GetComponent<Rigidbody>().velocity = new Vector3(0, 4);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            RB.GetComponent<Rigidbody>().velocity = new Vector3(0, -4);
        }

        else RB.GetComponent<Rigidbody>().velocity = new Vector3(0, 0);
    }
}
