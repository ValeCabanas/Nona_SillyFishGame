using UnityEngine;

public class WaveTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _waveSpawner;

    private void Awake()
    {
        //_waveSpawner.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("HOLA");
            _waveSpawner.gameObject.SetActive(true);
        }
    }
}
