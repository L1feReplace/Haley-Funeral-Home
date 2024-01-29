using UnityEngine;

public class MovementAnimationController : MonoBehaviour
{
    private Animator animator;
    private Vector3 previousPosition;

    void Start()
    {
        // Получаем доступ к компоненту Animator
        animator = GetComponent<Animator>();

        // Инициализируем начальную позицию
        previousPosition = transform.position;
    }

    void FixedUpdate()
    {
        // Вычисляем текущую скорость как разницу между текущей и предыдущей позицией
        float speed = Vector3.Distance(previousPosition, transform.position) / Time.deltaTime;

        // Устанавливаем параметры анимации в соответствии с текущей скоростью
        animator.SetFloat("Speed", speed);

        // Обновляем предыдущую позицию
        previousPosition = transform.position;

        // Выводим отладочную информацию в консоль
        Debug.Log($"Current Speed: {speed}");
    }
}
