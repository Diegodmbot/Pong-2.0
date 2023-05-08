using TMPro;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text player1Score;
    [SerializeField] private TMP_Text player2Score;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform money;
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;

    private int player1ScoreValue = 0;
    private int player2ScoreValue = 0;

    // Singlenton pattern
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (player1ScoreValue > 3)
        {
            money.GetComponent<Money>().ShowToPlayer1();
        }
        if (player2ScoreValue > 3)
        {
            money.GetComponent<Money>().ShowToPlayer2();
        }
    }
    
    public void Player1Scored()
    {
        player1ScoreValue++;
        player1Score.text = player1ScoreValue.ToString();
        StartCoroutine(ResetBall());
    }

    public void Player2Scored()
    {
        player2ScoreValue++;
        player2Score.text = player2ScoreValue.ToString();
        StartCoroutine(ResetBall());
    }

    public IEnumerator ResetBall()
    {
        ball.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1f);
        ball.GetComponent<Ball>().ResetBall();
    }
}
