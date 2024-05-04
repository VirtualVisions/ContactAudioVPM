
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Vowgan.Contact.SoundPhysics
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ContactCollisionObject))]
    public class ContactCollisionObjectEditor : Editor
    {
        
        public override VisualElement CreateInspectorGUI()
        {
            VisualElement root = new VisualElement();
            VisualTreeAsset uxml = Resources.Load<VisualTreeAsset>("ContactCollisionObjectInspector");
            uxml.CloneTree(root);
            return root;
        }
    }
}