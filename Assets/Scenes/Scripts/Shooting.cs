using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform camera;
    public GameObject explosion;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit))
        {
            Destroy(hit.transform.gameObject);
            Instantiate(explosion, hit.transform.position, Quaternion.identity);

            GameManager.instance.count--;
        }
    }
}