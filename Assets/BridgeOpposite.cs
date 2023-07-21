using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOpposite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        oppositeBarrel();
    }
    public GameObject Barrel2;
    public bool opposite = true;
    public float moveSpeed = 2f;
    public float maxSide; public float minSide;
    private void oppositeBarrel()
    {
        if (opposite)
        {
            // Debug.Log(Barrel2.transform.Translate(Vector3.back * moveSpeed));
            Barrel2.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            if (Barrel2.transform.position.z <= minSide)
            {
                opposite = false;
            }
        }
        else
        {
            Barrel2.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            if (Barrel2.transform.position.z >= maxSide)
            {
                opposite = true;
            }
        }
    }
}
