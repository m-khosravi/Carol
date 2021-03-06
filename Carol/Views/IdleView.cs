﻿using System;
using Foundation;
using AppKit;

namespace Carol.Views
{
    public partial class IdleView : NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public IdleView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public IdleView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

    }
}
