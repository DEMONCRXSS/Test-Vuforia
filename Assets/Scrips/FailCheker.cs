using UnityEngine;
using UnityEngine.Events;

public class FailCheker : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onNoteDestroyed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            _onNoteDestroyed?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
