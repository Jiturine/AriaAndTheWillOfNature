using Myd.Platform;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float coolDown;
    private float coolDownTimer;
    public GameObject bullet;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        coolDownTimer = coolDown;
        if (!isDead)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b1 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b2 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b3 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b4 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b5 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b6 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b7 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b8 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b9 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b10 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b11 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b12 = Instantiate(bullet, transform.position, Quaternion.identity);
            b1.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b2.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b3.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b4.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b5.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b6.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b7.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b8.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b9.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b10.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b11.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b12.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (coolDownTimer < 0 && !isDead)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b1 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b2 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b3 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b4 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b5 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b6 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b7 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b8 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b9 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b10 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b11 = Instantiate(bullet, transform.position, Quaternion.identity);
            GameObject b12 = Instantiate(bullet, transform.position, Quaternion.identity);
            b1.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b2.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b3.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b4.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b5.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b6.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b7.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b8.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b9.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b10.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b11.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            b12.GetComponent<EnemyBullet>().angle = Random.Range(-80, 80);
            coolDownTimer = coolDown;
        }
        coolDownTimer -= Time.deltaTime;
    }

    public void GameDestroyobject()
    {
        Destroy(gameObject);
    }
}
