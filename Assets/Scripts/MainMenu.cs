using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  /// <summary>
  /// Loads the main scene.
  /// </summary>
  public void PlayButtonClicked()
  {
    SceneManager.LoadScene("GameScene");
  }
}
