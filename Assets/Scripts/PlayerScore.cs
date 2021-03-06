using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerScore : MonoBehaviour
{
    [SerializeField] int _score;
    [SerializeField] TextMeshProUGUI _textScore;
    [SerializeField] PlayerController _playerController;
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _restartButton;
    public bool _gameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ScoreBox")
        {
            _score ++;
            _textScore.text = _score.ToString();

        }

        if(collision.tag == "Obstacle")
        {
            GameOver();
        }


    }

    void GameOver()
    {
        _playerController.enabled = false;
        _animator.enabled = false;
        _restartButton.SetActive(true); 
        _gameOver = true;
    }
}
