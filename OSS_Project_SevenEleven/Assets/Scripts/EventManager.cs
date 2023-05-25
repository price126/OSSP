using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    private Animator animator;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Enter", true);
    }



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
