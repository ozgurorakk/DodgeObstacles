using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.EventSystems;

public class rightButtonSc : MonoBehaviour
{
    private bool _isHolding = false;

    //Circle commands.
    [SerializeField] private Transform _circles;
    [SerializeField] private float _rotSpeed;
    void Update()
    {
        if (_isHolding)
        {
            //Debug.Log("Holding right button.");
            RotateCircleToRight();
        }
    }

    public void RotateCircleToRight()
    {
        _circles.transform.Rotate(0, 0, -100 * _rotSpeed * Time.deltaTime);
    }
    public void ButtonDown()
    {
        _isHolding = true;
    }
    public void ButtonUp()
    {
        _isHolding = false;
        //Debug.Log("Stopped holding right button.");
    }
}
