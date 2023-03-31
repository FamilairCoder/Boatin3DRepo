using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject wave, boat, bobber, bobberpoint, createdbobber;
    public float wavetimeleft;
    public float topspeed;
    public float speed;
    public Transform boattrans, homelesstrans;
    public GameObject bobberline;
    public static float bobberforce;
    public float turningspeed;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 7);
        Physics.IgnoreLayerCollision(6, 6);
        Physics.IgnoreLayerCollision(7, 7);
        Physics.IgnoreLayerCollision(6, 8);
        Physics.IgnoreLayerCollision(6, 9);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && !Bobber.hooked)
        {
            if (createdbobber.gameObject != null) { Destroy(createdbobber); }
            if (bobberforce < 75) { bobberforce += 50 * Time.deltaTime; }
        }


        if (Input.GetKeyUp(KeyCode.Space) && !Bobber.hooked)
        {
            createdbobber = Instantiate(bobber, bobberpoint.transform.position, Quaternion.identity);
            createdbobber.GetComponent<Rigidbody>().AddForce(transform.forward * bobberforce, ForceMode.Impulse);
            bobberforce = 0;
        }

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
        
        if (Input.GetAxis("Vertical") > 0)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * topspeed , ForceMode.Force);
            GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, topspeed);
        }
    }

}
