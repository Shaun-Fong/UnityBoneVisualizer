using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace BoneRenderer.Editor
{

    public static class BoneRendererMenu
    {


        [MenuItem("Bone Renderer/Setup", false, 13)]
        public static void BoneRendererSetup()
        {
            var selection = Selection.activeTransform;
            if (selection == null)
                return;

            BoneRendererSetup(selection);
        }

        public static void BoneRendererSetup(Transform transform)
        {
            var boneRenderer = transform.GetComponent<BoneRenderer>();
            if (boneRenderer == null)
                boneRenderer = Undo.AddComponent<BoneRenderer>(transform.gameObject);
            else
                Undo.RecordObject(boneRenderer, "Bone renderer setup.");

            var animator = transform.GetComponent<Animator>();
            var renderers = transform.GetComponentsInChildren<SkinnedMeshRenderer>();
            var bones = new List<Transform>();
            if (animator != null && renderers != null && renderers.Length > 0)
            {
                for (int i = 0; i < renderers.Length; ++i)
                {
                    var renderer = renderers[i];
                    for (int j = 0; j < renderer.bones.Length; ++j)
                    {
                        var bone = renderer.bones[j];
                        if (!bones.Contains(bone))
                        {
                            bones.Add(bone);

                            for (int k = 0; k < bone.childCount; k++)
                            {
                                if (!bones.Contains(bone.GetChild(k)))
                                    bones.Add(bone.GetChild(k));
                            }
                        }
                    }
                }
            }
            else
            {
                bones.AddRange(transform.GetComponentsInChildren<Transform>());
            }

            boneRenderer.transforms = bones.ToArray();

            if (PrefabUtility.IsPartOfPrefabInstance(boneRenderer))
                EditorUtility.SetDirty(boneRenderer);
        }
    }

}

