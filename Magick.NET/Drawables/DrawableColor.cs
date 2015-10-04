//=================================================================================================
// Copyright 2013-2015 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using ImageMagick.Drawables;

namespace ImageMagick
{
  ///<summary>
  /// Encapsulation of the DrawableColor object.
  ///</summary>
  public sealed class DrawableColor : IDrawableColor
  {
    ///<summary>
    /// Creates a new DrawableColor instance.
    ///</summary>
    ///<param name="x">The X coordinate.</param>
    ///<param name="y">The Y coordinate.</param>
    ///<param name="paintMethod">The paint method to use.</param>
    public DrawableColor(double x, double y, PaintMethod paintMethod)
    {
      X = x;
      Y = y;
      PaintMethod = paintMethod;
    }

    ///<summary>
    /// The PaintMethod to use.
    ///</summary>
    public PaintMethod PaintMethod
    {
      get;
      set;
    }

    ///<summary>
    /// The X coordinate.
    ///</summary>
    public double X
    {
      get;
      set;
    }

    ///<summary>
    /// The Y coordinate.
    ///</summary>
    public double Y
    {
      get;
      set;
    }
  }
}