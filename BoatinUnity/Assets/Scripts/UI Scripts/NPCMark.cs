using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMark : MonoBehaviour
{
    public GameObject NPC, Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NPC != null)
        {
            transform.position = NPC.transform.position;
            Vector3 directionToCamera = Camera.transform.position - transform.position;

            transform.rotation = Quaternion.LookRotation(directionToCamera, Vector3.up);

        }
    }
}
