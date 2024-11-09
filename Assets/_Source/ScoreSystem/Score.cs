using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TMP namespace

namespace ScoreSystem
{
    public class Score : MonoBehaviour
    {
        public int ScoreValue { get; private set; }
        public TMP_Text scoreText; // Reference to the TMP text component

        public void SetScore(int value)
        {
            ScoreValue = value;
        }

        public void AddScore(int value)
        {
            ScoreValue += value;
        }

        public void UpdateScoreText()
        {
            if (scoreText != null)
            {
                scoreText.text = "Score: " + ScoreValue.ToString();
            }
        }
    }
}