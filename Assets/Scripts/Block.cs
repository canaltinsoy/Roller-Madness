using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private bool isColided = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (isColided == false)
        {
            print(other.gameObject.name);


            GetComponent<MeshRenderer>().material.color = Color.red;
            //FindObjectOfType<ScoreManager>().score -= 1;

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score--;

            isColided = true;


        }
    }
}
