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

namespace ImageMagick.Drawables
{
  ///<summary>
  /// Encapsulation of the DrawableCircle object.
  ///</summary>
  public interface IDrawableCircle : IDrawable
  {
    ///<summary>
    /// The origin X coordinate.
    ///</summary>
    double OriginX
    {
      get;
    }

    ///<summary>
    /// The origin X coordinate.
    ///</summary>
    double OriginY
    {
      get;
    }

    ///<summary>
    /// The perimeter X coordinate.
    ///</summary>
    double PerimeterX
    {
      get;
    }

    ///<summary>
    /// The perimeter X coordinate.
    ///</summary>
    double PerimeterY
    {
      get;
    }
  }
}