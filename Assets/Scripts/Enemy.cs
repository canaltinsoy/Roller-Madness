using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Transform target;

    [SerializeField] float stopDistance = 1f;

    private float enemySpeed = 2f;



    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target.position);

            float distance = Vector3.Distance(transform.position, target.position);

            if (distance > stopDistance)
            {
                transform.position += transform.forward * enemySpeed * Time.deltaTime;
                //print(distance);
            }
        }




        //transform.position += transform.forward * enemySpeed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);

            TimeManager timeManager = FindObjectOfType<TimeManager>();

            timeManager.gameOver = true;
        }
    }
}
