using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour {
    #region Variable
    private State StateVariable;//状態を表す変数
    #endregion

    #region Event
    //ステートの変更
    public virtual void ChangeState(State SetState) { StateVariable = SetState; }
    //動作の処理
    public virtual void Excute() { }
    #endregion
}
public class Move : State
{
    State state;
    [SerializeField]
    private Joystick Joystick = null;
    private const float Speed = 0.1f;
    public State GetInstance()
    {
        if(!state)
        {
            state = new Move();
        }
        return state;
    }
    public override void Excute()
    {
        base.Excute();

    }

}

