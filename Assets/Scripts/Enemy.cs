using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && hurtTimer < 0)
        {
            other.GetComponent<Character>().TakeDamage(collisionDamage);
            hurtTimer = 0.5f;
        }
    }
    protected void Update()
    {
        hurtTimer -= Time.deltaTime;
        if (health < 0)
        {
            Destroy(gameObject);
        }
        if (hurted)
        {
            float g = Mathf.MoveTowards(spriteRenderer.color.g, 1.0f, 1.75f * Time.deltaTime);
            float b = Mathf.MoveTowards(spriteRenderer.color.b, 1.0f, 1.75f * Time.deltaTime);
            spriteRenderer.color = new Color(1.0f, g, b, 1.0f);
            if (g == 1.0f && b == 1.0f)
            {
                hurted = false;
            }
        }
    }
    public void TakeDamage(int damage)
    {
        spriteRenderer.color = new Color(1.0f, 0.5f, 0.5f, 1.0f);
        health -= damage;
        hurted = true;
    }
    public float hurtTimer;
    public int collisionDamage = 1;
    public int health;
    public bool hurted;
    public SpriteRenderer spriteRenderer;
}