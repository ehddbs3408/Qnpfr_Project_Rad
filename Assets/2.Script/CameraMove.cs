 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    private Vector3 targetPosition;
    private void Update()
    {
        CameraMoving();
    }
    private void CameraMoving()
    {
        targetPosition = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        transform.position = new Vector3(targetPosition.x, targetPosition.y, -10f);
    }
    public void CameraPosition(Transform changetarget)
    {
        Debug.Log("change");
        target = changetarget;
    }
}
