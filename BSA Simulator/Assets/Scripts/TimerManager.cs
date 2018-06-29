using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerManager : MonoBehaviour {

    public Text timerText;
    public float currentTime = 60;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if(currentTime <= 0) {
            SceneManager.LoadScene("GameOver Scene");
        } else {
            currentTime -= Time.deltaTime;
            timerText.text = "TIME: " + ((int)currentTime).ToString();
        }
   	}
}
