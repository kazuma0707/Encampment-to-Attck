//__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/
//! @file   Button.cs
//! @brief ボタンの基底クラス
//!
//! @date   日付		2017/10/25
//!
//! @author 制作者名	森一真
//__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Button : MonoBehaviour
{
    public Button button;


    public void OnClick()
    {
        
        //例外処理
        if(button==null)
        {
            throw new System.Exception("Button instance is null");
        }
        //自身のオブジェクト名を渡す
        button.OnClick(this.gameObject.name);
    }
    protected virtual void OnClick(string objectName)
    {
        Debug.Log("BaseButton");
    }

}
