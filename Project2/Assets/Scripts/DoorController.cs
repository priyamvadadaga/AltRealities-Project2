using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    bool cube1 = false;
    bool cube2 = false;
    bool cube3 = false;
    bool cube4 = false;
    bool cube5 = false;
    bool cube6 = false;
    bool cube7 = false;
    bool cube8 = false;
    bool cube9 = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube1"))
        {
            if(collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube1 = true;
            } 
        }
        if (collision.gameObject.CompareTag("Cube2"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube2 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube3"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube3 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube4"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube4 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube5"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube5 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube6"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube6 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube7"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube7 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube8"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube8 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube9"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube9 = true;
            }
        }

        if(cube1 && cube2 && cube3 && cube4 && cube5 && cube6 && cube7 && cube8 && cube9)
        {
            door.SetActive(false);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube1"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube1 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube2"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube2 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube3"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube3 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube4"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube4 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube5"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube5 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube6"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube6 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube7"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                cube7 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube8"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube8 = true;
            }
        }
        if (collision.gameObject.CompareTag("Cube9"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                cube9 = true;
            }
        }

        if (cube1 && cube2 && cube3 && cube4 && cube5 && cube6 && cube7 && cube8 && cube9)
        {
            door.SetActive(false);
        }
    }
}
