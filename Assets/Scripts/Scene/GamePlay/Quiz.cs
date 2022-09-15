using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class Quiz : MonoBehaviour
    {
        public List<QuizController> QnA;
        public GameObject[] Options;
        public int currentQuestion;
        public TextMeshProUGUI questionText;
        public Sprite[] spriteArray;

        private void Start()
        {
            spriteArray = Resources.LoadAll<Sprite>("Level Pack A");
            initQuiz();
        }
        public void correct()
        {
            QnA.RemoveAt(currentQuestion);
            initQuiz();
        }
        private void SetAnswer()
        {
            for(int i=0; i< Options.Length; i++)
            {
                Options[i].GetComponent<GameFlow>().isCorrect = false;
                Options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = 
                QnA[currentQuestion].Answers[i];
                


                if(QnA[currentQuestion].CorrectAnswer == i+1)
                {
                    Options[i].GetComponent<GameFlow>().isCorrect = true;
                }
            }
        }

        private void initQuiz()
        {
            currentQuestion = Random.Range(0, QnA.Count);
            questionText.text = QnA[currentQuestion].Question;
            SetAnswer();
            
        }
    }
