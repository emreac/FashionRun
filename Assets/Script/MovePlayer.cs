using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Animator animator;
    public float speed;
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
       // transform.Translate(0, 0,speed* Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            Debug.Log("held");
            animator.SetBool("Walk", true);
      
        }
        else
        {
            animator.SetBool("Walk", false);
            Debug.Log("no held");
           
        }
    }


}
