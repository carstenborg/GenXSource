/* -----------------------------------------------
 * INuGenButtonStateTracker.cs
 * Copyright � 2007 Anthony Nystrom
 * mailto:a.nystrom@genetibase.com
 * --------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Genetibase.Shared.Windows
{
	/// <summary>
	/// </summary>
	public interface INuGenButtonStateTracker : INuGenControlStateTracker
	{
		/// <summary>
		/// </summary>
		void MouseDown();

		/// <summary>
		/// </summary>
		void MouseEnter();

		/// <summary>
		/// </summary>
		void MouseLeave();

		/// <summary>
		/// </summary>
		void MouseUp();
	}
}