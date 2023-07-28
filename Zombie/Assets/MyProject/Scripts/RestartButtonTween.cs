using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class RestartButtonTween : MonoBehaviour , IPointerEnterHandler 
{

    Tween shakeAni = default;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("마우스에 올려 두었다.");
        if(shakeAni == null || shakeAni == default)
        {
            shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Harmonic).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }

        //Debug.Log("shakeAni가 비어 있지는 않다");

    }


    //! tween이 kill될때 shakeAni 변수를 비워주는 함수 
    private void DisposeShake()
    {
        shakeAni = default;
        transform.localPosition = Vector3.one;
    }
}
