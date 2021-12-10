// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel, Workers = 0)]
