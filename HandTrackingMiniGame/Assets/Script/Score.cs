using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScriptableObject/Score")]
public class Score : ScriptableObject
{

    public int nowGameScore = 0;
    
    public void StartGame()
    {
        nowGameScore = 0;
    }

}
