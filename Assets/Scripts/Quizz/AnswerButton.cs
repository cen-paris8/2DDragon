using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public Text answerText;

    private AnswerData answerData;
    private GameController gameController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    public void SetUp( AnswerData Data)
    {
        answerData = Data;
        answerText.text = answerData.answerText;
    }

    public void HandleClick()
    {
        gameController.AnswerButtonClicked(answerData.isCorrect);
    }

}
