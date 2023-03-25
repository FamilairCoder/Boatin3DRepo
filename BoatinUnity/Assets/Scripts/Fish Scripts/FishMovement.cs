using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed, turningspeed;
    private float dirtimeleft;
    private Quaternion targetrot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirtimeleft -= Time.deltaTime;
        if (dirtimeleft <= 0)
        {
            float randomYRotation = Random.Range(0f, 360f);            
            var rotx = transform.rotation.x;
            var rotz = transform.rotation.z;
            targetrot = Quaternion.Euler(rotx, randomYRotation, rotz);
            dirtimeleft = Random.Range(1f, 5f);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetrot, turningspeed);
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, speed);
        GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Force);
    }
}
