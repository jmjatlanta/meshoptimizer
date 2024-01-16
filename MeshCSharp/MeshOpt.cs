using System;
using System.Runtime.InteropServices;

namespace MeshOptimizer
{
	public static class MeshOpt
	{
		[DllImport(@"meshoptimizer.dll")]
		private static extern UInt64 meshopt_encodeVertexBufferBound(UInt64 vertex_count, UInt64 vertex_size);
		public static UInt64 EncodeVertexBufferBound(UInt64 vertex_count, UInt64 vertex_size)
		{
			return meshopt_encodeVertexBufferBound(vertex_count, vertex_size);
		}

		[DllImport(@"meshoptimizer.dll")]
		private static extern UInt64 meshopt_encodeVertexBuffer(byte[] buffer, UInt64 buffer_size, byte[] vertices, UInt64 vertex_count, UInt64 vertex_size);
		public static UInt64 EncodeVertexBuffer(byte[] buffer, UInt64 buffer_size, byte[] vertices, UInt64 vertex_count, UInt64 vertex_size)
		{
			return meshopt_encodeVertexBuffer(buffer, buffer_size, vertices, vertex_count, vertex_size);
		}

		[DllImport(@"meshoptimizer.dll")]
		private static extern Int64 meshopt_decodeVertexBuffer(UIntPtr destination, UInt64 vertex_count, UInt64 vertex_size, byte[] buffer, UInt64 buffer_size);
		public static Int64 DecodeVertexBuffer(UIntPtr destination, UInt64 vertex_count, UInt64 vertex_size, byte[] buffer, UInt64 buffer_size)
		{
			return meshopt_decodeVertexBuffer(destination, vertex_count, vertex_size, buffer, buffer_size);
		}

		[DllImport(@"meshoptimizer.dll")]
		private static extern UInt64 meshopt_encodeIndexBufferBound(UInt64 index_count, UInt64 vertex_count);
		public static UInt64 EncodeIndexBufferBound(UInt64 index_count, UInt64 vertex_count)
		{
			return meshopt_encodeIndexBufferBound(index_count, vertex_count);
		}

		[DllImport(@"meshoptimizer.dll")]
		private static extern UInt64 meshopt_encodeIndexBuffer(byte[] buffer, UInt64 buffer_size, UIntPtr indices, UInt64 index_count);
		public static UInt64 EncodeIndexBuffer(byte[] buffer, UInt64 buffer_size, UIntPtr indices, UInt64 index_count)
		{
			return meshopt_encodeIndexBuffer(buffer, buffer_size, indices, index_count);
		}

		[DllImport(@"meshoptimizer.dll")]
		private static extern UInt64 meshopt_decodeIndexBuffer(UIntPtr destination, UInt64 index_count, UInt64 index_size, byte[] buffer, UInt64 buffer_size);
		public static UInt64 DecodeIndexBuffer(UIntPtr destination, UInt64 index_count, UInt64 index_size, byte[] buffer, UInt64 buffer_size)
		{
			return meshopt_decodeIndexBuffer(destination, index_count, index_size, buffer, buffer_size);
		}
	}
}
