using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode exitAppKey;
        private Game _game;

        public void Construct(Game game)
        {
            _game = game;
        }

        void Update()
        {
            ListenExitApp();
        }
        private void ListenExitApp()
        {
            if (Input.GetKeyDown(exitAppKey))
            {
                _game.FinishGame();
            }
        }
    }
}
