using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
  public bool isCorrect = false;
  public Quiz quiz;

  public void Answer()
  {
    if(isCorrect)
    {
        Debug.Log("correct");
        quiz.correct();

    }
    else
    {
        Debug.Log("wrong Answer");
        quiz.correct();
    }
  }
  public void Timeout()
  {

  }
}
