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
            if (DialogueBox.quest)
            {
                QuestManager.amount = DialogueBox.questamount;
                QuestManager.totalamount = DialogueBox.questtotal;
                QuestManager.fishquest = true;
                QuestManager.startedfish = true;
            }

                DialogueBox.active = false;
            
            /*if (DialogueBox.homelessguy)
            {
                if (QuestManager.didhomeless)
                {
                    if (box.progress != 3) { box.progress += 1; }

                    else
                    {
                        QuestManager.fishquest = false;
                        QuestManager.questing = false;
                        QuestManager.didhomeless = true;
                        QuestManager.totalamount = 3;
                        QuestManager.amount = 0;
                        box.progress = 0;
                        DialogueBox.homelessguy = false;
                    }
                }
                    *//*


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
                                    }*//*

                    if (!QuestManager.questing)
                {

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
            */
            DialogueBox.NPC.GetComponent<NPCTalkTo>().startedtalking = false;
            
        }
        if (backward)
        {
            /*            box.progress = 0;*/
            DialogueBox.NPC.GetComponent<NPCTalkTo>().startedtalking = false;
            DialogueBox.active = false;
        }
    }

  


}
