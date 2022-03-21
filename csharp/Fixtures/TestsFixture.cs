using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Fixtures
{
	public class TestsFixture : IDisposable
	{
		private bool disposedValue;

		private readonly Random random;
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects)
				}

				// TODO: free unmanaged resources (unmanaged objects) and override finalizer
				// TODO: set large fields to null
				disposedValue = true;
			}
		}

		public TestsFixture()
		{

			random = new Random();
		}




		public IEnumerable<double> GeneateRandomNumbers(int maxValue=100, int totalNumbers=100)
		{
			
			for (var i = 0; i < totalNumbers; i++)
				yield return random.NextDouble() * maxValue;

		}
		// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
		// ~TestsFixture()
		// {
		//     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		//     Dispose(disposing: false);
		// }

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
