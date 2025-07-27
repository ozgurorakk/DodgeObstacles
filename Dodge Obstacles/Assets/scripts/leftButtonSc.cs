using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.EventSystems;

public class leftButtonSc : MonoBehaviour
{

    private bool _isHolding = false;

    //Circle commands.
    [SerializeField] GameObject _circles;
    [SerializeField] float _rotSpeed;
    void Update()
    {
        if (_isHolding)
        {
            //Debug.Log("Holding left button.");
            RotateCircleToLeft();
        }
        
    }
    public void RotateCircleToLeft()
    {
        _circles.transform.Rotate(0,0, 100 * _rotSpeed * Time.deltaTime);
    }
    public void ButtonDown()
    {
        _isHolding = true;
    }
    public void ButtonUp()
    {
        _isHolding = false;
        //Debug.Log("Stopped holding left button.");
    }
}
