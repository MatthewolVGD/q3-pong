using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scorekeeper : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public TextMeshProUGUI rightText;
    public TextMeshProUGUI leftText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rightText.text = System.Convert.ToString(rightScore);
        leftText.text = System.Convert.ToString(leftScore);

        if (leftScore == 11)
        {
            SceneManager.LoadScene("BlueWins");
        }
        if (rightScore == 11)
        {
            SceneManager.LoadScene("OrangeWins");
        }
    }
}
