using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Singelton;
    public int Score;
    public int MaxLife;
    public int Life;
    public float Speed;
    private int _maxScore;
    public Text ScoreText;
    public GameObject LifesHolder;
    public Image BadForeground;

    public Image Pause;
    // Start is called before the first frame update
    void Start()
    {
        Singelton = this;
        Life = MaxLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(Speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
            transform.rotation = Quaternion.identity;

        if (Input.GetKeyDown(KeyCode.S))
            transform.rotation = new Quaternion(0, 1f, 0, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
            Pause.enabled = Time.timeScale == 0;
        }
    }

    public void RegisterScore() {
        ++Score;
        if (Score >= _maxScore) {
            _maxScore = Score;
        }
        ScoreText.text = $"����:\n{Score}\n����.:\n{_maxScore}";
    }
    public void SubstractLife()
    {
        --Life;
        if (Life <= 0) {
            Life = MaxLife;
            Score = 0;
            ScoreText.text = $"Score:\n{Score}\nMax:\n{_maxScore}";
        }

        var hearts = LifesHolder.GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < MaxLife; i++)
        {
            hearts[i].enabled = i + 1 <= Life;
        }

        BadForeground.enabled = Life == 1;
    }



}
