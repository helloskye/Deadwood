using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marilou : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;
  [SerializeField] public GameObject dialogueButton2;

  void Update()
  {
    if (QuestLog.TalkedToCorrine == false)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton1.SetActive(true);
      }
      else
      {
        dialogueButton1.SetActive(false);
      }
    }
    if (QuestLog.TalkedToCorrine == true)
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
