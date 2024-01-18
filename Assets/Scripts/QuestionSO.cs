using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question";
    [SerializeField] string[] answers = {"Enter your answers"};

    public string GetQuestion()
    {
        return question;
    }

}