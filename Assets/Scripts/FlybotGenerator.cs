using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    public float coolDown;
    private float timer;
    public float xCenter;
    public float yLength;

    // Start is called before the first frame update
    void Start()
    {
        timer = coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(enemy,new Vector3(xCenter, Random.Range(-yLength, yLength), 0),Quaternion.identity);
            timer = coolDown;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(xCenter, -yLength, 0), new Vector3(xCenter, yLength, 0));
    }
}
