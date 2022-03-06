using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewController : MonoBehaviour
{
    public GameObject screw;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Drill"))
        {
            screw.SetActive(false);
        }
    }
}
