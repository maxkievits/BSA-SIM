using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

    public int gameScore = 0;
    public Text scoreLabel;
    private AudioSource itemCollectSound;

	// Use this for initialization
	void Start () {
        itemCollectSound = (AudioSource)GetComponent(typeof(AudioSource));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateScore(float increment) {
        gameScore = gameScore + (int)increment;
        scoreLabel.text = "ETCS: " + gameScore.ToString() + "/60";
        itemCollectSound.pitch = (0.5f + (gameScore / 60.0f));
        itemCollectSound.Play();
        if(gameScore >= 60.0f) {
            SceneManager.LoadScene("Win Scene");
        }
    }
}
