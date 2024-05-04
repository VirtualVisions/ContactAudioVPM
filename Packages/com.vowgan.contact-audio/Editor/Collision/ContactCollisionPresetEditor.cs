
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Vowgan.Contact.SoundPhysics
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ContactCollisionPreset))]
    public class ContactCollisionPresetEditor : Editor
    {

        private SerializedProperty propClips;


        private void OnEnable()
        {
            propClips = serializedObject.FindProperty(nameof(ContactCollisionPreset.Clips));
        }

        public override VisualElement CreateInspectorGUI()
        {
            VisualElement root = new VisualElement();
            VisualTreeAsset uxml = Resources.Load<VisualTreeAsset>("ContactCollisionPresetInspector");

            uxml.CloneTree(root);

            IMGUIContainer clipsContainer = root.Query<IMGUIContainer>("ClipsContainer");
            clipsContainer.onGUIHandler = ClipsContainerGUI;

            return root;
        }

        private void ClipsContainerGUI()
        {
            using (EditorGUI.ChangeCheckScope changed = new EditorGUI.ChangeCheckScope())
            {
                EditorGUILayout.PropertyField(propClips);
                if (changed.changed) serializedObject.ApplyModifiedProperties();
            }
        }
    }
}