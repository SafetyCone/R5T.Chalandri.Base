using System;


namespace R5T.Chalandri
{
    /// <summary>
    /// Provides the file paths of individual testing data files.
    /// </summary>
    public interface ITestingDataDirectoryContentPathsProvider
    {
        string GetBasicTextFilePath();

        // Visual Studio solution files.
        string GetNewVisualStudio2017SolutionFilePath();
        string GetNewVisualStudio2019SolutionFilePath();
        string GetExampleVisualStudioSolutionFilePath();

        // Visual Studio Project files.
        string GetExampleVisualStudioProjectFilePath01();
        string GetExampleVisualStudioProjectFilePath02();
    }
}
