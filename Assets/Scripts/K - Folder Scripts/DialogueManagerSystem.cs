using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerSystem : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogText;
    private Queue<string> dialogs;
  

    void Start()
    {
        dialogs = new Queue<string>();
    }

    public void StartDialog(Dialogue dialogue)
    {

        nameText.text = dialogue.Name;

        dialogs.Clear();

        foreach (string description in dialogue.description)
        {
            dialogs.Enqueue(description);
        }


        DisPlayDialogue();


    }
    public void DisPlayDialogue()
    {
        if (dialogs.Count == 0)
        {
            EndDialogue();
            return;
        }
        string dialog = dialogs.Dequeue();
        dialogText.text = dialog;
    }
    void EndDialogue()
    {


    }
}
