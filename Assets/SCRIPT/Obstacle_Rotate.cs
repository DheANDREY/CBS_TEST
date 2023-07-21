using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Rotate : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    private float moveSpeed = 0.25f;
    private float maxHeight = 1.0f;
    private float minHeight = -1.0f;
   
    private bool isMovingUp = true; 

    public float rotateSpeed = 110.0f;
    private Quaternion initialRotation;
    private Vector3 initialPosition;

    public float bulletSpeed = 100.0f;

    public GameObject RotateWood;
    public GameObject pressBarrel;
    public GameObject launchFloor;
    
    // Start is called before the first frame update
    void Start()
    {
        // Simpan rotasi awal objek
        initialRotation = launchFloor.transform.rotation;
        initialPosition = launchFloor.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //#### Endless Rotating Obstacle
       RotateWood.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);

        //#### UpDown Obstacle
        if (isMovingUp)
        {
            pressBarrel.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            if (pressBarrel.transform.position.y >= maxHeight)
            {
                isMovingUp = false;
            }
        }
        else
        {
            pressBarrel.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            if (pressBarrel.transform.position.y <= minHeight)
            {
                isMovingUp = true;
            }
        }


        

        //#### Force Launch Obstacle
        // Putar objek berdasarkan kecepatan rotasi hanya pada sumbu X
        launchFloor.transform.rotation = Quaternion.Euler(rotateSpeed * Time.deltaTime, 0.0f, 0.0f) * launchFloor.transform.rotation;

        // Kembalikan posisi objek ke posisi awal
        launchFloor.transform.position = initialPosition;

        
        
    }


}
