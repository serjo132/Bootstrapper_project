using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Game _game;
        private Score _score;

        void Awake()
        {
            _score = new();
            _game = new (_score);
            inputListener.Construct(_game);

            _game.StartGame();
        }

    }
}