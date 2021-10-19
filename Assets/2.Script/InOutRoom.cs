using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOutRoom : MonoBehaviour
{
    [SerializeField]
    private GameObject onRoom,offRoom,player = null;
    private CameraMove cameraMove = null;
    private void Start() {
        cameraMove = FindObjectOfType<CameraMove>();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player")
        {
            offRoom.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
            onRoom.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            cameraMove.CameraPosition(onRoom.transform);
            Debug.Log("in");
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player")
        {
            offRoom.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            onRoom.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
            cameraMove.CameraPosition(player.transform);
            Debug.Log("out");
        }
    } 
}
