 using TMPro;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 using UnityEngine.Serialization;
 using UnityEngine.UI;

 public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public int playerScore = 0;
     [SerializeField] TextMeshProUGUI scoreText;
     [SerializeField] private GameObject gameOverPanel;
     [ContextMenu("Add Score")]
     public void AddScore(int scoreToAdd)
     {
         playerScore+= scoreToAdd;
         scoreText.text = playerScore.ToString();
     }

     public void RestartGame()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
     
     public void GameOver()
     {
         gameOverPanel.SetActive(true);
     }
}
