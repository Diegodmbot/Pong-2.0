using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class Inmigrants : Ball
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal1"))
        {
            GameManager.Instance.Player1Scored();
        }
        else if (collision.gameObject.CompareTag("Goal2"))
        {
            GameManager.Instance.Player2Scored();
        }
        GameManager.Instance.ResetBall();
    }
}
