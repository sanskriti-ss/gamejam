using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    #region Singleton

    public float currentScore = 0f;

    public bool isPlaying = false;

    private void Update(){
        if (isPlaying) {
            currentScore += Time.deltaTime;
        }
    }

    public void GameOver() {
        currentScore = 0;
    }

    public string PrettyScore () {
        return Mathf.RounToInt(currentScore).ToString();
    }






}