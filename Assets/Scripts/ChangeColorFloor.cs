using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorFloor : MonoBehaviour
{
    [SerializeField] private GameObject floor;

    public void ChangeColor()
    {
        floor.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
