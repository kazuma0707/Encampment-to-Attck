using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : Button {
    #region variable

    ButtonObjectName ButtonName;//ボタンのオブジェクト名
    [SerializeField]
    private GameObject Shield;//シールドのプレファブ
    [SerializeField]
    private GameObject Attck;//攻撃オブジェのプレファブ
    Vector3 Playerpos;

    bool puchButtonFlag = false;//ボタン押し出し許可フラグ
    private Vector3 allowTime = new Vector3(0, 0, 600);
   public float NowTime;

    #endregion
    private void Start()
    {
        ButtonName = gameObject.AddComponent<ButtonObjectName>();
    }
    private void Update()
    {
        Playerpos = Player.instance.GetPos();//Playerの座標を取得
        if(puchButtonFlag)
        {
            NowTime += 1;
            if(NowTime>allowTime.z)
            {
                Debug.Log("TimeOk");
                puchButtonFlag = false;
                NowTime = 0;
            }
        }

    }
    protected override void OnClick(string objectName)
    {
        if(!puchButtonFlag)
        {

            

            if (ButtonName.GetObjName(ButtonObjectName.BUTTON_ID.SiledButton).Equals(objectName))
            {
                this.SiledButtonClick();
            }
            else if (ButtonName.GetObjName(ButtonObjectName.BUTTON_ID.AttckButton).Equals(objectName))
            {
                this.AttckButtonClick();
            }
            else if (ButtonName.GetObjName(ButtonObjectName.BUTTON_ID.MetastasisButton).Equals(objectName))
            {
                this.MetastasisButtonClick();
            }


            puchButtonFlag = true;
        }

    }

    private void SiledButtonClick()
    {
        Debug.Log("SiledButton Click");
        Instantiate(Shield, new Vector3(Playerpos.x, Playerpos.y, Playerpos.z + 5), new Quaternion(0, 0, 0, 0));

    }
    private void AttckButtonClick()
    {
        Debug.Log("AttckButtonClick");
        Instantiate(Attck, new Vector3(Playerpos.x, Playerpos.y, Playerpos.z + 5), new Quaternion(0, 0, 0, 0));

    }
    private void MetastasisButtonClick()
    {
        Debug.Log("MetastasisButtonClick");
    }


}
