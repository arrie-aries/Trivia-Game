using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TestScript : MonoBehaviour
{
      [SerializeField] private Button[] _gamePlayButton;
     enum Answer
     {
        A,
        B,
        C,
        D,
     }
    
    void Awake()
    {
        for (int i = 0; i < _gamePlayButton.Length; i++)
        {
             int tempIndex = i;
            //_gamePlayButton[i].onClick.AddListener(() => AnswerQuestion(tempIndex));
            
        }
    }

    void AnswerQuestion(Answer i)
    {
     switch (i)
        {
        case Answer.A:
            print ("Merah");
            break;
        case Answer.B:
            print ("Biru");
            break;
        case Answer.C:
            print ("Hijau");
            break;
        case Answer.D:
            print ("Kuning");
            break;

        }
    }
}
