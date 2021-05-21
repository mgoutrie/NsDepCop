﻿using Codartis.NsDepCop.Interface.Analysis;

namespace Codartis.NsDepCop.Factory
{
    /// <summary>
    /// Creates dependency analyzer objects.
    /// </summary>
    public interface IDependencyAnalyzerFactory
    {
        IDependencyAnalyzer Create(string folderPath, ITypeDependencyEnumerator typeDependencyEnumerator);
    }
}