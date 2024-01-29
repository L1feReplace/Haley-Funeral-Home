using UnityEngine;

public class MovementAnimationController : MonoBehaviour
{
    private Animator animator;
    private Vector3 previousPosition;

    void Start()
    {
        // �������� ������ � ���������� Animator
        animator = GetComponent<Animator>();

        // �������������� ��������� �������
        previousPosition = transform.position;
    }

    void FixedUpdate()
    {
        // ��������� ������� �������� ��� ������� ����� ������� � ���������� ��������
        float speed = Vector3.Distance(previousPosition, transform.position) / Time.deltaTime;

        // ������������� ��������� �������� � ������������ � ������� ���������
        animator.SetFloat("Speed", speed);

        // ��������� ���������� �������
        previousPosition = transform.position;

        // ������� ���������� ���������� � �������
        Debug.Log($"Current Speed: {speed}");
    }
}
