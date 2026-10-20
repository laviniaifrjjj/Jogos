using UnityEngine;

public class CoinController : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SendMessage("ChangeTextCoin");
            Destroy(gameObject);
        }
    }
}