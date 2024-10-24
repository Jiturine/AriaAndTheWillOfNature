using Myd.Platform;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    public float angle;
    private float timer;

    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = 10;
    }


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Quaternion.Euler(0, 0, angle) * new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
