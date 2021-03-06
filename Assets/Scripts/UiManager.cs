using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    [SerializeField] private TextMeshProUGUI uiTimerText;
    [SerializeField] private float uiTimer = 180f;
    [SerializeField] private GameObject deathPanel;

    private bool timerOn;

    private void Awake()
    {
        //singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

    }

    private void Start()
    {
        timerOn = true;
    }

    private void Update()
    {
        if (timerOn)
        {
            //starts counting down the timer
            uiTimer -= Time.deltaTime;
        }
        
        //sets the timer text in the UI and rounds the float down to an integer
        uiTimerText.text = string.Format("Time left: {0}", Mathf.Round(uiTimer));

        if (uiTimer <= 0)
        {
            //turn on death overlay
            deathPanel.SetActive(true);

            //timer bool to false so it doesnt count down again
            timerOn = false;

            //resets timer
            uiTimer = 0f;
        }
    }

    /// <summary>
    /// function to add more time to the timer. Call when checkpoint is reached
    /// </summary>
    public void AddTimeToTimer()
    {
        uiTimer += 30f;
    }
}
