using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {
    public Transform target;
    NavMeshAgent agent;
    float speed = 0.05f;
    // Use this for initialization
    void Start () {
   //     agent = GetComponent<NavMeshAgent>();

		
	}
	
	// Update is called once per frame
	void Update () {
        //     agent.SetDestination(target.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);
        transform.position += transform.forward * speed;
	}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag=="Shot")
    //    {
    //        Debug.Log("Hit");
    //    }
    //}
}
