using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalkTo : MonoBehaviour
{
    public GameObject player;
    public float talkdist;
    public bool homelessguy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!DialogueBox.active && Vector3.Distance(player.transform.position, transform.position) < talkdist && Input.GetKeyDown(KeyCode.E))
        {

            if (homelessguy) { DialogueBox.homelessguy = true; }
            DialogueBox.active = true;
        }
        if (Vector3.Distance(player.transform.position, transform.position) > talkdist)
        {
            if (homelessguy) { DialogueBox.homelessguy = false; }
        }
    }
}
