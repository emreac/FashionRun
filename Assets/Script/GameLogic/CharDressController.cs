using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharDressController : MonoBehaviour
{
    public GameObject mainChest;
    public GameObject blueSkirt;
    public GameObject redSkirt;
    public GameObject blueShirt;
    public GameObject yellowShirt;
    public GameObject brownHat;
    public GameObject aquaHat;

    //HairStuff
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;

    public bool bool1 = false;
    public bool bool2 = false;

    public GameObject twoStar;
    public GameObject threeStar;
    public GameObject reStart;

    public GameObject confetti;

    public AudioSource goodSound;
    public AudioSource badSound;
    public AudioSource finalSound;



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
        //level 1

        if (other.tag == "BrownHat")
        {

            ball1.SetActive(false);
            ball2.SetActive(false);
            ball3.SetActive(false);
            ball4.SetActive(false);
            goodSound.Play();
         
            brownHat.SetActive(true);
        }
        if (other.tag == "AquaHat")
        {
            ball1.SetActive(false);
            ball2.SetActive(false);
            ball3.SetActive(false);
            ball4.SetActive(false);
            badSound.Play();

            aquaHat.SetActive(true);
        }

        if (other.tag == "BlueSkirt")
        {
            goodSound.Play();
            bool1 = true;
            blueSkirt.SetActive(true);
        }
        if (other.tag == "RedSkirt")
        {
            badSound.Play();
            redSkirt.SetActive(true);
        }
        if (other.tag == "BlueShirt")
        {
            badSound.Play();
            mainChest.SetActive(false);
            blueShirt.SetActive(true);
        }
        if (other.tag == "YellowShirt")
        {
            goodSound.Play();
            bool2 = true;
            mainChest.SetActive(false);
            yellowShirt.SetActive(true);
        }



        if (other.tag == "FinalAnimTrigger")
        {
            if (bool1 || bool2)
            {
                twoStar.SetActive(true);
                confetti.SetActive(true);
            }
            if (bool1 && bool2)
            {
                confetti.SetActive(true);
                threeStar.SetActive(true);
            }
            if (bool1==false && bool2==false)
            {
                reStart.SetActive(true);
            }

        }
    }
}
