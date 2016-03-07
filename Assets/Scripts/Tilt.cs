using UnityEngine;
using System.Collections;

/// <summary>
/// The board tilt.
/// </summary>
public class Tilt : MonoBehaviour 
{
  private Vector2 _initialMousePosition;
  public float rotationConstraint = 36.0f;

  /// <summary>
  /// Initializes the mouse position.
  /// </summary>
  void Start ()
  {
    _initialMousePosition = Input.mousePosition;
  }

  /// <summary>
  /// Tilts the board in the direction of the mouse position.
  /// </summary>
  void Update() 
  {
    Vector2 currentMousePosition = Input.mousePosition;
    Vector2 delta = currentMousePosition - _initialMousePosition;

    if(Mathf.Abs(delta.x) > rotationConstraint) 
    {
      delta.x = Mathf.Sign(delta.x) * rotationConstraint;
    }

    if(Mathf.Abs(delta.y) > rotationConstraint) 
    {
      delta.y = Mathf.Sign(delta.y) * rotationConstraint;
    }

    Vector3 localRotation = new Vector3(delta.y, 0.0f, -delta.x);
    transform.localRotation = Quaternion.Euler(localRotation);
  }
}
