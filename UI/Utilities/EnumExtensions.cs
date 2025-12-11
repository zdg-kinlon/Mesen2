using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mesen.Utilities
{
	[SuppressMessage("Trimming", "IL2075:\'this\' argument does not satisfy \'DynamicallyAccessedMembersAttribute\' in call to target method. The return value of the source method does not have matching annotations.")]
	public static class EnumExtensions
	{
		public static T? GetAttribute<T>(this Enum val) where T : Attribute
		{
			return val.GetType().GetMember(val.ToString())[0].GetCustomAttribute<T>();
		}
	}
}
