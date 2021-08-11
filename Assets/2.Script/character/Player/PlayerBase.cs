using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float speed;
    [SerializeField] private int walkcount;
    private int currentwalkcount = 0;
    private bool walk = true;
    private float x, y;
    
    void Start()
    {
        
    }
    void Update()
    {
        Move();
    }
    private void Move()
    {
        
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            if (walk)
            {
                walk = false;
                StartCoroutine(MoveCount());
            }
        }
    }
    private IEnumerator MoveCount()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        if (y != 0)
            x = 0;
        RaycastHit2D hit;
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(x * 1, y * 1);

        hit = Physics2D.Linecast(start, end, layerMask);
        if (hit.transform != null)
        {
            walk = true;
            yield break;
        }
        while (walkcount > currentwalkcount)
        {
            transform.Translate(x * (1 / (float)walkcount), y * (1 / (float)walkcount), transform.position.z);
            currentwalkcount++;
            yield return new WaitForSeconds(speed);
        }
        currentwalkcount = 0;
        walk = true;
    }
}
