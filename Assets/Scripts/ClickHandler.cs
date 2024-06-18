using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;
    private int score;
    private int coin;

    private PlayerInput playerInput;
    private InputAction clickAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        InputAction clickAction = playerInput.actions["Click"];
        clickAction.performed += OnClicked;
    }

    void Start()
    {
        score = 0;
        coin = 0;
        UpdateUI();

        StartCoroutine(PerSecondProduction());
    }

    private void OnClicked(InputAction.CallbackContext context)
    {
        IncrementScoreAndCoin();
    }

    /*void Update()
    {
        //юс╫ц..
        if (Input.GetMouseButtonDown(0))
        {
            IncrementScoreAndCoin();
        }
    }*/

    void IncrementScoreAndCoin()
    {
        score++;
        coin += 100;
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        coinText.text = "Coin: " + coin;
    }

    IEnumerator PerSecondProduction()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            IncrementScoreAndCoin();
        }
    }
}
