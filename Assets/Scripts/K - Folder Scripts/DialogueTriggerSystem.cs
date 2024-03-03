using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerSystem : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManagerSystem>().StartDialog(dialogue);
    }
}
