using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScoreSystem
{
    public class ClickableItem : MonoBehaviour
    {
        public Score scoreManager; // Reference to the Score class
        public int scoreToAdd = 1; // Score to add when this item is clicked

        private void OnMouseDown()
        {
            Debug.Log($"Click on {gameObject.name}");
            scoreManager.AddScore(scoreToAdd); // Add score when clicked
            scoreManager.UpdateScoreText(); // Update the score text
        }
    }
}