﻿//Copyright (c) Microsoft Corporation.  All rights reserved.

namespace Microsoft.WindowsAPICodePack.Shell
{
    internal static class ExplorerBrowserIIDGuid
    {
        static ExplorerBrowserIIDGuid()
        {
            // Private constructor to prevent the compiler from generating the default one.
        }

        // IID GUID strings for relevant Shell COM interfaces.
        internal const string IExplorerBrowser = "DFD3B6B5-C10C-4BE9-85F6-A66969F402F6";
        internal const string IKnownFolderManager = "8BE2D872-86AA-4d47-B776-32CCA40C7018";
        internal const string IFolderView = "cde725b0-ccc9-4519-917e-325d72fab4ce";
        internal const string IFolderView2 = "1af3a467-214f-4298-908e-06b03e0b39f9";
        internal const string ICommDlgBrowser = "000214F1-0000-0000-C000-000000000046";
        internal const string IServiceProvider = "6d5140c1-7436-11ce-8034-00aa006009fa";
        internal const string IExplorerPaneVisibility = "e07010ec-bc17-44c0-97b0-46c7c95b9edc";
        internal const string IExplorerBrowserEvents = "361bbdc7-e6ee-4e13-be58-58e2240c810f";
    }

    internal static class ExplorerBrowserViewPanes
    {
        static ExplorerBrowserViewPanes()
        {
            // Private constructor to prevent the compiler from generating the default one.
        }

        internal const string Navigation       = "cb316b22-25f7-42b8-8a09-540d23a43c2f";
        internal const string Commands         = "d9745868-ca5f-4a76-91cd-f5a129fbb076";
        internal const string CommandsOrganize = "72e81700-e3ec-4660-bf24-3c3b7b648806";
        internal const string CommandsView     = "21f7c32d-eeaa-439b-bb51-37b96fd6a943";
        internal const string Details          = "43abf98b-89b8-472d-b9ce-e69b8229f019";
        internal const string Preview          = "893c63d1-45c8-4d17-be19-223be71be365";
        internal const string Query            = "65bcde4f-4f07-4f27-83a7-1afca4df7ddd";
        internal const string AdvancedQuery    = "b4e9db8b-34ba-4c39-b5cc-16a1bd2c411c";
    }

    internal static class ExplorerBrowserCLSIDGuid
    {
        static ExplorerBrowserCLSIDGuid()
        {
            // Private constructor to prevent the compiler from generating the default one.
        }

        // CLSID GUID strings for relevant coclasses.
        internal const string ExplorerBrowser = "71F96385-DDD6-48D3-A0C1-AE06E8B055FB";
    }
}