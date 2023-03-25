using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassAppear : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (QuestManager.startedfish && GetComponent<SpriteRenderer>().color.a == 0)
            {
                var spr = GetComponent<SpriteRenderer>().color;
                var sprchild = transform.GetChild(0).GetComponent<SpriteRenderer>().color;
                GetComponent<SpriteRenderer>().color = new(spr.r, spr.g, spr.b, 255);
                transform.GetChild(0).GetComponent<SpriteRenderer>().color = new(sprchild.r, sprchild.g, sprchild.b, 255);
            }
            else if (!QuestManager.startedfish || GetComponent<SpriteRenderer>().color.a != 0)
            {
                var spr = GetComponent<SpriteRenderer>().color;
                var sprchild = transform.GetChild(0).GetComponent<SpriteRenderer>().color;
                GetComponent<SpriteRenderer>().color = new(spr.r, spr.g, spr.b, 0);
                transform.GetChild(0).GetComponent<SpriteRenderer>().color = new(sprchild.r, sprchild.g, sprchild.b, 0);
            }
        }
    }
}
