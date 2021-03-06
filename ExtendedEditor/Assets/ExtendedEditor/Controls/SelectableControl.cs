﻿#if UNITY_EDITOR
using TNRD.Editor.Core;
using TNRD.Json;
using UnityEngine;

namespace TNRD.Editor.Controls {
	public abstract class SelectableControl : ExtendedControl {

		[JsonIgnore]
		public bool IsSelected;

		public virtual void OnSelect() { IsSelected = true; }
		public virtual void OnDeselect() { IsSelected = false; }

		public virtual Vector2 Center() {
			return Rectangle.center;
		}
		public virtual bool Contains( Vector2 value ) {
			return Rectangle.Contains( value );
		}
		public virtual void Move( Vector2 delta ) {
			Position += delta;
		}
	}
}
#endif