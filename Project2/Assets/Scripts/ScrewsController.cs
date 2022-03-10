using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewsController : MonoBehaviour
{
    public static int numScrewsOpen = 0;
    private Color alphaColor;
    public static GameObject vent;
    Color color;
    private float timeToFade = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        vent = GameObject.FindWithTag("Vent");
        color = vent.GetComponent<MeshRenderer>().material.color;
        alphaColor = vent.GetComponent<MeshRenderer>().material.color;
        alphaColor.a = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (numScrewsOpen == 4)
        {
            // do something to the vent
            vent.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        
    }

    public void screwOpened()
    {
        numScrewsOpen = numScrewsOpen + 1;
        vent.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

    }
}
