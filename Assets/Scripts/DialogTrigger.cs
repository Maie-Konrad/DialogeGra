using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    [SerializeField] private Dialog dialog; // The dialog to be triggered
    private DialogManager dialogManager; // Reference to the Dialog Manager

    void Start()
    {
        dialogManager = FindObjectOfType<DialogManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dialogManager.StartDialog(dialog);
        }
    }
}
