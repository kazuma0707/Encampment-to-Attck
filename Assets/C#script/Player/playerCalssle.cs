//攻撃クラス
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCalssle : MonoBehaviour {
    #region variable

    public GameObject miniPlayer;//ミニプレイヤーのプレファブ
    private GameObject[] miniplayers;//ミニプレイヤーを保存する配列
    private int MaxNum=10;//生成数
    private float currentTime;//待ち時間
    private float CreateTime;//生成するまでの時間
    private int CreatedPlayesNum;//生成した数

    private GameObject TargetEnemy;


    #endregion

    //初期化
    private void Awake()
    {
        currentTime = 0.0f;
        CreateTime = 5.0f;
        miniplayers = new GameObject[MaxNum];
        TargetEnemy = Enemy.instance.gameObject;

    }

    // Use this for initialization
    void Start ()
    {

		
	}
    
	
	// Update is called once per frame
	void Update () {
        //エネミーの座標
        Vector3 position = Enemy.instance.transform.position - transform.position;
        
        //MiniPlayerの生成
        if (CreatedPlayesNum<MaxNum)
        {
            //一定時間の計算
            currentTime += Time.deltaTime;
            //10秒たったら生成
            if(currentTime>CreateTime)
            {
                CreatePlayer();//生成部分
            }
        }
        else
        {
            Destroy(gameObject);
        }

        
	}

    void CreatePlayer( )
    {
        Vector3 position = Enemy.instance.transform.position;
        for (int i=0;i<miniplayers.Length;i++)
        {
            if(miniplayers[i]==null)
            {
                miniplayers[i] = GameObject.Instantiate(miniPlayer,transform.position,transform.rotation);

                CreatedPlayesNum++;
                currentTime = 0.0f;
                break;
            }
        }
    }
}
