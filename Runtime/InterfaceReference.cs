using UnityEngine;

namespace WinuXGames.SplitFramework.Core
{
    [System.Serializable]
    public class InterfaceReference<T> : ISerializationCallbackReceiver where T : class
    {
        [SerializeField] private Object _target;

        public T Target => _target as T;

        private void OnValidate()
        {
            if (_target is T) { return; }

            if (_target is not GameObject go) { return; }

            _target = null;
            foreach (Component c in go.GetComponents<Component>())
            {
                if (c is not T) { continue; }

                _target = c;
                break;
            }
        }

        void ISerializationCallbackReceiver.OnBeforeSerialize() => OnValidate();
        void ISerializationCallbackReceiver.OnAfterDeserialize() { }
    }
}