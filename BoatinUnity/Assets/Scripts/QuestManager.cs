using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class QuestManager : MonoBehaviour
{
    public ParticleSystem questparticle;
    public GameObject questtext, questbar;
    public static bool fishquest, questing, startedfish, didhomeless;
    public string fishquesttext;
    public static float amount = 0, totalamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalamount > 0 && amount >= totalamount) 
        {
            fishquest = false;
            amount = 0;
            totalamount = 0;
            DialogueBox.NPC.GetComponent<NPCTalkTo>().hasquest = false;
            Destroy(DialogueBox.NPC.GetComponent<NPCTalkTo>().createdmark);
            questparticle.Play();
        }
        if (fishquest) 
        {

            GetComponent<TextMeshProUGUI>().text = fishquesttext;
            questtext.GetComponent<TextMeshProUGUI>().text = amount + "/" + totalamount + " fish caught";
            questbar.GetComponent<Image>().enabled = true;
        }
        else 
        { 
            GetComponent<TextMeshProUGUI>().text = ""; 
            questtext.GetComponent<TextMeshProUGUI>().text = "";
            questbar.GetComponent<Image>().enabled = false;
        }
    }
}
