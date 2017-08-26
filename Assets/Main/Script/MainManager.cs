using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class MainManager : MonoBehaviour {

    public enum GameState
    {
        GAME_INIT,
        GAME_NETWORK,
        GAME_TITLE,
        GAME_FADIN,
        GAME_START,
        GAME_PLAYING,
        GAME_TIMEUP,
        GAME_RESULT,
        GAME_FINISH,

        GAME_STATE_MAX,
    }
    public static GameState CurrentState = GameState.GAME_INIT;

    private void Start()
    {
        Debug.Log(CurrentState);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int tmp = (int)CurrentState;

            tmp = (tmp + 1) % (int)(GameState.GAME_STATE_MAX);

            CurrentState = (GameState)tmp;

            Debug.Log(CurrentState);
        }
    }
}
