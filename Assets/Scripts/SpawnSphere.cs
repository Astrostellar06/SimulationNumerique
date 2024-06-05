using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;

    public void Spawn()
    {
        Instantiate(spherePrefab, this.transform.position, Quaternion.identity);
    }
}
