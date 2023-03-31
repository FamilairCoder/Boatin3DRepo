using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CompassPoint : MonoBehaviour
{
    public GameObject player, target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (target.transform.position - player.transform.position).normalized;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.localRotation = Quaternion.Euler(0, 0, -rotation.eulerAngles.y);

/*
        Vector3 direction = (target.transform.position - player.transform.position).normalized;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);

        // set the x and z rotations to zero so the needle stays level
        rotation.x = 0f;
        rotation.y = 0f;

        // rotate the needle to point towards the target
        transform.rotation = rotation;*/


    }

}
