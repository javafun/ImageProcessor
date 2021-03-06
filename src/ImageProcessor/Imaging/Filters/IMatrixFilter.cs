﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMatrixFilter.cs" company="James South">
//   Copyright (c) James South.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// <summary>
//   Defines properties and methods for ColorMatrix based filters.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ImageProcessor.Imaging.Filters
{
    #region Using
    using System.Drawing;
    using System.Drawing.Imaging;
    #endregion

    /// <summary>
    /// Defines properties and methods for ColorMatrix based filters.
    /// </summary>
    public interface IMatrixFilter
    {
        /// <summary>
        /// Gets the <see cref="T:System.Drawing.Imaging.ColorMatrix"/> for this filter instance.
        /// </summary>
        ColorMatrix Matrix { get; }

        #region Methods
        /// <summary>
        /// Processes the image.
        /// </summary>
        /// <param name="factory">
        /// The the current instance of the <see cref="T:ImageProcessor.ImageFactory"/> class containing
        /// the image to process.
        /// </param>
        /// <param name="image">The current image to process</param>
        /// <param name="newImage">The new Image to return</param>
        /// <returns>
        /// The processed image from the current instance of the <see cref="T:ImageProcessor.ImageFactory"/> class.
        /// </returns>
        Image TransformImage(ImageFactory factory, Image image, Image newImage);
        #endregion
    }
}
