//Copyright (c) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.WindowsAPICodePack
{
    /// <summary>
    /// Defines event data associated with a HyperlinkClick event.
    /// </summary>
    public class TaskDialogHyperlinkClickedEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a new instance of this class with the specified link text.
        /// </summary>
        /// <param name="link">The text of the hyperlink that was clicked.</param>
        public TaskDialogHyperlinkClickedEventArgs(string link)
        {
            linkText = link;
        }
        
        private string linkText;
        /// <summary>
        /// Gets or sets the text of the hyperlink that was clicked.
        /// </summary>
        public string LinkText
        {
            get { return linkText; }
            set { linkText = value; }
        }
    }
}
