using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private int ScoreValue = 0;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private TMP_Text _scoreText;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
<<<<<<< Updated upstream
        _scoreText.text = "Score : " + ScoreValue;
=======
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            ScoreValue = PlayerPrefs.GetInt("ScoreValue");
        }
        _scoreText.text = "Score : "+ScoreValue;
>>>>>>> Stashed changes
    }

    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f) 
        {
            _rigidbody.AddForce(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0f, Input.GetAxis("Vertical")*_speed*Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target_Trigger"))
        {
            Destroy(other.gameObject);
            UpdateScore();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
            UpdateScore();
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        }
    }

    private void UpdateScore()
    {
        Instantiate(_wallPrefab, _scenario.FirstWalls[ScoreValue%_scenario.FirstWalls.Length].position,Quaternion.Euler(_scenario.FirstWalls[ScoreValue % _scenario.FirstWalls.Length].orientation));

        ScoreValue++;
<<<<<<< Updated upstream
        _scoreText.text = "Score : " + ScoreValue;
=======
        if (PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetString("Score", "Score : " + ScoreValue.ToString());
        }
        _scoreText.text = PlayerPrefs.GetString("Score");
        if(ScoreValue >= 8 && SceneManager.GetActiveScene().buildIndex == 0)
        {
            PlayerPrefs.SetInt("ScoreValue", ScoreValue);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
>>>>>>> Stashed changes
    }
}
