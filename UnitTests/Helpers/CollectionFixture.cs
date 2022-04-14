using System;
using Xunit;

namespace UnitTests.Helpers
{
	[CollectionDefinition("Our Test Collection #1")]
	public class CollectionFixture : ICollectionFixture<WebClient>
	{
		// This class has no code, and is never created. Its purpose is simply
		// to be the place to apply [CollectionDefinition] and all the
		// ICollectionFixture<> interfaces.
	}
}

