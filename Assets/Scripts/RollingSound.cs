using UnityEngine;
using System.Collections;

/// <summary>
/// The rolling sound of the ball.
/// </summary>
public class RollingSound : MonoBehaviour 
{
  public AudioSource audioSource; // The rolling sound.
  Rigidbody _rigidbody;
  int _collisionCount = 0;

  /// <summary>
  /// Initializes the ball.
  /// </summary>
  void Start () 
  {
    _rigidbody = GetComponent<Rigidbody>();
  }
	
  /// <summary>
  /// Plays the sound as the ball is rolling.
  /// </summary>
  void Update () 
  {
    if(_collisionCount > 0) 
    {
      if(audioSource.isPlaying == false) 
      {
        audioSource.Play();
      }

      float volume = Mathf.Clamp(_rigidbody.velocity.magnitude, 0.0f, 1.0f);
      // Set the volume.
      audioSource.volume = volume;
    }
    else 
    {
      if(audioSource.isPlaying) 
      {
        audioSource.Stop();
      }
    }
  }
  
  /// <summary>
  /// Increases the collision count when the ball collides with an object.
  /// </summary>
  public void OnCollisionEnter() 
  {
    _collisionCount++;
  }

  /// <summary>
  /// Decrements the collision count when the ball collides with an object.
  /// </summary>
  public void OnCollisionExit() 
  {
    _collisionCount--;
  }
}
