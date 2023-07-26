﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using System.Reflection;
using Azure.Test.Perf;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

//if (!args.Contains("--bm"))
//    await PerfProgram.Main(Assembly.GetExecutingAssembly(), args);

// To run Benchmark.NET benchmarks, use the --bm flag.

// To see the list of benchmarks that can be run
// dotnet run -c Release --framework net6.0 --bm --list flat

// To run a specific benchmark class
// dotnet run -c Release --framework net6.0 --bm --filter Azure.Core.Perf.SerializationBenchmark*

// To run a specific benchmark method
// dotnet run -c Release --framework net6.0 --bm --filter *SerializationBenchmark.Deserialize_PublicInterface
// or
// dotnet run -c Release --framework net6.0 --bm --filter Azure.Core.Perf.SerializationBenchmark.Deserialize_PublicInterface

// To run a specific benchmark class and category
// dotnet run -c Release --framework net6.0 --bm --anyCategories PublicInterface --filter Azure.Core.Perf.SerializationBenchmark*

//var config = ManualConfig.Create(DefaultConfig.Instance);
//config.Options = ConfigOptions.JoinSummary | ConfigOptions.StopOnFirstError;
//BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args.Where(a => !a.Equals("--bm")).ToArray(), config);

BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());
