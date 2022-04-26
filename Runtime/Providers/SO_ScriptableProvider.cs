using UnityEngine;

namespace WinuXGames.SplitFramework.Core.Providers
{
    public abstract class SO_ScriptableProvider : ScriptableObject
    {
        protected abstract void ResetValues();
        
        private void OnEnable()
        {
            ResetValues();
        }
    }
}