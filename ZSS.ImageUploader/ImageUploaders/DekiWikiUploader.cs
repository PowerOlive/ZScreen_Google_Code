﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ZSS.ImageUploaderLib.Helpers;

namespace ZSS.ImageUploaderLib
{
    public sealed class DekiWikiUploader : IUploader
    {
        private DekiWikiAccount mAccount;
        private List<string> Errors { get; set; }
        public string Name { get; private set; }
        public string WorkingDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public DekiWikiUploader(DekiWikiAccount acc)
        {
            this.mAccount = acc;
            this.Errors = new List<string>();
            this.Name = mAccount.Name;
        }

        public ImageFileManager UploadImage(string localFilePath)
        {
            // Create a new ImageFile List
            List<ImageFile> ifl = new List<ImageFile>();

            // Create the connector
            DekiWiki connector = new DekiWiki(ref this.mAccount);

            // Get the file name to save
            string fName = Path.GetFileName(localFilePath);

            // Upload the image
            connector.UploadImage(localFilePath, fName);

            // Add this to the list of uploaded images
            ifl.Add(new ImageFile(this.mAccount.getUriPath(fName), ImageFile.ImageType.FULLIMAGE));

            // Create the file manager object
            ImageFileManager ifm = new ImageFileManager(ifl) { LocalFilePath = localFilePath };

            return ifm;
        }

        public string ToErrorString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string err in this.Errors)
            {
                sb.AppendLine(err);
            }
            return sb.ToString();
        }
    }
}