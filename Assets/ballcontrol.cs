using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ballcontrol : MonoBehaviour {

    Rigidbody rigb;
    public static int[] score = new int[2];




    // Use this for initialization
    void Start() {
        score[0] = 0;
        score[1] = 0;
        rigb = GetComponent<Rigidbody>();
        StartCoroutine(Pause());
       
     }

	IEnumerator Pause() 
    {
        transform.position = Vector3.zero;
        yield return new WaitForSeconds(2f);
       
        rigb.velocity = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8));
        

    }
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -10) {
            if (score[0] < 1)
            {
                StartCoroutine(Pause());
                score[0] += 1;
                
                
            }
            else
            {
                SceneManager.LoadScene(2);
            }
        }
        else if (transform.position.x > 10) { 
            if (score[1] < 1)
            {
                StartCoroutine(Pause());
                score[1] += 1;
                
            }
            else
            {
                SceneManager.LoadScene(2);
            }
        }
	}

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "Upbord")
        {
            float speed = 0;
            if (rigb.velocity.x > 0) {
                speed = 8;
            }
            else { speed = -8; }

            rigb.velocity = new Vector3(speed, -8f);
        }
        if (hit.gameObject.name == "Downbord")
        {
            float speed = 0;
            if (rigb.velocity.x > 0)
            {
                speed = 8;
            }
            else { speed = -8; }

            rigb.velocity = new Vector3(speed, 8f);
        }
        else if (hit.gameObject.name == "LB")
        {
            if(transform.position.y - hit.gameObject.transform.position.y < -0.2)
            {
                rigb.velocity = new Vector3(8 + Time.time/5, -8f);

            }
            else if (transform.position.y - hit.gameObject.transform.position.y > 0.2)
            {
                rigb.velocity = new Vector3(8 + Time.time / 5, 8);
            }
            else { rigb.velocity = new Vector3(8 + Time.time / 5, 0); }
        }
        else if (hit.gameObject.name == "RB")
        {
            if (transform.position.y - hit.gameObject.transform.position.y < -0.2)
            {
                rigb.velocity = new Vector3(-8 + Time.time / 5, -8);

            }
            else if (transform.position.y - hit.gameObject.transform.position.y > 0.2)
            {
                rigb.velocity = new Vector3(-8 + Time.time / 5, 8);
            }
            else { rigb.velocity = new Vector3(-8 + Time.time / 5, 0); }
        }
    }




}
