using UnityEngine;
using System.Collections;

/// <summary>
/// Wall sound.
/// </summary>
public class WallSound : MonoBehaviour 
{
  public AudioSource audioSound; // The sound
  public GameObject ball; // The ball
  
  /// <summary>
  /// Plays the sound entering a collision.
  /// </summary>
  /// <param name="collision">The collision.</param>
  void OnCollisionEnter(Collision collision)
  {
    // Play the sound if the collider is the ball.
    if (collision.collider.gameObject == ball)
    {
      audioSound.Play();
     }
  }

  /// <summary>
  /// Stops the sound when exiting a collision.
  /// </summary>
  /// <param name="collision">The collision.</param>
  void OnCollisionExit(Collision collision)
  {
    audioSound.Stop();
  }
}
