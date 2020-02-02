using System;


namespace R5T.Chalandri
{
    public interface ITestingDataDirectoryContentPathsProvider
    {
        string GetBasicTextFilePath();

        string GetNewVisualStudio2017SolutionFilePath();
        string GetNewVisualStudio2019SolutionFilePath();
        string GetExampleVisualStudioSolutionFilePath();
    }
}
