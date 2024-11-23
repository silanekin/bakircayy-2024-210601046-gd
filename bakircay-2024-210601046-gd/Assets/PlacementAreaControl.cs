using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementAreaControl : MonoBehaviour
{
    private GameObject placedObject = null; // Placement alan�na yerle�tirilen nesneyi takip eder
    private Renderer placementAreaRenderer;

    void Start()
    {
        placementAreaRenderer = GetComponent<Renderer>();
        if (placementAreaRenderer != null)
        {
            placementAreaRenderer.material.color = Color.red; // Ba�lang��ta k�rm�z�
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (placedObject == null && other.CompareTag("Draggable"))
        {
            placedObject = other.gameObject;
            Debug.Log(placedObject.name + " Placement Area'ya yerle�tirildi!");

            if (placementAreaRenderer != null)
            {
                placementAreaRenderer.material.color = Color.green; // Alan dolu
            }
        }
        else if (placedObject != null && other.CompareTag("Draggable"))
        {
            Debug.Log("Placement Area dolu! " + other.name + " reddediliyor.");
            RejectObject(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (placedObject == other.gameObject)
        {
            Debug.Log(other.name + " Placement Area'dan ��kar�ld�!");
            placedObject = null;

            if (placementAreaRenderer != null)
            {
                placementAreaRenderer.material.color = Color.red; // Alan bo�
            }
        }
    }

    void RejectObject(GameObject obj)
    {
        obj.transform.position += new Vector3(2f, 0f, 0f); // Fazla nesneyi d��ar� ta��
        Debug.Log(obj.name + " Placement Area'dan ��kar�ld�!");
    }
}
