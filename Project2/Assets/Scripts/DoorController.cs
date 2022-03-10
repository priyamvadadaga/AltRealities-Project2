using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;
    public GameObject c8;
    public GameObject c9;

    private void Update()
    {
        if (c1.GetComponent<MeshRenderer>().material.color == Color.blue && c2.GetComponent<MeshRenderer>().material.color == Color.white && c3.GetComponent<MeshRenderer>().material.color == Color.white && c4.GetComponent<MeshRenderer>().material.color == Color.white && c5.GetComponent<MeshRenderer>().material.color == Color.blue && c6.GetComponent<MeshRenderer>().material.color == Color.white && c7.GetComponent<MeshRenderer>().material.color == Color.white && c8.GetComponent<MeshRenderer>().material.color == Color.blue && c9.GetComponent<MeshRenderer>().material.color == Color.blue)
        {
            door.SetActive(false);
        }
    }
    
}