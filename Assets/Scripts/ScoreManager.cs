using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager instance;

        public Text pointsCount;
        public Text waveCount;

        int points = 0;

        void Awake()
        {
            instance = this;
        }

        void Start()
        {
            pointsCount.text = $"Points - {points.ToString()}";
            waveCount.text = $"Wave - 1";
        }

        void Update()
        {
            // PlayerPrefs.SetInt("highestWave", wave)
        }

        public void AddPoints()
        {
            points += 100;
            pointsCount.text = $"Points - {points.ToString()}";
        }
    }
}
