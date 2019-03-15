using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionFour : MonoBehaviour
{

    public GameObject choiceOne;
    public GameObject choiceTwo;
    public GameObject choiceThree;
    public GameObject choiceFour;

    public Text questionOneAnsResult;

    public int choiceMade;

    string answerCorrect = "Correct";
    string answerWrong = "Wrong";




    public void ChoiceOptionOne()
    {
        choiceMade = 1;
    }

    public void ChoiceOptionTwo()
    {
        //code that runs if this choice was made
        choiceMade = 2;
    }

    public void ChoiceOptionThree()
    {
        //code that runs if this choice was made
        choiceMade = 3;
    }

    public void ChoiceOptionFour()
    {
        //code that runs if this choice was made
        choiceMade = 4;
    }

    public void DisplayAnswerOnReport()
    {
        if (choiceMade == 3)
        {
            questionOneAnsResult.text = answerCorrect;
        }

        else
        {
            questionOneAnsResult.text = answerWrong;
        }


    }
}
