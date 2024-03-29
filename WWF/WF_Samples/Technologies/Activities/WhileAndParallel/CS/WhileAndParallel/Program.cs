﻿//---------------------------------------------------------------------
//  This file is part of the Windows Workflow Foundation SDK Code Samples.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
// 
//This source code is intended only as a supplement to Microsoft
//Development Tools and/or on-line documentation.  See these other
//materials for detailed information regarding Microsoft code samples.
// 
//THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//PARTICULAR PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Threading;
using System.Workflow.Runtime;

namespace Microsoft.Samples.Workflow.WhileAndParallel
{
    class Program
    {
        static AutoResetEvent waitHandle = new AutoResetEvent(false);

        static void Main()
        {
            // Start the engine.
            using (WorkflowRuntime workflowRuntime = new WorkflowRuntime())
            {
                workflowRuntime.StartRuntime();

                workflowRuntime.WorkflowCompleted += OnWorkflowCompletion;
                workflowRuntime.WorkflowTerminated += OnWorkflowTerminated;

                // Load the workflow type.
                workflowRuntime.CreateWorkflow(typeof(WhileAndParallelWorkflow)).Start();
                Console.WriteLine("Workflow Started.");

                waitHandle.WaitOne();

                workflowRuntime.StopRuntime();
                Console.WriteLine("Program Complete.");
            }
        }

        static void OnWorkflowCompletion(object sender, WorkflowCompletedEventArgs instance)
        {
            waitHandle.Set();
        }

        static void OnWorkflowTerminated(object sender, WorkflowTerminatedEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
            waitHandle.Set();
        }
    }
}
