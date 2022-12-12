using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockage : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;
  [SerializeField] public GameObject dialogueButton2;
  [SerializeField] public GameObject blockage; //

  void Update()
  {

    if (DialogueManager.dialogueIsOpen == true && QuestLog.ClearedBlockage == true)
    {
      blockage.SetActive(false);
    }

    if (Inventory.HasAxe == true)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton1.SetActive(true);
        QuestLog.ClearedBlockage = true;
      }
      else
      {
        dialogueButton1.SetActive(false);
      }
    }
    else
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
