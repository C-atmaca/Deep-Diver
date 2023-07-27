using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    //Singleton player manager �rne�i
    public static PlayerStateManager Instance;

    //Player�n hangi evrede oldu�unu g�steren enum
    public PlayerState CurrentState;
    /*
     * Player�n hangi evrede oldu�unu ��renmek isteyen
     * script i�inde
     * 
     * OnEnable()
     * {
     *      PlayerStateManager.OnPlayerStateChanged += Yap�lacakFonksiyon()
     * }
     * OnDisable()
     * {
     *   PlayerStateManager.OnPlayerStateChanged -= Yap�lacakFonksiyon()
     *  }
     *  
     *  �eklinde hangi evrede oldu�u bilgisini al�p ona g�re i�lem yapabilir
     * */


    //Yine ayn� �ekilde bu bilginin iletimini sa�layan event burda
    public static event Action<PlayerState> OnPlayerStateChanged;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdatePlayerState(PlayerState newState)
    {
        CurrentState = newState;

        //Player manager�n state g�re yapmas�n� istedi�imiz
        //i�lemler buraya

        switch (newState)
        {
            case PlayerState.Swiming:
                break;
            case PlayerState.Walking:
                break;
            case PlayerState.Fishing:
                break;
            case PlayerState.Idle:
                break;
            default:
                break;
        }

        //State de�i�ti�i zaman eventi tetikleyerek
        //dinleyen t�m scriptlere bilgi verir
        OnPlayerStateChanged?.Invoke(newState);
    }
}

//Akl�n�za gelen farkl� stateleri buraya ekleyebilirsiniz
public enum PlayerState
{
    Swiming,
    Walking,
    Fishing,
    Idle,
}