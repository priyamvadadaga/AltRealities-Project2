using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternController : MonoBehaviour
{
    public GameObject block;

    public Color GetBaseColor()
    {
        return block.GetComponent<MeshRenderer>().material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(GetBaseColor() == Color.blue)
        {
            block.GetComponent<MeshRenderer>().material.color = Color.white;
        } else
        {
            block.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
