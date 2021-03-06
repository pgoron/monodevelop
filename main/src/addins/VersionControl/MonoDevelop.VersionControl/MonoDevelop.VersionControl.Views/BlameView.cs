// 
// BlameView.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Ide;
using MonoDevelop.Core;
namespace MonoDevelop.VersionControl.Views
{
	internal class BlameView : BaseView, IAttachableViewContent 
	{
		BlameWidget widget;
		VersionControlDocumentInfo info;
		
		public override Gtk.Widget Control { 
			get {
				if (widget == null)
					widget = new BlameWidget (info);
				return widget;
			}
		}
		
		public static bool Show (VersionControlItemList items, bool test)
		{
			if (!test) {
				Show (items);
				return true;
			}
			else
				return items.Count > 0 && CanShow (items[0].Repository, items[0].Path);
		}
		
		public static void Show (VersionControlItemList items)
		{
			foreach (VersionControlItem item in items) {
				var document = IdeApp.Workbench.OpenDocument (item.Path);
				DiffView.AttachViewContents (document, item);
				document.Window.SwitchView (3);
			}
		}
		
		public static bool CanShow (Repository repo, FilePath file)
		{
			if (null != repo && repo.CanGetAnnotations (file)) 
				return true;
			return false;
		}
		
		
		public BlameView (VersionControlDocumentInfo info) : base ("Blame")
		{
			this.info = info;
			
		}
		
		#region IAttachableViewContent implementation
		public void Selected ()
		{
			info.Start ();
			widget.Editor.Caret.Location = info.Document.Editor.Caret.Location;
			widget.Editor.VAdjustment.Value = info.Document.Editor.VAdjustment.Value;
		}

		public void Deselected ()
		{
			info.Document.Editor.Caret.Location = widget.Editor.Caret.Location;
			info.Document.Editor.VAdjustment.Value = widget.Editor.VAdjustment.Value;
		}

		public void BeforeSave ()
		{
		}

		public void BaseContentChanged ()
		{
		}
		#endregion
	}
}

