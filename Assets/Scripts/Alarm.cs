using UnityEngine;

/// <summary>
/// Alarm sound.
/// </summary>
public class Alarm : MonoBehaviour 
{
  public AudioSource audioSound; // The sound
  public GameObject ball; // The ball
  
  /// <summary>
  /// Plays the sound entering a trigger.
  /// </summary>
  /// <param name="collider">The collider.</param>
  void OnTriggerEnter(Collider collider)
  {
    // Play the sound if the collider is the ball.
    if (collider.gameObject == ball)
    {
      audioSound.Play();
    }
  }
  
  /// <summary>
  /// Stops the sound exiting a trigger.
  /// </summary>
  /// <param name="collider">The collider.</param>
  void OnTriggerExit(Collider collider)
  {
    // If the collider is the ball, stop the audio and reset
    // the ball to its starting position.
    if (collider.gameObject == ball)
    {
      audioSound.Stop();
      Vector3 ballOrigin = new Vector3(-3.0f, 2.0f, 3.0f);
      collider.gameObject.transform.localPosition = ballOrigin;
    }
  }
}
