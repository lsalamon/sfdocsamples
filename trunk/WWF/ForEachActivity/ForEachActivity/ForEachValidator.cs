//---------------------------------------------------------------------
//  This file is part of the WindowsWorkflow.NET web site samples.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
// 
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
// 
//  THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//---------------------------------------------------------------------


using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Drawing;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Compiler;

namespace ForEachActivity
{
    #region ForEach Validatir
    internal sealed class ForEachValidator : CompositeActivityValidator
    {
        private const int InvalidNumberOfChildren = 100;

        /// <summary>
        ///	Overridden to validate the activity properties and populate the error collection.
        /// Only one child activity is allowed.  If multiple acitivties need to be executed,
        /// place them in a sequence or other appropriate composite activities.
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override ValidationErrorCollection Validate(ValidationManager manager, object obj)
        {
            ValidationErrorCollection validationErrors = new ValidationErrorCollection(base.Validate(manager, obj));

            ForEach foreachActivity = obj as ForEach;
            if (foreachActivity == null)
                throw new ArgumentException("Validate parameter 'obj' is not a ForEach activity.");

            if (foreachActivity.EnabledActivities.Count > 1)
                validationErrors.Add(new ValidationError("Only one child is allowed in the ForEach activity.", InvalidNumberOfChildren));

            return validationErrors;
        }
    }
    #endregion
}