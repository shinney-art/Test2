using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takedamage(float damage) 
    {
        hp -= damage
        if (hp <= 0) 
        {
           //ded
        }
    }
}
