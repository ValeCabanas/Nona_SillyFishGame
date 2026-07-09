using UnityEngine;

public class MusicChange : MonoBehaviour
{
    [SerializeField] private bool _isMainMenu;

    private void Start()
    {
        if (_isMainMenu)
        {
            AudioManager.Instance.PlayMenuMusic();
            return;
        }
        AudioManager.Instance.PlayGameplayMusic();
    }
}
