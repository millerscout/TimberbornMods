using Timberborn.CommandLine;
using Timberborn.SingletonSystem;

namespace Timberborn.Benchmarking
{
	internal class BenchmarkStarter : ILoadableSingleton
	{
		private static readonly string BenchmarkLengthKey = "benchmarkLength";

		private static readonly string BenchmarkSpeedKey = "benchmarkSpeed";

		private static readonly string BenchmarkWarmUpLengthKey = "benchmarkWarmUpLength";

		private static readonly string BenchmarkSaveCountKey = "benchmarkSaveCount";

		private readonly ICommandLineArguments _commandLineArguments;

		private readonly Benchmarker _benchmarker;

		private readonly SavingBenchmarker _savingBenchmarker;

		public BenchmarkStarter(ICommandLineArguments commandLineArguments, Benchmarker benchmarker, SavingBenchmarker savingBenchmarker)
		{
			_commandLineArguments = commandLineArguments;
			_benchmarker = benchmarker;
			_savingBenchmarker = savingBenchmarker;
		}

		public void Load()
		{
			StartBenchmark();
		}

		private void StartBenchmark()
		{
			if (_commandLineArguments.Has(BenchmarkLengthKey) && _commandLineArguments.Has(BenchmarkSpeedKey))
			{
				int @int = _commandLineArguments.GetInt(BenchmarkLengthKey);
				int int2 = _commandLineArguments.GetInt(BenchmarkSpeedKey);
				int int3 = _commandLineArguments.GetInt(BenchmarkWarmUpLengthKey);
				_benchmarker.StartBenchmark(@int, int3, int2);
			}
			else if (_commandLineArguments.Has(BenchmarkSaveCountKey))
			{
				int int4 = _commandLineArguments.GetInt(BenchmarkWarmUpLengthKey);
				int int5 = _commandLineArguments.GetInt(BenchmarkSaveCountKey);
				_savingBenchmarker.StartBenchmark(int4, int5);
			}
		}
	}
}
