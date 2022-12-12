using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
  public Dialogue dialogue;
  //public bool playerIsClose = false;
  //public static bool dialogueBoxIsOpen;

  public void TriggerDialogue ()
  {
    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
  }

  /*public void DialogueBoxStatusToggle ()
  {
    dialogueBoxIsOpen = true;
  }*/

/*  void Update()
  {
    /*if(playerIsClose == true && Input.GetKeyDown(KeyCode.E))
    {
      TriggerDialogue();
    }*
  }

  private void OnTriggerEnter2D (Collider2D other)
  {
    if (other.CompareTag("Player"))
    {
      playerIsClose = true;
    }
  }

  private void OnTriggerExit2D (Collider2D other)
  {
    if (other.CompareTag("Player"))
    {
      playerIsClose = false;
    }
  }*/
}
