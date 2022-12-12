using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Santiana : MonoBehaviour
{
  [SerializeField] public DialogueCollider dialogueCollider;
  [SerializeField] public GameObject dialogueButton1;
  [SerializeField] public GameObject dialogueButton11;
  [SerializeField] public GameObject dialogueButton2;//
  [SerializeField] public GameObject dialogueButton3;

  void Update()
  {
    if (QuestLog.TalkedToBethany == false || QuestLog.TalkedToCat == false)
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton1.SetActive(true);
        QuestLog.ThrownOut = true;
      }
      else
      {
        dialogueButton1.SetActive(false);
        QuestLog.ThrownOut = false;
      }

      /*if (QuestLog.ThrownOut == true && dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        //dialogueButton1.SetActive(true);
        //QuestLog.ThrownOut = true;
        SceneManager.LoadScene("WitchHut_OUTSIDE");
      }*/
    }

    /*if (QuestLog.ThrownOut == true && (QuestLog.TalkedToBethany == false || QuestLog.TalkedToCat == false))
    {
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton11.SetActive(true);
      }
      else
      {
        dialogueButton11.SetActive(false);
      }
    }
*/
    if (QuestLog.TalkedToBethany == true && QuestLog.TalkedToCat == true)
    {
      QuestLog.ThrownOut = false;
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton2.SetActive(true);
        QuestLog.PostGame = true;

      }
      else
      {
        dialogueButton2.SetActive(false);
      }
    }

    /*if (QuestLog.TalkedToBethany == true && QuestLog.TalkedToCat == true && Inventory.HasBadge == true && QuestLog.PostGame == true)
    {
      QuestLog.ThrownOut = false;
      if (dialogueCollider.playerIsClose == true && DialogueManager.dialogueIsOpen == false)
      {
        dialogueButton3.SetActive(true);
      }
      else
      {
        dialogueButton3.SetActive(false);
      }
    }*/
  }
}
