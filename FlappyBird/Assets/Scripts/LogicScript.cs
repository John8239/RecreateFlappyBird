using UnityEngine;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int _scoreCount;
    public TMP_Text _scoreText;

    [ContextMenu("Add Score")]
    public void AddScore()
    {
        _scoreCount++;
        _scoreText.text = _scoreCount.ToString();
    }
}
