using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject wave;
    public float wavetimeleft;
    public float topspeed;
    public float speed;
    public Transform boattrans, homelesstrans;
    public RectTransform homelesscomp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        speed -= speed/2 * Time.deltaTime;
        speed = Mathf.Clamp(speed, 0, Mathf.Infinity);
        wavetimeleft -= Time.deltaTime;
        if (wavetimeleft <= 0)
        {
            for (int i = 0; i < 10; i++)
            {
                var posx = transform.position.x + Random.Range(-150f, 150f);
                var posz = transform.position.z + Random.Range(-150f, 150f);
                var a = Instantiate(wave, new(posx, 1.5f, posz), Quaternion.Euler(90, 180, -180));
            }
            wavetimeleft = Random.Range(.25f, 1f);
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, topspeed);
            if (Input.GetAxis("Horizontal") > 0)
            {

                Move();
            }
            if (Input.GetAxis("Horizontal") < 0)
            {

                Move();
            }
            if (Input.GetAxis("Vertical") > 0)
            {

                Move();
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                Move();
            }
        
    }

    void Move()
    {

        GetComponent<Rigidbody>().AddForce(boattrans.forward * topspeed, ForceMode.Force);



    }
}
