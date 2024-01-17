using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;


public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform camera;
    public GameObject explosion;
    public AudioSource popSound;



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
            popSound.Play();
            GameManager.instance.count--;
        }


    }
}
