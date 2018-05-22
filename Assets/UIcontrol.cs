using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIcontrol : MonoBehaviour {

    public Text player1;
    public Text player2;

	// Use this for initialization
	void Start () {
        player1.text = "b";
        player2.text = "b";
	}
	
	// Update is called once per frame
	void Update () {
        player1.text = (ballcontrol.score[0]).ToString();
        player2.text = (ballcontrol.score[1]).ToString();
    }
}
