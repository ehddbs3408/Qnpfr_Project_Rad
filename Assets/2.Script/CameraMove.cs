using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    private Vector3 targetPosition;
    private bool isRoom = false;
    
    
    private void Update()
    {
        if (isRoom) return;
        CameraMoving();
    }
    private void CameraMoving()
    {
        targetPosition = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        transform.position = new Vector3(targetPosition.x, targetPosition.y, -10f);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Room"))
        {
            isRoom = true;
            transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, -10f);
            Debug.Log("asd");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isRoom = false;
        Debug.Log("grs");
    }
}
