using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LunaController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    private Vector2 move;
    public float moveScale;
    public float moveSpeed;
    private Vector2 lookDirection = new Vector2 (1, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ÕÊº“ ‰»Î
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("vertical");
        move = new Vector2 (horizontal, vertical);



        Vector2 position = transform.position;
        position = position + moveSpeed * move * Time.fixedDeltaTime;
        rigidbody2d.MovePosition(position);

        //transform.position = position;

        
        
    }
}
