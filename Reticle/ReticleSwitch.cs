using ReticleSW;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Misatyan
{
    internal class ReticleSwitch
    {
        public static IEnumerator WaitForMenu()
        {
            while (!GameObject.Find("Cohtml/CohtmlWorldView"))
                yield return new WaitForSeconds(1);

            Image reticle = GameObject.Find("_PLAYERLOCAL/[CameraRigDesktop]/Camera/Canvas/Image").GetComponent<Image>();

            reticle.sprite = Asset.Reticle();
            reticle.material.shader = Shader.Find("Sprites/Default");
            reticle.transform.localScale = Vector2.one;
        }
    }
}
