using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Trivia.Global.SaveData;
using UnityEngine.SceneManagement;

public class LevelList : MonoBehaviour
{
     [SerializeField] private Button[] _LevelListButton;

    void Awake()
    {
        for (int i = 0; i < _LevelListButton.Length; i++)
        {
             int tempIndex = i;
            _LevelListButton[i].onClick.AddListener(() => OnLevelScene(tempIndex));
            
        }
    }
    void OnLevelScene(int index)
    {
    SaveData.saveInstance.ChangeCurrentLevel(index);
    SceneManager.LoadScene("GameplayScene");
    }
}
