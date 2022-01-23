using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCanvas : MonoBehaviour
{
    public CharDressController charDressController;
    public bool bool1 = false;
    public bool bool2 = false;
    public GameObject twoStar;
    public GameObject threeStar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(bool1 || bool2)
            {
                twoStar.SetActive(true);
            }
            if(bool1 && bool2)
            {
                threeStar.SetActive(true);
            }
        }
    }
}
