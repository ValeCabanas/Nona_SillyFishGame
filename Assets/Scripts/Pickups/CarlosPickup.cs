using UnityEngine;

public class CarlosPickup : MonoBehaviour
{
    [SerializeField] GameObject VictoryPanel;

    private bool _isPipipopoDead;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && _isPipipopoDead) VictoryPanel.SetActive(true);
    }

    public void PipiPopoDead(bool isDead)
    {
        _isPipipopoDead = isDead;
    }
}
