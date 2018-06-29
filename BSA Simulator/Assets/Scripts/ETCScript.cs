using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETCScript : MonoBehaviour {

    private bool blockTrigger = false;
    ScoreManager scoreManager;


	// Use this for initialization
	void Start () {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
        if(blockTrigger == false) {
            scoreManager.updateScore(1);
            Destroy(gameObject);
        }
        blockTrigger = true;
	}

	private void OnTriggerExit(Collider other)
	{
        blockTrigger = false;
	}
}
