using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionOne : MonoBehaviour {

    public GameObject choiceOne;
    public GameObject choiceTwo;
    public GameObject choiceThree;
    public GameObject choiceFour;
    public int choiceMade;

   public void ChoiceOptionOne()
    {
        //code that runs if this choice was made
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

    private void Update()
    {
        if (choiceMade == 1 )
        {
            //code that runs goes here
        }

        else if (choiceMade == 2)
        {
            //code that runs goes here
        }

        else if (choiceMade == 3)
        {
            //code that runs goes here
        }

        else
        {
            // code that runs goes here
        }


    }
}
