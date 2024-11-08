using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    private int numer = 0;
    public PokemonScript Enemy;
    public TMP_Text Question;
    public TMP_Text Answer1;
    public TMP_Text Answer2;
    public TMP_Text Answer3;
    public TMP_Text Answer4;
    private BattleManager BM;
    private MyPokemon MP;
    public void Start()
    {
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        MP = GameObject.FindGameObjectWithTag("MyPokemon").GetComponent<MyPokemon>();
    }
    public void StartQuiz()
    {
        Question.text = Enemy.QuizToCatch[numer].Question;
        Answer1.text = Enemy.QuizToCatch[numer].Answer1;
        Answer2.text = Enemy.QuizToCatch[numer].Answer2;
        Answer3.text = Enemy.QuizToCatch[numer].Answer3;
        Answer4.text = Enemy.QuizToCatch[numer].Answer4;
    }
    private void NextQuestion()
    {
        Question.text = Enemy.QuizToCatch[numer].Question;
        Answer1.text = Enemy.QuizToCatch[numer].Answer1;
        Answer2.text = Enemy.QuizToCatch[numer].Answer2;
        Answer3.text = Enemy.QuizToCatch[numer].Answer3;
        Answer4.text = Enemy.QuizToCatch[numer].Answer4;
    }
    private void NumerCheck()
    {
        if (numer+1==Enemy.QuizToCatch.Count)
        {
            Debug.Log("Koniec Quizu, wszycho jest");
            MP.AddCatchedPokemon(Enemy);
            BM.RunAway();
            numer = 0;
        }
        else
        {
            numer++;
            NextQuestion();
        }
    }

    public void SubmitAnswer1()
    {
        if (Answer1.text == Enemy.QuizToCatch[numer].CorrectAnswer)
        {
            Debug.Log("DOBRZE!");
            NumerCheck();
        }
        else
        {
            BM.RunAway();
        }
    }
    public void SubmitAnswer2()
    {
        if (Answer2.text == Enemy.QuizToCatch[numer].CorrectAnswer)
        {
            Debug.Log("DOBRZE!");
            NumerCheck();
        }
        else
        {
            BM.RunAway();
        }
    }
    public void SubmitAnswer3()
    {
        if (Answer3.text == Enemy.QuizToCatch[numer].CorrectAnswer)
        {
            Debug.Log("DOBRZE!");
            NumerCheck();
        }
        else
        {
            BM.RunAway();
        }
    }
    public void SubmitAnswer4()
    {
        if (Answer4.text == Enemy.QuizToCatch[numer].CorrectAnswer)
        {
            Debug.Log("DOBRZE!");
            NumerCheck();
        }
        else
        {
            BM.RunAway();
        }
    }

}
