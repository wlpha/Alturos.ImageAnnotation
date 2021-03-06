﻿using Alturos.ImageAnnotation.Helper;

namespace Alturos.ImageAnnotation.Model
{
    public class AnnotationPackageTransferProgress
    {
        public string CurrentFile { get; set; }
        public int CurrentFilePercentDone { get; set; }
        public int FileCount { get; set; }
        public int TransferedFiles { get; set; }

        public double GetPercentDone()
        {
            return ((this.TransferedFiles / (double)this.FileCount) * 100 + this.CurrentFilePercentDone / (double)this.FileCount)
                .Clamp(0, 100);
        }
    }
}
