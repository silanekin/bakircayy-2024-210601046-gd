using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 offset;
    private float zCoordinate;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true; // Ba�lang��ta fizik motoru etkisiz
        }
    }

    void OnMouseDown()
    {
        if (rb == null) return;

        // Fare ile t�klanan noktan�n do�ru �ekilde al�nmas�
        zCoordinate = Camera.main.WorldToScreenPoint(transform.position).z;

        // Fareyle nesne aras�ndaki mesafeyi hesaplama
        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseDrag()
    {
        if (rb == null) return;

        // Nesneyi fareyle s�r�kleme
        rb.isKinematic = true; // S�r�kleme s�ras�nda fizik etkisi yok
        transform.position = GetMouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        if (rb == null) return;

        rb.isKinematic = false; // Fare b�rak�ld���nda fizik etkisi tekrar aktif
    }

    private Vector3 GetMouseWorldPosition()
    {
        // Fare pozisyonunu d�nya pozisyonuna �evirme
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoordinate; // Z eksenini koruyarak hesaplama
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
