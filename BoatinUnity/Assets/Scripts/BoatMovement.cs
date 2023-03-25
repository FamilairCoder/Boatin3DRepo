using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{

    public float turningspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetAxis("Horizontal") > 0)
        {
            
            Move(90);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {

            Move(-90);
        }
        if (Input.GetAxis("Vertical") > 0)
        {

            Move(0);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            Move(180);
        }
    }

    void Move(float angle)
    {
        
        var rotx = transform.rotation.x;
        var rotz = transform.rotation.z;
        var targetrot = Quaternion.Euler(rotx, angle, rotz);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetrot, turningspeed);
    }
}
