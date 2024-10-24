using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flybot : MonoBehaviour
{
    public float speed;
    public float coolDown;
    private float coolDownTimer;
    private float destroyTimer;
    public bool isDead;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Animator>().Play("Flybot");
        destroyTimer = 13;
        coolDownTimer = coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        destroyTimer -= Time.deltaTime;
        if (destroyTimer < 0)
        {
            Destroy(gameObject);
        }
        coolDownTimer -= Time.deltaTime;
        if (coolDownTimer < 0 && !isDead)
        {
            GameObject b = Instantiate(bullet, transform.position, Quaternion.identity);
            b.GetComponent<EnemyBullet>().angle = 90;
            coolDownTimer = coolDown;
        }
    }

    public void GameDestroyobject()
    {
        Destroy(gameObject);
    }
}
