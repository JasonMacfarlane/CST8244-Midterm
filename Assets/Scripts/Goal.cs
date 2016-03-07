using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// The goal.
/// </summary>
public class Goal : MonoBehaviour 
{
  public AudioSource goalSound; // The goal sound.
  public GameObject ball; // The ball

  /// <summary>
  /// Plays the goal sound when the ball reaches the goal.
  /// </summary>
  /// <param name="collision">The collision.</param>
  void OnCollisionEnter(Collision collision)
  {
    if (collision.collider.gameObject == ball)
    {
      StartCoroutine("ReturnToMenu");
    }
  }
  
  /// <summary>
  /// Plays the goal sound and returns to the main menu.
  /// </summary>
  /// <returns></returns>
  IEnumerator ReturnToMenu()
  {
    goalSound.Play();
    // Wait the duration of the goal sound.
    yield return new WaitForSeconds(1);
    SceneManager.LoadScene("MainMenu");
  }
}
