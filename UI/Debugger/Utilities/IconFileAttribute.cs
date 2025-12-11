using System;
using System.Diagnostics.CodeAnalysis;

namespace Mesen.Debugger.Utilities
{
	public class IconFileAttribute : Attribute
	{
		public string Icon { get; }
		public IconFileAttribute(string icon)
		{
			Icon = "Assets/" + icon + ".png";
		}
	}
}