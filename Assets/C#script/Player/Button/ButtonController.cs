﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : Button {
    ButtonObjectName ButtonName;
    public GameObject Aitem;
    Vector3 PlayerPos;//後々にどこかで管理する
    private void Start()
    {
        ButtonName = gameObject.AddComponent<ButtonObjectName>();
    }

    protected override void OnClick(string objectName)
    {
        {
            if (ButtonName.SetObjectName(ButtonObjectName.BUTTON_ID.SiledButton).Equals(objectName))
            {
                this.SiledButtonClick();
            }
            else if (ButtonName.SetObjectName(ButtonObjectName.BUTTON_ID.AttckButton).Equals(objectName))
            {
                this.AttckButtonClick();
            }
            else if (ButtonName.SetObjectName(ButtonObjectName.BUTTON_ID.MetastasisButton).Equals(objectName))
            {
                this.MetastasisButtonClick();
            }
        }

    }

    private void SiledButtonClick()
    {
        Debug.Log("SiledButton Click");
        this.PlayerPos = GameObject.Find("Player").transform.position;//ファインドを使わないやり方にする

        Instantiate(Aitem, new Vector3(PlayerPos.x, PlayerPos.y, PlayerPos.z + 5), new Quaternion(0, 0, 0, 0));

    }
    private void AttckButtonClick()
    {
        Debug.Log("AttckButtonClick");
    }
    private void MetastasisButtonClick()
    {
        Debug.Log("MetastasisButtonClick");
    }


}
