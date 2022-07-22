using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterJuAn : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Start"))
        {
            Debug.Log(other.gameObject.name);
            myAnimationController.SetBool("starterTrigger", true);
        }
    }

        private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Start"))
        {
            Debug.Log(other.gameObject.name);
            myAnimationController.SetBool("starterTrigger", false);
        }
    }
}
