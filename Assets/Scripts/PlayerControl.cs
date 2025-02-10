using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{  
    public Rigidbody2D rb;
    public TextMeshProUGUI scoreText;
    public float jumpAmt = 8f;
    private int score;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jumpAmt);

        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrig"))
        {
            score++;
            scoreText.text = score.ToString();
        
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}   
