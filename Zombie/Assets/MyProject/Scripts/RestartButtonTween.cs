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
        Debug.Log("���콺�� �÷� �ξ���.");
        if(shakeAni == null || shakeAni == default)
        {
            shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Harmonic).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }

        //Debug.Log("shakeAni�� ��� ������ �ʴ�");

    }


    //! tween�� kill�ɶ� shakeAni ������ ����ִ� �Լ� 
    private void DisposeShake()
    {
        shakeAni = default;
        transform.localPosition = Vector3.one;
    }
}
