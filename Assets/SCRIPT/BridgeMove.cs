using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMove : MonoBehaviour
{
    public bool isMovingSide = true;    
    public GameObject BarrelMove;
    public float moveSpeed = 2f;
    public float maxSide;   public float minSide;

    // Update is called once per frame
    void Update()
    {
        if (isMovingSide)
        {
            BarrelMove.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            if (BarrelMove.transform.position.z >= maxSide)
            {
                isMovingSide = false;
            }
        }
        else
        {
            BarrelMove.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            if (BarrelMove.transform.position.z <= minSide)
            {
                isMovingSide = true;
            }
        }

        oppositeBarrel();
    }
    public GameObject Barrel2;
    public bool opposite = true;
    private void oppositeBarrel()
    {
        //if (opposite)
        //{
        //   // Debug.Log(Barrel2.transform.Translate(Vector3.back * moveSpeed));
        //    Barrel2.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        //    if (Barrel2.transform.position.z <= minSide)
        //    {
        //        opposite = false;
        //    }
        //}
        //else
        //{
        //    Barrel2.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //    if (Barrel2.transform.position.z >= maxSide)
        //    {
        //        opposite = true;
        //    }
        //}
    }
}
