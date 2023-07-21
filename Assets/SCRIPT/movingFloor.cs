using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingFloor : MonoBehaviour
{
    public float moveSpeed;
    private float maxRight = 3f;  
    private float minRight = 0f;
  
    private bool isMovingRight = true;

    public GameObject MovingFloor;

    // Update is called once per frame
    void Update()
    {
        //#### Right-Left Obstacle
        if (isMovingRight)
        {
            MovingFloor.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (MovingFloor.transform.position.x >= maxRight)
            {
                isMovingRight = false;
            }
        }
        else
        {
            MovingFloor.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            if (MovingFloor.transform.position.x <= minRight)
            {
                isMovingRight = true;
            }
        }
        //barrelBridge();
    }

    //private void barrelBridge()
    //{
        
    //    if (isMovingSide)
    //    {
    //        BarrelMove.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //        if (BarrelMove.transform.position.z >= maxSide)
    //        {
    //            isMovingSide = false;
    //        }
    //    }
    //    else
    //    {
    //        BarrelMove.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    //        if (BarrelMove.transform.position.z <= minSide)
    //        {
    //            isMovingSide = true;
    //        }
    //    }
    //}
}
