using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator animator;
    public float inputX;
    public float inputY;
    // Start is called before the first frame update
    void Start()
    {
        animator= this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX= Input.GetAxis("Horizontal");
        animator.SetFloat("inputX",inputX);
        inputY= Input.GetAxis("Vertical");
        animator.SetFloat("inputY",inputY);
    }
}
