using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("血瓶被"+collision+"吃掉了");
        LunaController lunacontroller = collision.GetComponent<LunaController>();
        lunacontroller.ChangeHealth(1);
        Destroy(gameObject);
    }
    
    
    
}
