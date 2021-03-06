﻿using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Xunit;

namespace Coverlet.Integration.Tests
{
    public class DotnetGlobalTools : BaseTest
    {
        private string InstallTool(string projectPath)
        {
            _ = DotnetCli($"tool install coverlet.console --version {GetPackageVersion("*console*.nupkg")} --tool-path \"{Path.Combine(projectPath, "coverletTool")}\"", out string standardOutput, out _, projectPath);
            Assert.Contains("was successfully installed.", standardOutput);
            return Path.Combine(projectPath, "coverletTool", "coverlet ");
        }

        [Fact]
        public void DotnetTool()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Disabled for the moment on unix system we get an exception(folder access denied) during tool installation
                return;
            }

            using ClonedTemplateProject clonedTemplateProject = CloneTemplateProject();
            UpdateNugeConfigtWithLocalPackageFolder(clonedTemplateProject.ProjectRootPath!);
            string coverletToolCommandPath = InstallTool(clonedTemplateProject.ProjectRootPath!);
            DotnetCli($"build {clonedTemplateProject.ProjectRootPath}", out string standardOutput, out string standardError);
            string publishedTestFile = clonedTemplateProject.GetFiles("*" + ClonedTemplateProject.AssemblyName + ".dll").Single(f => !f.Contains("obj"));
            RunCommand(coverletToolCommandPath, $"\"{publishedTestFile}\" --target \"dotnet\" --targetargs \"test {Path.Combine(clonedTemplateProject.ProjectRootPath, ClonedTemplateProject.ProjectFileName)} --no-build\"  --include-test-assembly --output \"{clonedTemplateProject.ProjectRootPath}\"\\", out standardOutput, out standardError);
            Assert.Contains("Test Run Successful.", standardOutput);
            AssertCoverage(clonedTemplateProject);
        }
    }
}
