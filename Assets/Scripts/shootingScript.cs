using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour
{

    float _bulletDirection;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }


    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameManager.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 180 * _bulletDirection));
        }

    }


}
