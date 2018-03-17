﻿using System;
using Foundation;
using AppKit;

namespace Carol.Views
{
    public partial class ErrorView : NSView
    {
        public static EventHandler RetryButtonClicked;
        #region Constructors

        // Called when created from unmanaged code
        public ErrorView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public ErrorView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
            ViewController.NetworkErrorOccurred += HandleNetworkError;
            ViewController.LyricsNotFoundOccurred += HandleLyricsNotFound;
        }

		#endregion

		partial void RetryButtonClick(NSObject sender)
		{
            RetryButtonClicked?.Invoke(this, null);
		}

        void HandleNetworkError(object sender, EventArgs e)
        {
            ErrorTextView.StringValue = "Looks like there is no internet connection.";
            RetryButton.Hidden = true;
        }

        void HandleLyricsNotFound(object sender, EventArgs e)
        {
            ErrorTextView.StringValue = "Could not find the lyrics of this song.";
        }
	}
}
