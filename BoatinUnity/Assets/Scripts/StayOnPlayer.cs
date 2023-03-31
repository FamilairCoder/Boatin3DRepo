using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnPlayer : MonoBehaviour
{
    public GameObject player;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = player.transform.position.x;
        var y = 5.2f;
        var z = player.transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
