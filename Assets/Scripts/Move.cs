using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    private float xPos;
    private float zPos;

    [SerializeField] float speed;

    private Vector3 movement;

    private Rigidbody theRB;

    private TimeManager timeManager;

    void Start()
    {
        theRB = GetComponent<Rigidbody>();
        timeManager = FindObjectOfType<TimeManager>();
    }

    
    void Update()
    {
        
       if(timeManager.gameOver == false && timeManager.oyunBitti == false)
       {
           MoveThePlayer();
       }
       if(timeManager.gameOver || timeManager.oyunBitti)
       {
           theRB.isKinematic = true;
       }

    }

    private void MoveThePlayer()
    {
        xPos = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        zPos = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        movement = new Vector3(xPos, 0f, zPos);

        //transform.position += movement;

        theRB.AddForce(movement);
    }
}
