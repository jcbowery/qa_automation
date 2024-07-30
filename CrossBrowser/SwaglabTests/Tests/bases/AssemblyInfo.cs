// Make all tests in the test assembly run in parallel
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(2)]
public class AssemblyInfo{}