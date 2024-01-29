using UnityEngine;
using Cinemachine;

public class TutorialCamera : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private CinemachineVirtualCamera _customerCamera;
    [SerializeField] private CinemachineVirtualCamera _secondCustomerCamera;



    public void InitializeCustomerCamera(Transform bookCourier) => _customerCamera.Follow = bookCourier;
    public void InitializeSecondCustomerCamera(Transform deskCamera) => _secondCustomerCamera.Follow = deskCamera;

    public void Show(string trigger)
    {

        ResetAllTrigger();
        _animator.SetTrigger(trigger);
    }

    private void ResetAllTrigger()
    {
        _animator.ResetTrigger(CameraAnimatorParameters.ShowCustomer);
        _animator.ResetTrigger(CameraAnimatorParameters.ShowPlayer);
        _animator.ResetTrigger(CameraAnimatorParameters.ShowConveyor);
        _animator.ResetTrigger(CameraAnimatorParameters.ShowCustomer);
        _animator.ResetTrigger(CameraAnimatorParameters.ShowSecondCustomer);
        _animator.ResetTrigger(CameraAnimatorParameters.ShowGrave);
        _animator.ResetTrigger(CameraAnimatorParameters.ShowItemProducer);
    }
}
