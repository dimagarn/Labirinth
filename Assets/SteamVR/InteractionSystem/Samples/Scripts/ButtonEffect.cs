//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {
        public GameObject point;
        public string tag;
        private bool isEnable = false;
        public void OnButtonDown(Hand fromHand)
        {
            ColorSelf(Color.cyan);
            fromHand.TriggerHapticPulse(1000);

            Debug.Log("Button");
            Vector3 oldPosition = Player.instance.transform.position;
            if (isEnable)
            {
                oldPosition = transform.position;
                if (this.tag == "samplButton")
                    transform.position = point.transform.position;
                else
                    transform.position = oldPosition;
            }
        }

        public void OnButtonUp(Hand fromHand)
        {
            ColorSelf(Color.white);
        }

        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }

        public void Enable()
        {
            isEnable = !isEnable;
        }
    }
}