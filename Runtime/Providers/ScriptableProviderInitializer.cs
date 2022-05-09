using UnityEngine;

namespace WinuXGames.SplitFramework.Core.Providers
{
    [DefaultExecutionOrder(-1)]
    public abstract class ScriptableProviderInitializer<T> : MonoBehaviour where T : SO_ScriptableProvider
    {
        [SerializeField] private T _providerToInitialize;

        protected T ProviderToInitialize => _providerToInitialize;
    }
}