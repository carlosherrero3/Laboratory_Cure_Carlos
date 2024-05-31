using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serwefrwase : MonoBehaviour
{
    [SerializeField] private float vel;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 mov;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        mov = new Vector2(x, y).normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mov * vel * Time.deltaTime);
    }
}