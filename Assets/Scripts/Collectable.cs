using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int scoreAmount = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    private void OnTriggerEnter(Collider other) 
    {
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.score += scoreAmount;
        Destroy(gameObject);
    }
    */
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score += scoreAmount;
            Destroy(gameObject);
        }
    }
}
