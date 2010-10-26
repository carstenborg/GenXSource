/* -----------------------------------------------
 * NuGenSwitcherDesigner.cs
 * Copyright � 2007 Anthony Nystrom
 * mailto:a.nystrom@genetibase.com
 * --------------------------------------------- */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Genetibase.Shared.Controls.Design
{
	/// <summary>
	/// Provides additional design-time functionality for the <see cref="NuGenSwitcher"/>.
	/// </summary>
	public class NuGenSwitcherDesigner : NuGenPageHostDesignerBase
	{
		private DesignerActionListCollection _actionLists;

		/// <summary>
		/// Gets the design-time action lists supported by the component associated with the designer.
		/// </summary>
		/// <value></value>
		/// <returns>The design-time action lists supported by the component associated with the designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				if (_actionLists == null)
				{
					_actionLists = new DesignerActionListCollection();
					_actionLists.Add(new NuGenSwitcherActionList(this.Switcher));
				}

				return _actionLists;
			}
		}

		/// <summary>
		/// Indicates whether the specified control can be a child of the control managed by this designer.
		/// </summary>
		/// <param name="control">The <see cref="T:System.Windows.Forms.Control"></see> to test.</param>
		/// <returns>
		/// true if the specified control can be a child of the control managed by this designer; otherwise, false.
		/// </returns>
		public override bool CanParent(Control control)
		{
			if (control is NuGenSwitchPage)
			{
				return !this.Control.Contains(control);
			}

			return false;
		}

		private NuGenSwitcher Switcher
		{
			get
			{
				return (NuGenSwitcher)base.Component;
			}
		}

		/// <summary>
		/// Initializes the designer with the specified component.
		/// </summary>
		/// <param name="component">The <see cref="T:System.ComponentModel.IComponent"></see> to associate with the designer.</param>
		public override void Initialize(IComponent component)
		{
			Debug.Assert(component != null, "component != null");
			base.Initialize(component);

			_switcher = component as NuGenSwitcher;

			if (_switcher != null)
			{
				_switcher.SelectedSwitchPageChanged += _switcher_SelectedSwitchPageChanged;
			}

			ISelectionService selectionService = (ISelectionService)this.GetService(typeof(ISelectionService));

			if (selectionService != null)
			{
				selectionService.SelectionChanged += _selectionService_SelectionChanged;
			}
		}

		/*
		 * GetSelectedSwitchPageDesigner
		 */

		/// <summary>
		/// </summary>
		/// <returns></returns>
		protected NuGenSwitchPageDesigner GetSelectedSwitchPageDesigner()
		{
			NuGenSwitchPageDesigner switchPageDesigner = null;
			NuGenSwitchPage selectedSwitchPage = _switcher.SelectedSwitchPage;

			if (selectedSwitchPage != null)
			{
				IDesignerHost host = (IDesignerHost)this.GetService(typeof(IDesignerHost));

				if (host != null)
				{
					switchPageDesigner = host.GetDesigner(selectedSwitchPage) as NuGenSwitchPageDesigner;
				}
			}

			return switchPageDesigner;
		}

		/*
		 * GetHitTest
		 */

		/// <summary>
		/// Indicates whether a mouse click at the specified point should be handled by the control.
		/// </summary>
		/// <param name="point">A <see cref="T:System.Drawing.Point"></see> indicating the position at which the mouse was clicked, in screen coordinates.</param>
		/// <returns>
		/// true if a click at the specified point is to be handled by the control; otherwise, false.
		/// </returns>
		protected override bool GetHitTest(Point point)
		{
			return this.Switcher.HitTest(point) == NuGenSwitcherHitResult.SwitchButtons;
		}

		/*
		 * OnDragDrop
		 */

		/// <summary>
		/// Called when a drag-and-drop object is dropped onto the control designer view.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.DragEventArgs"></see> that provides data for the event.</param>
		protected override void OnDragDrop(DragEventArgs e)
		{
			NuGenSwitchPageDesigner designer = this.GetSelectedSwitchPageDesigner();

			if (designer != null)
			{
				designer.DoDragDrop(e);
			}
			else
			{
				base.OnDragDrop(e);
			}
		}

		/*
		 * OnDragEnter
		 */

		/// <summary>
		/// Called when a drag-and-drop operation enters the control designer view.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.DragEventArgs"></see> that provides data for the event.</param>
		protected override void OnDragEnter(DragEventArgs e)
		{
			NuGenSwitchPageDesigner designer = this.GetSelectedSwitchPageDesigner();

			if (designer != null)
			{
				designer.DoDragEnter(e);
			}
			else
			{
				base.OnDragEnter(e);
			}
		}

		/*
		 * OnDragLeave
		 */

		/// <summary>
		/// Called when a drag-and-drop operation leaves the control designer view.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"></see> that provides data for the event.</param>
		protected override void OnDragLeave(EventArgs e)
		{
			NuGenSwitchPageDesigner designer = this.GetSelectedSwitchPageDesigner();

			if (designer != null)
			{
				designer.DoDragLeave(e);
			}
			else
			{
				base.OnDragLeave(e);
			}
		}

		/*
		 * OnDragOver
		 */

		/// <summary>
		/// Called when a drag-and-drop object is dragged over the control designer view.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.DragEventArgs"></see> that provides data for the event.</param>
		protected override void OnDragOver(DragEventArgs e)
		{
			NuGenSwitchPageDesigner designer = this.GetSelectedSwitchPageDesigner();

			if (designer != null)
			{
				designer.DoDragOver(e);
			}
			else
			{
				base.OnDragOver(e);
			}
		}

		/*
		 * OnGiveFeedback
		 */

		/// <summary>
		/// Receives a call when a drag-and-drop operation is in progress to provide visual cues based on the location of the mouse while a drag operation is in progress.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.GiveFeedbackEventArgs"></see> that provides data for the event.</param>
		protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
		{
			NuGenSwitchPageDesigner designer = this.GetSelectedSwitchPageDesigner();

			if (designer != null)
			{
				designer.DoGiveFeedback(e);
			}
			else
			{
				base.OnGiveFeedback(e);
			}
		}

		/*
		 * PostFilterEvents
		 */

		/// <summary>
		/// Allows a designer to change or remove items from the set of events that it exposes through a <see cref="T:System.ComponentModel.TypeDescriptor"></see>.
		/// </summary>
		/// <param name="events">The events for the class of the component.</param>
		protected override void PostFilterEvents(IDictionary events)
		{
			events.Remove("AutoSizeChanged");
			events.Remove("Load");
			events.Remove("Scroll");

			base.PostFilterEvents(events);
		}

		/*
		 * PostFilterProperties
		 */

		/// <summary>
		/// Allows a designer to change or remove items from the set of properties that it exposes through a <see cref="T:System.ComponentModel.TypeDescriptor"></see>.
		/// </summary>
		/// <param name="properties">The properties for the class of the component.</param>
		protected override void PostFilterProperties(IDictionary properties)
		{
			properties.Remove("AutoScroll");
			properties.Remove("AutoScrollMargin");
			properties.Remove("AutoScrollMinSize");
			properties.Remove("AutoSize");
			properties.Remove("AutoSizeMode");

			base.PostFilterProperties(properties);
		}

		private static NuGenSwitchPage GetSwitchPageOfComponent(object component)
		{
			if (!(component is Control))
			{
				return null;
			}

			Control parent = (Control)component;

			while (parent != null && !(parent is NuGenSwitchPage))
			{
				parent = parent.Parent;
			}

			return (NuGenSwitchPage)parent;
		}

		private void _selectionService_SelectionChanged(object sender, EventArgs e)
		{
			ISelectionService service = (ISelectionService)this.GetService(typeof(ISelectionService));

			if (service != null)
			{
				ICollection selectedComponents = service.GetSelectedComponents();

				foreach (object selectedComponent in selectedComponents)
				{
					NuGenSwitchPage switchPageOfComponent = NuGenSwitcherDesigner.GetSwitchPageOfComponent(selectedComponent);

					if (switchPageOfComponent != null && switchPageOfComponent.Parent == _switcher)
					{
						_switcher.SelectedSwitchPage = switchPageOfComponent;
						break;
					}
				}
			}
		}

		private void _switcher_SelectedSwitchPageChanged(object sender, EventArgs e)
		{
			ISelectionService service = (ISelectionService)this.GetService(typeof(ISelectionService));

			if (service != null)
			{
				ICollection selectedComponents = service.GetSelectedComponents();
				bool flag = false;

				foreach (object selectedComponent in selectedComponents)
				{
					NuGenSwitchPage switchPageOfComponent = NuGenSwitcherDesigner.GetSwitchPageOfComponent(selectedComponent);

					if (
						switchPageOfComponent != null
						&& switchPageOfComponent.Parent == _switcher
						&& switchPageOfComponent == _switcher.SelectedSwitchPage
						)
					{
						flag = true;
						break;
					}
				}

				if (!flag)
				{
					service.SetSelectedComponents(new object[] { base.Component });
				}
			}
		}

		private NuGenSwitcher _switcher;

		/// <summary>
		/// Initializes a new instance of the <see cref="NuGenSwitcherDesigner"/> class.
		/// </summary>
		public NuGenSwitcherDesigner()
		{
		}

		/// <summary>
		/// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Design.ParentControlDesigner"></see>, and optionally releases the managed resources.
		/// </summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (_switcher != null)
				{
					_switcher.SelectedSwitchPageChanged -= _switcher_SelectedSwitchPageChanged;
				}

				ISelectionService selectionService = (ISelectionService)this.GetService(typeof(ISelectionService));

				if (selectionService != null)
				{
					selectionService.SelectionChanged -= _selectionService_SelectionChanged;
				}
			}

			base.Dispose(disposing);
		}
	}
}
