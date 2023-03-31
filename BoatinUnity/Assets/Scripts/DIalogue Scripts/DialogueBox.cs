using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    public GameObject textbox, choicebox1, choicebox2;
    public static bool active = false, quest, catchfish;
    public static float questamount, questtotal;
    public float progress = 0;

    public static GameObject NPC;
    public static string text;

    public List<string> homelesstexts;
    public List<string> homelesschoices1;
    public List<string> homelesschoices2;
    
    public List<string> homelessquestfulltexts;
    public List<string> homelessquestfullchoices1;
    public List<string> homelessquestfullchoices2;
    
    public List<string> homelessquestdone;
    public List<string> homelessquestdonechoices1;
    public List<string> homelessquestdonechoices2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            Activate();
            if (quest)
            {
                choicebox1.GetComponent<TextMeshProUGUI>().text = "Accept";
                choicebox2.GetComponent<TextMeshProUGUI>().text = "Decline";
            }
            else
            {
                choicebox1.GetComponent<TextMeshProUGUI>().text = "Cool";
                choicebox2.GetComponent<TextMeshProUGUI>().text = "Ok";
            }
            textbox.GetComponent<TextMeshProUGUI>().text = text;
        }
        else
        {
            Deactivate();
            quest = false;
            catchfish = false;
        }

 /*       if (homelessguy)
        {
            Activate();
            if (!QuestManager.didhomeless)
            {
                if (!QuestManager.questing)
                {

                    QuestTexts(homelesstexts, homelesschoices1, homelesschoices2);
                }

                if (QuestManager.questing)
                {
                    if (!QuestManager.fishquest)
                    {

                        QuestTexts(homelessquestfulltexts, homelessquestfullchoices1, homelessquestfullchoices2);
                    }
                    if (QuestManager.fishquest)
                    {
                        if (QuestManager.amount >= QuestManager.totalamount)
                        {
                            QuestTexts(homelessquestdone, homelessquestdonechoices1, homelessquestdonechoices1);

                        }

                        if (QuestManager.amount < QuestManager.totalamount)
                        {
                            QuestTexts(homelessquestfulltexts, homelessquestfullchoices1, homelessquestfullchoices2);
                        }
                    }
                }
            }
            if (QuestManager.didhomeless)
            {
                QuestTexts(homelessquestdone, homelessquestdonechoices1, homelessquestdonechoices1);
            }
        }
        else
        {
            Deactivate();
            active = false;
            progress = 0;
        }*/
    }

    void Activate()
    {

        transform.localPosition = Vector3.Lerp(transform.localPosition, new(0, -350, 0), .1f);
    }
    void Deactivate()
    {

        transform.localPosition = Vector3.Lerp(transform.localPosition, new(0, -800, 0), .1f);
    }


    void QuestTexts(List<string> texts, List<string> choices1, List<string> choices2)
    {
        textbox.GetComponent<TextMeshProUGUI>().text = texts[(int)progress];
        choicebox1.GetComponent<TextMeshProUGUI>().text = choices1[(int)progress];
        choicebox2.GetComponent<TextMeshProUGUI>().text = choices2[(int)progress];
    }

}
