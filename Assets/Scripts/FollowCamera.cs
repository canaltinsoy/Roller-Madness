using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float cameraFollowSpeed;
    
    private Vector3 offsetVector;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(10f, 0, 0);
        //offsetVector = transform.position - player.position;
        Distance(player);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        MoveTheCamera();
        
    }    

    private void MoveTheCamera()
    {
        Vector3 targetToMove = player.position + offsetVector;
        //vector3.lerp a noktasından b noktasına t süreyle git anlamına geliyor.
        transform.position = Vector3.Lerp(transform.position,targetToMove, cameraFollowSpeed*Time.deltaTime);
        
        //lookat -> rotate z değerini verdiğimiz değere eşitliyor.
        transform.LookAt(player.transform.position);
    }

    public Vector3 Distance(Transform newTarget)
    {
        offsetVector = transform.position - newTarget.position;
        return offsetVector;
    }

}
