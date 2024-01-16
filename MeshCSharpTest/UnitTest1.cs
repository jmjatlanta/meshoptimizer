using MeshOptimizer;

 namespace MeshCSharpTest
{
	[TestClass]
	public class PInvokeCalls
	{
		[TestMethod]
		public void TestEncodeVertexIndexBound()
		{
			UInt64 testVal = MeshOpt.EncodeIndexBufferBound(10, 10);
			Assert.AreEqual<UInt64>(32, testVal);
		}

		[TestMethod]
		public void TestEncodeVertexBufferBound()
		{
			UInt64 testVal = MeshOpt.EncodeVertexBufferBound(10, 10);
			Assert.AreEqual<UInt64>(2633, testVal);
		}
	}
}
