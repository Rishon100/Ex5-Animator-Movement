# Ex5-Animator-Movement

## Aim:
To develop a animator movement for a player using unity.
## Algorithm:
Step 1:
Import necessary models.

Step 2:
Right-click -> Create -> Animator Controller.

Step 3:
Open Animator window, define states (Idle, Run, Jump, etc.).

Step 4:
Use keyframes or Unity's Animation tools to animate transitions between states.

Step 5:
Drag Animator Controller to the GameObject in the Inspector.
## Program:
```
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
```
## Output:
![photo](https://github.com/user-attachments/assets/e6a9072e-5af2-4d89-b5cb-55256947d40d)

## Result:
An animator movement for a player using unity is developed successfully.
