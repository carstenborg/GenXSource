/* -----------------------------------------------
 * NuGenMultilineEditor.cs
 * Copyright � 2006 Anthony Nystrom
 * mailto:a.nystrom@genetibase.com
 * --------------------------------------------- */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Genetibase.Shared.Design
{
	/// <summary>
	/// Represents a multiline text editor UI.
	/// </summary>
	public sealed class NuGenMultilineEditor : UITypeEditor
	{
		#region Methods.Public.Overridden

		/// <summary>
		/// Edits the specified object's value using the editor style
		/// indicated by <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle"/>.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
		/// <param name="provider">An <see cref="T:System.IServiceProvider"/> that this editor can use to obtain services.</param>
		/// <param name="value">The object to edit.</param>
		/// <returns>The new value of the object.</returns>
		/// <exception cref="ArgumentNullException">
		/// <para><paramref name="provider"/> is <see langword="null"/>.</para>
		/// </exception>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}

			string strValue = value as string;

			if (strValue == null)
			{
				return value;
			}

			IWindowsFormsEditorService editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
			
			if (editorService != null)
			{
				NuGenMultilineEditorUI multilineEditor = new NuGenMultilineEditorUI(strValue);
				editorService.DropDownControl(multilineEditor);
				return multilineEditor.GetValue;
			}

			return value;
		}

		/// <summary>
		/// Gets the editor style used by the <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)"/> method.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
		/// <returns>
		/// A <see cref="T:System.Drawing.Design.UITypeEditorEditStyle"/> value that
		/// indicates the style of editor used by <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)"/>. If the <see cref="T:System.Drawing.Design.UITypeEditor"/> does not support this
		/// method, then <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle"/> will return <see cref="F:System.Drawing.Design.UITypeEditorEditStyle.None"/>.
		/// </returns>
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.DropDown;
		}

		/// <summary>
		/// Indicates whether the specified context supports painting a representation of an object's value
		/// within the specified context.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
		/// <returns>
		/// 	<see langword="true"/>
		/// if <see cref="M:System.Drawing.Design.UITypeEditor.PaintValue(System.Object,System.Drawing.Graphics,System.Drawing.Rectangle)"/> is implemented; otherwise, <see langword="false"/>.
		/// </returns>
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		#endregion

		#region Constructors
	
		/// <summary>
		/// Initializes a new instance of the <see cref="NuGenMultilineEditor"/> class.
		/// </summary>
		public NuGenMultilineEditor()
		{
		}
		
		#endregion
	}
}