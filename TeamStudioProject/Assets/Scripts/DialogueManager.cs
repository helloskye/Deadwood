using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
  public TextMeshProUGUI nameText;
  public TextMeshProUGUI dialogueText;

  public Animator animator;

  private Queue<string> sentences;
  private Queue<string> names;
    // Start is called before the first frame update
    void Start()
    {
      sentences = new Queue<string>();
      names = new Queue<string>();
    }

  public void StartDialogue(Dialogue dialogue)
  {
    animator.SetBool("IsOpen", true);
    //Debug.Log("Starting conversation with " + dialogue.name);
    //nameText.text = dialogue.name;

    sentences.Clear();
    names.Clear();
    foreach (string name in dialogue.names)
    {
      names.Enqueue(name);
    }
    DisplayNextName();
    foreach (string sentence in dialogue.sentences)
    {
      sentences.Enqueue(sentence);
    }
    DisplayNextSentence();
  }

    public void DisplayNextName()
    {
      if (names.Count == 0)
      {
        EndDialogue();
        return;
      }

      string name = names.Dequeue();
      nameText.text = name;
    }

  public void DisplayNextSentence()
  {
    if (sentences.Count == 0)
    {
      EndDialogue();
      return;
    }

    string sentence = sentences.Dequeue();
    StopAllCoroutines();
    StartCoroutine(TypeSentence(sentence));
    //dialogueText.text = sentence;
    //Debug.Log(sentence);
  }


  IEnumerator TypeSentence (string sentence)
  { //Adds letter one at a type
    dialogueText.text = "";
    foreach (char letter in sentence.ToCharArray())
    {
      dialogueText.text += letter;
      yield return null;
    }
  }

  public void EndDialogue()
  {
    animator.SetBool("IsOpen", false);
    Debug.Log("End of conversation.");
  }
}
