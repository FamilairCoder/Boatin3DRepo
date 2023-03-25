using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    public GameObject textbox, choicebox1, choicebox2;
    public static bool active = false, homelessguy = false;
    public float progress = 0;
    HeaderAttribute HomelessMan;
    public List<string> homelesstexts;
    public List<string> homelesschoices1;
    public List<string> homelesschoices2;
    
    public List<string> homelessquestfulltexts;
    public List<string> homelessquestfullchoices1;
    public List<string> homelessquestfullchoices2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (homelessguy)
        {
            Activate();
            if (!QuestManager.questing)
            {
                QuestTexts(homelesstexts, homelesschoices1, homelesschoices2);
            }
            else
            {
                QuestTexts(homelessquestfulltexts, homelessquestfullchoices1, homelessquestfullchoices2);
            }
        }
        else
        {
            Deactivate();
            active = false;
            progress = 0;
        }
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
