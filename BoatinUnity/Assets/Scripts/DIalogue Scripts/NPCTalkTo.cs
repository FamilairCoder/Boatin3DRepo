using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalkTo : MonoBehaviour
{
    public GameObject player, questmark, dialoguemark, createdmark, diapoint;
    public bool startedtalking;
    public float talkdist, questamount, questtotal;
    public bool hasquest, hasdialogue, fishquest;//, homelessguy;
    public string questtext; 
    public List<string> dialogue, relevantdialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasquest && createdmark == null)
        {
            createdmark = Instantiate(questmark);
            createdmark.GetComponent<NPCMark>().NPC = diapoint;
        }
        else if (hasdialogue && createdmark == null)
        {
            createdmark = Instantiate(dialoguemark);
            createdmark.GetComponent<NPCMark>().NPC = diapoint;
        }

        if (Input.GetKeyDown(KeyCode.E) && !DialogueBox.active && !startedtalking && Vector3.Distance(player.transform.position, transform.position) < talkdist)
        {

            /*if (homelessguy) { DialogueBox.homelessguy = true; }*/
            if (hasquest)
            {
                DialogueBox.text = questtext;
                DialogueBox.quest = true;
                DialogueBox.questamount = questamount;
                DialogueBox.questtotal = questtotal;
                DialogueBox.NPC = gameObject;
                if (fishquest) { DialogueBox.catchfish = true; }

            }
            else if (hasdialogue)
            {
                DialogueBox.text = relevantdialogue[Random.Range(0, relevantdialogue.Count)];
                hasdialogue = false;
                Destroy(createdmark);
            }
            else
            {
                DialogueBox.text = dialogue[Random.Range(0, dialogue.Count)];
            }
            
            DialogueBox.active = true;
            startedtalking = true;
        }
        if (startedtalking && Vector3.Distance(player.transform.position, transform.position) > talkdist)
        {
            startedtalking = false;
            DialogueBox.active = false;
        }
    }
}
