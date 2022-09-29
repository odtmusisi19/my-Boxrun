using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHadEnded = false;
    public void EndGame()
    {
        Debug.Log("game berhenti");
        if (gameHadEnded == false)
        {
            gameHadEnded = true;
            // Debug.Log("Game Over");
            
        }
        // Restart();
        // if(Input.GetKey("r")){
        //     Restart();
        // }
    }
   public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
