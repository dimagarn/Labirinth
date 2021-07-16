//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Target that sends events when hit by an arrow
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class ArcheryTarget : MonoBehaviour
	{
		public UnityEvent onTakeDamage;

		public bool onceOnly = false;
		private bool targetEnabled = true;
		public Material material;

		private void OnDamageTaken()
		{
			if ( targetEnabled )
			{
				onTakeDamage.Invoke();
				GetComponent<MeshRenderer>().material = material;
				if ( onceOnly )
				{
					targetEnabled = false;
				}
			}
		}
	}
}
