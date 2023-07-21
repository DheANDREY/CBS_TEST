using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject canon;
    public GameObject prefabBullet;
    // Update is called once per frame
    void Update()
    {
        //#### Shot Bullet from Canon
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject instantiatedBullet;
            instantiatedBullet = Instantiate(prefabBullet, canon.transform.position, Quaternion.identity) as GameObject;
            instantiatedBullet.transform.SetParent(transform);
        }
    }
}
