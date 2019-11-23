using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlanet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        switch (other.tag) {
            case "ForestPlanet":
                Application.LoadLevel("ForestPlanet");
                Debug.Log("Enter ForestPlanet");
                break;
        }
    }
}
