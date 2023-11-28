using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiMainMenu : MonoBehaviour
{
     [SerializeField] Button _nextLevel;

    private LevelManager _levelManager;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
       /* _nextLevel.onClick.AddListener(LoadNextScene);*/
    }

    private void StartNextLevel(){
        //_levelManager.LoadNewGame();
        _levelManager.LoadAsyncScene(LevelManager.Scene.ExamenA_02);
    }
}
