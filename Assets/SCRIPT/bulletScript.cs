using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject bulletPrefab;
    public float bulletSpeed = 0.01f;
    // Update is called once per frame
    void Update()
    {
        bulletPrefab.transform.Translate(Vector3.left * bulletSpeed);
    }
}
