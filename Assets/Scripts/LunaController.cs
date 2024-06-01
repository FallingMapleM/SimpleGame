using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LunaController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float moveSpeed = 15;
    public int maxHealth = 5;
    private int currentHealth;
    
   // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponentInParent<Rigidbody2D>();
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector2 position = transform.position;
        position.x = position.x + moveSpeed * horizontal * Time.deltaTime;
        position.y = position.y + moveSpeed * vertical * Time.deltaTime;
        // transform.position = position;
        rigidbody2d.MovePosition(position);
    }

    private void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth+"/"+maxHealth);
    }
}
