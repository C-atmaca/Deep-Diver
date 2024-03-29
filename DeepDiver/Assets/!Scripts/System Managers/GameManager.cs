using System;

public class GameManager : MonoSingleton<GameManager>
{
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
    public static event Action<GameState> OnGameStateChanged;

    public void UpdateGameState(GameState newState)
    {
        CurrentState = newState;

        //Game manager�n state g�re yapmas�n� istedi�imiz
        //i�lemler buraya
        switch (newState)
        {
            case GameState.Playing:
                break;
            case GameState.Paused:
                break;
            case GameState.GameOver:
                break;
            default:
                break;
        }

        //State de�i�ti�i zaman eventi tetikleyerek
        //dinleyen t�m scriptlere bilgi verir
        OnGameStateChanged?.Invoke(newState);
    }
}

//Akl�n�za gelen farkl� stateleri buraya ekleyebilirsiniz
public enum GameState
{
    Playing,
    Paused,
    GameOver,
}