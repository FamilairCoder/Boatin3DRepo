using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueChoiceBox : MonoBehaviour, IPointerClickHandler
{
    public bool forward, backward;
    public GameObject dialoguebox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        var box = dialoguebox.GetComponent<DialogueBox>();
        if (forward)
        {
            if (DialogueBox.homelessguy)
            {
                if (!QuestManager.questing)
                {
                    if (box.progress != 3) { box.progress += 1; }

                    else
                    {
                        QuestManager.fishquest = true;
                        QuestManager.questing = true;
                        QuestManager.startedfish = true;
                        QuestManager.totalamount = 3;
                        QuestManager.amount = 0;
                        box.progress = 0;
                        DialogueBox.homelessguy = false;
                    }
                }
                else
                {
                    if (box.progress != 3) { box.progress += 1; }

                    else
                    {
                        QuestManager.fishquest = true;
                        QuestManager.questing = true;
                        QuestManager.startedfish = true;
                        QuestManager.totalamount = 3;
                        QuestManager.amount = 0;
                        box.progress = 0;
                        DialogueBox.homelessguy = false;
                    }
                }
            }
            
            
        }
        if (backward)
        {
            box.progress = 0;
            DialogueBox.homelessguy = false;
        }
    }

  


}
