#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2019 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

#region Using Statements
using System;
using System.IO;
#endregion

namespace Microsoft.Xna.Framework
{
	/* System.IO.Directory replacements for exotic platforms (Android). */
	public static class FNADirectoryEXT
	{
		public static Func<string, bool> Exists;

		public static Action<string> Delete;

		public static Action<string> Create;

		public static Func<string, string, string[]> GetDirectories;

		public static Func<string, string, string[]> GetFiles;
	}
}