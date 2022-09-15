using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Trivia.Global.SaveData;
using UnityEngine.SceneManagement;

public class PackList : MonoBehaviour
{
    [SerializeField] private Button[] _PackListButton;
    [SerializeField] private GameObject[] _lockPanel;
    [SerializeField] private TextMeshProUGUI[] _costText;
    
 
    void Awake()
    {
        for (int i = 0; i < _PackListButton.Length; i++)
        {
            int tempIndex = i;
            int cost = 100;
            _PackListButton[i].onClick.AddListener(() => OnPackScene(tempIndex));
            _costText[i].text = cost.ToString() + "G";
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _PackListButton.Length; i++)
        {
            if (SaveData.saveInstance.unlockedPack[i])
            {
                _lockPanel[i].SetActive(false);
            }
        }
    }
    void OnPackScene(int index)
    {
    SaveData.saveInstance.ChangeCurrentPack(index);
    SceneManager.LoadScene("LevelScene");
    }
}
