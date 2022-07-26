using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloweyScript : MonoBehaviour, IInterAction
{
    DialogManager dialogManager;
    public string[] converstation;
    int converstationIndex = 0;
    Animator animator;
    public BoxCollider2D trigger;
    

    void Start()
    {
        dialogManager = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogManager>();
        animator = GetComponent<Animator>();
        trigger = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isUp", true);
        }

    }

    public bool ReAction()
    {
        if(converstationIndex < converstation.Length)
        {
            Talk();
            return true;
        }
        else
        {
            animator.SetBool("isDown", true);
            dialogManager.SetActiveDialog(false);
            return false;
        }
        
    }

    public void Talk()
    {
        animator.SetBool("isTalk", true);
        dialogManager.SetActiveDialog(true);
        dialogManager.SetDialogContent(converstation[converstationIndex]);
        converstationIndex++;

    }

    public void TalkEnd()
    {
        Destroy(gameObject);
    }

}

