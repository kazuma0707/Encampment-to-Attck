using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPlayerShot : MonoBehaviour {

    private GameObject TargetEnemy;
    private void Start()
    {
        TargetEnemy = Enemy.instance.gameObject;
        transform.LookAt(TargetEnemy.transform);
    }

    // Update is called once per frame
    void Update () {
        transform.position += transform.forward * Time.deltaTime *50;
		
	}
    
}
