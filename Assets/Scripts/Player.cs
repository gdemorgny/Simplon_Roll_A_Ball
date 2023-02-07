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
        _scoreText.text = "Score : " + ScoreValue;
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
        }
    }

    private void UpdateScore()
    {
        ScoreValue++;
        _scoreText.text = "Score : " + ScoreValue;
    }
}
