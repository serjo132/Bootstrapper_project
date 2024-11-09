using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Game
    {
        private const int _startScoreValue = 5;
        private const int _exitScoreValue = 0;
        private readonly Score _score;

        public Game(Score score)
        {
            _score = score;
            StartGame();
        }

        public void StartGame()
        {
            Debug.Log("start game");
            _score.SetScore(_startScoreValue);
        }

        public void FinishGame()
        {
            Debug.Log("finish game");
            _score.SetScore(_exitScoreValue);
        }
    }
}
