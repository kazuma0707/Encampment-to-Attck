using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public static Enemy instance = null;

    public Transform target;
    float speed = 0.05f;

    private void Awake()
    {
        Enemy.instance = this;

    }
    // Use this for initialization
    void Start()
    {
    }
    void Move()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);
        transform.position += new Vector3(0, 0, 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        Move();

        Vector3 PlayerEncampPos = transform.position - PlayerEncampment.Instance.GetPos();
        if (PlayerEncampPos.z < 0)
        {
            Debug.Log("go-ru");

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shot")
        {
            Debug.Log("HIT");

        }
    }

}

