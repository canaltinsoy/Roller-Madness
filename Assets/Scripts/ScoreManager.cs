using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    
    public int score = 0;
    [SerializeField] private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUpdate();
    }

    private void ScoreUpdate()
    {
        scoreText.text = "Score: " + score.ToString();
    }


}
