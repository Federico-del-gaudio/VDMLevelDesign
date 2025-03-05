using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorscript : MonoBehaviour
{
    private Animator Dooranim;
    void Start()
    {
        Dooranim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Dooranim.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Dooranim.SetTrigger("Closed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
