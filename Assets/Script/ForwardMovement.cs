

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : Movement
{
    public GameObject resCanvas;
 

    private void FixedUpdate()
    {
        

        if (Input.GetMouseButton(0))
        {
            Move(Vector3.forward);
            Debug.Log("held");
            animator.SetBool("Walk", true);

        }
        else
        {
            animator.SetBool("Walk", false);
            Debug.Log("no held");

        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FinalAnimTrigger")
        {
           
            _speed = 0;
        }
        if (other.tag == "ObsHor")
        {
            resCanvas.SetActive(true);
            animator.SetBool("Trip", true);
            _speed = 0;
        }
        if (other.tag == "ObsVer")
        {
            resCanvas.SetActive(true);
            animator.SetBool("Fall", true);
            _speed = 0;
        }
    }

    private void Update()
    {
      
    }


}