using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffCollider : MonoBehaviour
{
    [SerializeField] private GameObject roomCollider;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        roomCollider.GetComponent<Collider2D>().enabled = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        roomCollider.GetComponent<Collider2D>().enabled = true;
    }
}
