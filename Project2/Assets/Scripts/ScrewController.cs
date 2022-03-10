using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewController : MonoBehaviour
{
    public GameObject screw;
    GameObject screws;

    void Start()
    {
        screws = GameObject.FindWithTag("Screws");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Drill"))
        {
            screw.SetActive(false);

            // call the screwOpened function from the Screws game object
            screws.GetComponent<ScrewsController>().screwOpened();
        }
    }
}
