using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloweyScript : MonoBehaviour, IInterAction
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isStart", true);
        }

    }

    public void ReAction()
    {
        
    }
}
