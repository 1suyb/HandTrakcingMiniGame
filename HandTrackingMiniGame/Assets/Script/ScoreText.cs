using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Score score;
    public int oldScore;
    // Start is called before the first frame update
    void Start()
    {
        score.StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (score.nowGameScore != oldScore)
        {
            oldScore = score.nowGameScore;
            text.text = oldScore.ToString();
        }
    }
}
