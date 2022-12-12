using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrine : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;
  [SerializeField] public GameObject dialogueButton2;

  void Update()
  {
    if (QuestLog.WitchQuestComplete == false && Inventory.HasWitheredFlower == false)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        QuestLog.TalkedToCorrine = true;
        dialogueButton1.SetActive(true);
      }
      else
      {
        dialogueButton1.SetActive(false);
      }
    }

    if (QuestLog.WitchQuestComplete == true && Inventory.HasWitheredFlower == true)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton2.SetActive(true);
      }
      else
      {
        dialogueButton2.SetActive(false);
      }
    }
  }
}
