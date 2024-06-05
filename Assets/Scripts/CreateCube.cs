using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class CreateCube : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    private bool isPrimaryPressed = false;

    void Update()
    {
        if (InputManager.PrimaryPressed && !isPrimaryPressed)
            Instantiate(cubePrefab, Camera.main.transform.position + Camera.main.transform.forward * 5, transform.rotation);

        isPrimaryPressed = InputManager.PrimaryPressed;
    }
}
