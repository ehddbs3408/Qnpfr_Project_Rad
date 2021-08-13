using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffRoom : MonoBehaviour
{
    [SerializeField] private GameObject OutRoom;
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            OutRoom.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
            spriteRenderer.color = new Color(0, 0, 0, 0);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            OutRoom.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            spriteRenderer.color = new Color(0, 0, 0, 1);
        }
    }
}
