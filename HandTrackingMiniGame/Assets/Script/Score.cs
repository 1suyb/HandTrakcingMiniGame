using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScriptableObject/Score")]
public class Score : ScriptableObject
{

    private int _nowGameScore = 0;
    public int nowGameScore
    {
        get { return _nowGameScore; }
        set { _nowGameScore = value; }
    }
    
    public void StartGame()
    {
        nowGameScore = 0;
    }

}
