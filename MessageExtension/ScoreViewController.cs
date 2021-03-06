using System;
using Messages;
using UIKit;

namespace MessageExtension
{
	public partial class ScoreViewController : MSMessagesAppViewController
	{
		public int finalScore = 0;
		public MSConversation conversation;

		protected ScoreViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			FinalScoreLabel.Text = string.Format("You scored {0}!", finalScore);

			// Set up the message layout
			MSMessageTemplateLayout layout = new MSMessageTemplateLayout()
			{
				Image = UIImage.FromBundle("Monkey"),
				Caption = "Try and beat my score!",
				TrailingCaption = "" + finalScore,
				Subcaption = "MonkeyTap"
			};

			// Create a new message with the above layout
			MSMessage message = new MSMessage()
			{
				Layout = layout
			};

			// Send the message when the button is tapped
			PostScore.TouchUpInside += (sender, e) =>
			{
				conversation.InsertMessage(message, (Foundation.NSError error) =>
				{
					if (error == null)
					{
						// Handle successful send
					}
					else {
						// Report Error
						Console.WriteLine("Error: {0}", error);
					}
				});
			};

			PlayAgain.TouchUpInside += (sender, e) =>
			{
				DismissViewController(true, null);
			};
		}

		public override void DidBecomeActive(MSConversation conversation)
		{
			base.DidBecomeActive(conversation);

			// Called when the extension is about to move from the inactive to active state.
			// This will happen when the extension is about to present UI.

			// Use this method to configure the extension and restore previously stored state.
		}

		public override void WillResignActive(MSConversation conversation)
		{
			base.WillResignActive(conversation);

			// Called when the extension is about to move from the active to inactive state.
			// This will happen when the user dissmises the extension, changes to a different
			// conversation or quits Messages.

			// Use this method to release shared resources, save user data, invalidate timers,
			// and store enough state information to restore your extension to its current state
			// in case it is terminated later.
		}

		public override void DidReceiveMessage(MSMessage message, MSConversation conversation)
		{
			base.DidReceiveMessage(message, conversation);

			// Called when a message arrives that was generated by another instance of this
			// extension on a remote device.

			// Use this method to trigger UI updates in response to the message.
		}

		public override void DidStartSendingMessage(MSMessage message, MSConversation conversation)
		{
			base.DidStartSendingMessage(message, conversation);

			// Called when the user taps the send button.
		}

		public override void DidCancelSendingMessage(MSMessage message, MSConversation conversation)
		{
			base.DidCancelSendingMessage(message, conversation);

			// Called when the user deletes the message without sending it.

			// Use this to clean up state related to the deleted message.
		}

		public override void WillTransition(MSMessagesAppPresentationStyle presentationStyle)
		{
			base.WillTransition(presentationStyle);

			// Called before the extension transitions to a new presentation style.

			// Use this method to prepare for the change in presentation style.
		}

		public override void DidTransition(MSMessagesAppPresentationStyle presentationStyle)
		{
			base.DidTransition(presentationStyle);

			// Called after the extension transitions to a new presentation style.

			// Use this method to finalize any behaviors associated with the change in presentation style.
		}
	}
}