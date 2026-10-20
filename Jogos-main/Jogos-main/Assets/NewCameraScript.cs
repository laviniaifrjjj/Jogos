using UnityEngine;

public class NewCameraScript : MonoBehaviour
{
    public Transform playerTransform;

    void Start()
    {
        AtualizarPosicaoCamera();
    }

    void LateUpdate()
    {
        AtualizarPosicaoCamera();
    }

    private void AtualizarPosicaoCamera()
    {
        if (playerTransform != null)
        {
            Vector3 playerPosition = playerTransform.position;
            transform.position = new Vector3(playerPosition.x, playerPosition.y, transform.position.z);
        }
    }
}