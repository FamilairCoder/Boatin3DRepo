using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamObject : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position, .05f);
        transform.rotation = Quaternion.Lerp(transform.rotation, player.transform.rotation, .05f);
    }
}
