// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace ModalPickerSample
{
	[Register ("ModalPickerSampleViewController")]
	partial class ModalPickerSampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CustomPickerButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton DatePickerButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel PickedLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CustomPickerButton != null) {
				CustomPickerButton.Dispose ();
				CustomPickerButton = null;
			}
			if (DatePickerButton != null) {
				DatePickerButton.Dispose ();
				DatePickerButton = null;
			}
			if (PickedLabel != null) {
				PickedLabel.Dispose ();
				PickedLabel = null;
			}
		}
	}
}
