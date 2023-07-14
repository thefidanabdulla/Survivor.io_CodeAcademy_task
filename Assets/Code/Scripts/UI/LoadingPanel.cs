using System;
using Code.Scripts.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Scripts.UI
{
    public class LoadingPanel : MonoBehaviour
    {
        [SerializeField] private Image progressImage;
        [SerializeField] private TMP_Text loadingText;

        private void Start()
        {
            LevelManager.Instance.OnLoadProgressUpdated += OnLoadProgressUpdated;
        }

        private void OnLoadProgressUpdated(float progress)
        {
            progressImage.fillAmount = progress;
            loadingText.text = $"{progress * 100}%";
        }
    }
}