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
	/* System.IO.File replacements for exotic platforms (Android). */
	public static class FNAFileEXT
	{
		public static Func<string, bool> Exists;

		public static Action<string> Delete;

		public static Func<string, FileMode, FileAccess, FileShare, Stream> Open;

		#region Internal Methods

		internal static void WriteAllText(string path, string text)
		{
			using (Stream stream = Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
			using (StreamWriter writer = new StreamWriter(stream))
			{
				writer.Write(text);
			}
		}

		internal static byte[] ReadAllBytes(string path)
		{
			using (Stream stream = Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (MemoryStream ms = new MemoryStream())
			{
				stream.CopyTo(ms);
				return ms.ToArray();
			}
		}

		#endregion
	}
}