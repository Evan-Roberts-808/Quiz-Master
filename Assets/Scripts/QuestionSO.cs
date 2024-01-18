using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswer;

    public string GetQuestion() { return question; }

    public int GetCorrectAnswerIndex() { return correctAnswer; }

    public string GetAnswer(int index) { return answers[index]; }
}