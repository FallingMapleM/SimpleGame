using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("血瓶被"+collision+"吃掉了");
        LunaController lunacontroller = collision.GetComponent<LunaController>();
        lunacontroller.ChangeHealth(-1);
        
    }
}
