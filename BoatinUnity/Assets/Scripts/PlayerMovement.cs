using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject wave, boat;
    public float wavetimeleft;
    public float topspeed;
    public float speed;
    public Transform boattrans, homelesstrans;
    public RectTransform homelesscomp;

    public float turningspeed;
    private bool moveRight = false;
    private bool moveLeft = false;
    private bool moveForward = false;
    private bool moveBackward = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
        {
            transform.Rotate(Vector3.up, horizontalInput * turningspeed * Time.deltaTime);
        }


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


    void FixedUpdate()
    {
        // Reset the movement force
        /*        Vector3 movementForce = Vector3.zero;*/

        // Check the current state of the input keys
        /*        if (Input.GetAxis("Horizontal") > 0)
                {
                    boat.transform.rotation = Quaternion.RotateTowards(boat.transform.rotation, Quaternion.Euler(0, 90, 0), turningspeed);
        *//*            movementForce += boat.transform.right * topspeed;*//*
                }
                else if (Input.GetAxis("Horizontal") < 0)
                {
                    boat.transform.rotation = Quaternion.RotateTowards(boat.transform.rotation, Quaternion.Euler(0, -90, 0), turningspeed);
        *//*            movementForce -= boat.transform.right * topspeed;*//*
                }*/

        /*        if (Input.GetAxis("Vertical") > 0)
                {
                    movementForce += boat.transform.forward * topspeed;
                }
                else if (Input.GetAxis("Vertical") < 0)
                {
                    movementForce -= boat.transform.forward * topspeed;
                }*/

        // Apply the movement force to the rigidbody
        if (Input.GetAxis("Vertical") > 0)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * topspeed , ForceMode.Force);
            GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, topspeed);
        }
    }

    /*    private void FixedUpdate()
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



        }*/

    /*    void FixedUpdate()
        {
            // Reset the movement force
            Vector3 movementForce = Vector3.zero;

            // Check the current state of the input keys
            if (Input.GetAxis("Horizontal") > 0)
            {
                moveRight = true;
                moveLeft = false;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                moveRight = false;
                moveLeft = true;
            }
            else
            {
                moveRight = false;
                moveLeft = false;
            }

            if (Input.GetAxis("Vertical") > 0)
            {
                moveForward = true;
                moveBackward = false;
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                moveForward = false;
                moveBackward = true;
            }
            else
            {
                moveForward = false;
                moveBackward = false;
            }

            // Update the movement force based on the input
            if (moveRight && !moveLeft)
            {
                movementForce += boattrans.right * topspeed;
            }
            else if (moveLeft && !moveRight)
            {
                movementForce -= boattrans.right * topspeed;
            }

            if (moveForward && !moveBackward)
            {
                movementForce += boattrans.forward * topspeed;
            }
            else if (moveBackward && !moveForward)
            {
                movementForce -= boattrans.forward * topspeed;
            }

            // Apply the movement force to the rigidbody
            GetComponent<Rigidbody>().AddForce(movementForce, ForceMode.Force);
            GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, topspeed);
        }*/
}
