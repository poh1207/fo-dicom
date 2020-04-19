﻿// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using System;

namespace FellowOakDicom.Imaging
{

    /// <summary>
    /// <seealso cref="DicomImage"/> operations related exceptions
    /// </summary>
    public class DicomImagingException : DicomException
    {
        /// <summary>
        /// Initialize new instance of <seealso cref="DicomImagingException"/> class
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public DicomImagingException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initialize new instance of <seealso cref="DicomImagingException"/> class
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="innerException">The exception that is the cause of the current exception</param>
        public DicomImagingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
