using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine.Rendering.Universal;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private TheCoinWatcher theCoinWatcher;
    [SerializeField] private UiController uiController;

    [SerializeField] private float speed = 5f;
    private Vector3 _direction = new Vector3(0, 0, 0);

    private bool isFunctional = true;
    void Update()
    {
        if (isFunctional)
        {
            transform.position += _direction.normalized * (speed * Time.deltaTime);
            _direction = Vector3.zero;

            if (Keyboard.current.wKey.isPressed)
            {
                _direction.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                _direction.y = -1;
            }
            if (Keyboard.current.dKey.isPressed)
            {
                _direction.x = 1;
            }
            if (Keyboard.current.aKey.isPressed)
            {
                _direction.x = -1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Loot assimilated!");
            Destroy(other.gameObject);
            theCoinWatcher.AddCoin();
        }else if (other.CompareTag("Lava"))
        {
            Debug.Log("Critical heat level!");
            uiController.ShowPanelLost();
            isFunctional = false;
        }
    }
}
