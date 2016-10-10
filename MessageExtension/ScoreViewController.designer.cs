// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MessageExtension
{
    [Register ("ScoreViewController")]
    partial class ScoreViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FinalScoreLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PlayAgain { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PostScore { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FinalScoreLabel != null) {
                FinalScoreLabel.Dispose ();
                FinalScoreLabel = null;
            }

            if (PlayAgain != null) {
                PlayAgain.Dispose ();
                PlayAgain = null;
            }

            if (PostScore != null) {
                PostScore.Dispose ();
                PostScore = null;
            }
        }
    }
}