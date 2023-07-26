using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton game manager �rne�i
    public static GameManager Instance;
    
    //Oyunun hangi evrede oldu�unu g�steren enum
    public GameState CurrentState;
    /*
     * Oyunun hangi evrede oldu�unu ��renmek isteyen
     * script i�inde
     * 
     * OnEnable()
     * {
     *      GameManager.OnStateChanged += Yap�lacakFonksiyon()
     * }
     * OnDisable()
     * {
     *   GameManager.OnStateChanged -= Yap�lacakFonksiyon()
     *  }
     *  
     *  �eklinde hangi evrede oldu�u bilgisini al�p ona g�re i�lem yapabilir
     * */


    //Yine ayn� �ekilde bu bilginin iletimini sa�layan event burda
    public static event Action<GameState> OnStateChanged;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(GameState newState)
    {
        CurrentState = newState;

        //Game manager�n state g�re yapmas�n� istedi�imiz
        //i�lemler buraya
        switch (newState)
        {
            case GameState.Diving:
                break;
            case GameState.InSubmarine:
                break;
            case GameState.DrivingSubmarine:
                break;
            default:
                break;
        }

        //State de�i�ti�i zaman eventi tetikleyerek
        //dinleyen t�m scriptlere bilgi verir
        OnStateChanged?.Invoke(newState);
    }
}

//Akl�n�za gelen farkl� stateleri buraya ekleyebilirsiniz
public enum GameState
{
    Diving,
    InSubmarine,
    DrivingSubmarine,
}