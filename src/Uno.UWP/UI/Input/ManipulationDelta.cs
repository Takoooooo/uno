﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Windows.Foundation;

#if HAS_UNO_WINUI && IS_UNO_UI_PROJECT
namespace Microsoft.UI.Input
#else
namespace Windows.UI.Input
#endif
{
	public partial struct ManipulationDelta : IEquatable<ManipulationDelta>
	{
		/// <summary>
		/// A manipulation that does nothing.
		/// This differs to 'default' by having a 'Scale' of 1.
		/// </summary>
		internal static ManipulationDelta Empty { get; } = new ManipulationDelta
		{
			Translation = Point.Zero,
			Rotation = 0,
			Scale = 1,
			Expansion = 0
		};

		public Point Translation;
		public float Scale;
		public float Rotation;
		public float Expansion;

		internal bool IsEmpty => Translation == Point.Zero && Rotation == 0 && Scale == 1 && Expansion == 0;

		[Pure]
		internal ManipulationDelta Add(ManipulationDelta right) => Add(this, right);
		internal static ManipulationDelta Add(ManipulationDelta left, ManipulationDelta right)
			=> new ManipulationDelta
			{
				Translation = new Point(
					left.Translation.X + right.Translation.X,
					left.Translation.Y + right.Translation.Y),
				Rotation = left.Rotation + right.Rotation,
				Scale = left.Scale * right.Scale,
				Expansion = left.Expansion + right.Expansion
			};

		// Note: We should apply a velocity factor to thresholds to determine if isSignificant
		[Pure]
		internal bool IsSignificant(GestureRecognizer.Manipulation.Thresholds thresholds)
			=> Math.Abs(Translation.X) >= thresholds.TranslateX
			|| Math.Abs(Translation.Y) >= thresholds.TranslateY
			|| Math.Abs(Rotation) >= thresholds.Rotate
			|| Math.Abs(Expansion) >= thresholds.Expansion;

		/// <inheritdoc />
		[Pure]
		public override string ToString()
			=> $"x:{Translation.X:N0};y:{Translation.Y:N0};θ:{Rotation:F2};s:{Scale:F2};e:{Expansion:F2}";

		public override bool Equals(object obj) => obj is ManipulationDelta delta && Equals(delta);

		public bool Equals(ManipulationDelta other)
		{
			return EqualityComparer<Point>.Default.Equals(Translation, other.Translation) &&
				Scale == other.Scale && Rotation == other.Rotation &&
				Expansion == other.Expansion;
		}

		public override int GetHashCode()
		{
			var hashCode = 626270564;
			hashCode = hashCode * -1521134295 + Translation.GetHashCode();
			hashCode = hashCode * -1521134295 + Scale.GetHashCode();
			hashCode = hashCode * -1521134295 + Rotation.GetHashCode();
			hashCode = hashCode * -1521134295 + Expansion.GetHashCode();
			return hashCode;
		}

		public static bool operator ==(ManipulationDelta left, ManipulationDelta right) => left.Equals(right);
		public static bool operator !=(ManipulationDelta left, ManipulationDelta right) => !(left == right);
	}
}
