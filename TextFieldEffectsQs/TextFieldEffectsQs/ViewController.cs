using System;
using TextFieldEffectsRaulriera;
using UIKit;
using CoreGraphics;
using Masonry;
using Foundation;

namespace Naxam.TextFieldEffectsQs
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        UIStackView _Stack;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var scroll = new UIScrollView();
            View.AddSubview(scroll);
            scroll.TranslatesAutoresizingMaskIntoConstraints = false;
			UIEdgeInsets padding = new UIEdgeInsets(20, 0, 0, 0);

			scroll.MakeConstraints(make => {
				make.Edges.EqualTo(View).Insets(padding);
			});

            var stack = new UIStackView()
            {
                Distribution = UIStackViewDistribution.EqualSpacing,
                Axis = UILayoutConstraintAxis.Vertical,
                Alignment = UIStackViewAlignment.Fill,
                Spacing = 12

            };
            {
                var label = new UILabel()
                {
                    Text = "Kaede",
                    BackgroundColor = UIColor.Black,
                    TextColor = UIColor.White
                };
                stack.AddArrangedSubview(label);
            }
            {
				var textField = new KaedeTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					ForegroundColor = UIColor.LightGray,
					Placeholder = "First name"
				};
                stack.AddArrangedSubview(textField);
                textField.MakeConstraints( (make) => {
                    make.Height.EqualTo(NSNumber.FromNFloat(30));
                });
            }
			{
				var textField = new KaedeTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					ForegroundColor = UIColor.LightGray,
					Placeholder = "Last name"
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(30));
				});
			}
			{
				var label = new UILabel()
				{
					Text = "Hoshi",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);
			}
			{
                var textField = new HoshiTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "First name",
                    BorderActiveColor = UIColor.Green,
                    BorderInactiveColor = UIColor.Blue,
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(50));
				});
			}
			{
				var textField = new HoshiTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "Last name",
					BorderActiveColor = UIColor.Green,
					BorderInactiveColor = UIColor.Blue,
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(50));
				});
			}
			{
				var label = new UILabel()
				{
					Text = "Jiro",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);
			}
			{
                var textField = new JiroTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "First name",
					BorderColor = UIColor.DarkGray,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(32));
				});
			}
			{
				var textField = new JiroTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "Last name",
                    BorderColor = UIColor.DarkGray,
                    TextColor = UIColor.White
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(32));
				});
			}
			{
				var label = new UILabel()
				{
					Text = "Isao",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);
			}
			{
                var textField = new IsaoTextField()
				{
                    ActiveColor = UIColor.Green,
                    InactiveColor = UIColor.Blue,
					Placeholder = "First name",
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}
			{
				var textField = new IsaoTextField()
				{
					ActiveColor = UIColor.Green,
					InactiveColor = UIColor.Blue,
					Placeholder = "Last name",
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}

			{
				var label = new UILabel()
				{
					Text = "Minoru",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);
			}
            {
				var textField = new MinoruTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "First name",
					TextColor = UIColor.Brown
				};
				stack.AddArrangedSubview(textField);
            }
			{
				var textField = new MinoruTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "Last name",
					TextColor = UIColor.Brown
				};
				stack.AddArrangedSubview(textField);
			}

			{
				var label = new UILabel()
				{
					Text = "Yoko",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);

			}
			{
                var textField = new YokoTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "First name",
                    ForegroundColor = UIColor.LightGray,
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}
			{
				var textField = new YokoTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "Last name",
					ForegroundColor = UIColor.LightGray,
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}

			{
				var label = new UILabel()
				{
					Text = "Madoka",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);

			}
			{
                var textField = new MadokaTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "First name",
                    BorderColor = UIColor.Red
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}
			{
				var textField = new MadokaTextField()
				{
					PlaceholderColor = UIColor.DarkGray,
					Placeholder = "Last name",
					BorderColor = UIColor.Red
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}

			{
				var label = new UILabel()
				{
					Text = "Akira",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);

			}
			{
                var textField = new AkiraTextField()
				{
					Placeholder = "First name",
					PlaceholderColor = UIColor.Red,
					BorderColor = UIColor.DarkGray,
                    TextColor = UIColor.DarkGray
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}
			{
                var textField = new AkiraTextField()
				{
					Placeholder = "Last name",
					PlaceholderColor = UIColor.Red,
					BorderColor = UIColor.DarkGray,
					TextColor = UIColor.DarkGray
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}

			{
				var label = new UILabel()
				{
					Text = "Yoshiko",
					BackgroundColor = UIColor.Black,
					TextColor = UIColor.White
				};
				stack.AddArrangedSubview(label);

			}
			{
                var textField = new YoshikoTextField()
				{
					Placeholder = "First name",
					PlaceholderColor = UIColor.DarkGray,
                    TextColor = UIColor.Purple,
					ActiveBorderColor = UIColor.Blue,
					InactiveBorderColor = UIColor.LightGray
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}
			{
                var textField = new YoshikoTextField()
				{
					Placeholder = "Last name",
					PlaceholderColor = UIColor.DarkGray,
					TextColor = UIColor.Purple,
                    ActiveBorderColor = UIColor.Blue,
                    InactiveBorderColor = UIColor.LightGray
				};
				stack.AddArrangedSubview(textField);
				textField.MakeConstraints((make) => {
					make.Height.EqualTo(NSNumber.FromNFloat(40));
				});
			}

            scroll.AddSubview(stack);
            stack.TranslatesAutoresizingMaskIntoConstraints = false;

            padding = new UIEdgeInsets(0, 8, 0, 8);
            stack.MakeConstraints(make => {
                make.Edges.EqualTo(scroll).Insets(padding);
                make.Width.EqualTo(scroll).Offset(-padding.Left - padding.Right);
			});

			_Stack = stack;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
        }
    }
}