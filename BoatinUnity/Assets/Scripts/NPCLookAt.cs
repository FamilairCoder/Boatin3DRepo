using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLookAt : MonoBehaviour
{
    public GameObject player;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < dist)
        {
            var dir = player.transform.position - transform.position;
            dir.y = 0;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(-dir), .1f);

        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,0), .1f);
        }
    }
}
