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
            rb.isKinematic = true; // Baþlangýçta fizik motoru etkisiz
        }
    }

    void OnMouseDown()
    {
        if (rb == null) return;

        // Fare ile týklanan noktanýn doðru þekilde alýnmasý
        zCoordinate = Camera.main.WorldToScreenPoint(transform.position).z;

        // Fareyle nesne arasýndaki mesafeyi hesaplama
        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseDrag()
    {
        if (rb == null) return;

        // Nesneyi fareyle sürükleme
        rb.isKinematic = true; // Sürükleme sýrasýnda fizik etkisi yok
        transform.position = GetMouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        if (rb == null) return;

        rb.isKinematic = false; // Fare býrakýldýðýnda fizik etkisi tekrar aktif
    }

    private Vector3 GetMouseWorldPosition()
    {
        // Fare pozisyonunu dünya pozisyonuna çevirme
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoordinate; // Z eksenini koruyarak hesaplama
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
