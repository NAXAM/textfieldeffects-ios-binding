using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace TextFieldEffectsRaulriera
{
	// @interface TextFieldEffects : UITextField
	[BaseType(typeof(UITextField), Name = "_TtC16TextFieldEffects16TextFieldEffects")]
	interface TextFieldEffects
	{
		// @property (readonly, nonatomic, strong) UILabel * _Nonnull placeholderLabel;
		[Export("placeholderLabel", ArgumentSemantic.Strong)]
		UILabel PlaceholderLabel { get; }

		//// -(void)animateViewsForTextEntry;
		//[Export("animateViewsForTextEntry")]
		//void AnimateViewsForTextEntry();

		//// -(void)animateViewsForTextDisplay;
		//[Export("animateViewsForTextDisplay")]
		//void AnimateViewsForTextDisplay();

		//// -(void)drawViewsForRect:(CGRect)rect;
		//[Export("drawViewsForRect:")]
		//void DrawViewsForRect(CGRect rect);

		//// -(void)updateViewsForBoundsChange:(CGRect)bounds;
		//[Export("updateViewsForBoundsChange:")]
		//void UpdateViewsForBoundsChange(CGRect bounds);

		//// -(void)drawRect:(CGRect)rect;
		//[Export("drawRect:")]
		//void DrawRect(CGRect rect);

		//// -(void)drawPlaceholderInRect:(CGRect)rect;
		//[Export("drawPlaceholderInRect:")]
		//void DrawPlaceholderInRect(CGRect rect);

		//// @property (copy, nonatomic) NSString * _Nullable text;
		//[NullAllowed, Export("text")]
		//string Text { get; set; }

		//// -(void)willMoveToSuperview:(UIView * _Null_unspecified)newSuperview;
		//[Export("willMoveToSuperview:")]
		//void WillMoveToSuperview(UIView newSuperview);

		//// -(void)textFieldDidBeginEditing;
		//[Export("textFieldDidBeginEditing")]
		//void TextFieldDidBeginEditing();

		//// -(void)textFieldDidEndEditing;
		//[Export("textFieldDidEndEditing")]
		//void TextFieldDidEndEditing();

		//// -(void)prepareForInterfaceBuilder;
		//[Export("prepareForInterfaceBuilder")]
		//void PrepareForInterfaceBuilder();

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface AkiraTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects), Name = "_TtC16TextFieldEffects14AkiraTextField")]
	interface AkiraTextField
	{
		// @property (nonatomic, strong) UIColor * _Nullable borderColor;
		[NullAllowed, Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		//// @property (nonatomic) CGRect bounds;
		//[Export("bounds", ArgumentSemantic.Assign)]
		//CGRect Bounds { get; set; }

		//// -(void)drawViewsForRect:(CGRect)rect;
		//[Export("drawViewsForRect:")]
		//void DrawViewsForRect(CGRect rect);

		//// -(void)animateViewsForTextEntry;
		//[Export("animateViewsForTextEntry")]
		//void AnimateViewsForTextEntry();

		//// -(void)animateViewsForTextDisplay;
		//[Export("animateViewsForTextDisplay")]
		//void AnimateViewsForTextDisplay();

		//// -(CGRect)placeholderRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		//[Export("placeholderRectForBounds:")]
		//CGRect PlaceholderRectForBounds(CGRect bounds);

		//// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		//[Export("editingRectForBounds:")]
		//CGRect EditingRectForBounds(CGRect bounds);

		//// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		//[Export("textRectForBounds:")]
		//CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface HoshiTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects), Name = "_TtC16TextFieldEffects14HoshiTextField")]
	interface HoshiTextField
	{
		// @property (nonatomic, strong) UIColor * _Nullable borderInactiveColor;
		[NullAllowed, Export("borderInactiveColor", ArgumentSemantic.Strong)]
		UIColor BorderInactiveColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable borderActiveColor;
		[NullAllowed, Export("borderActiveColor", ArgumentSemantic.Strong)]
		UIColor BorderActiveColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		//// @property (nonatomic) CGRect bounds;
		//[Export("bounds", ArgumentSemantic.Assign)]
		//CGRect Bounds { get; set; }

		//// -(void)drawViewsForRect:(CGRect)rect;
		//[Export("drawViewsForRect:")]
		//void DrawViewsForRect(CGRect rect);

		//// -(void)animateViewsForTextEntry;
		//[Export("animateViewsForTextEntry")]
		//void AnimateViewsForTextEntry();

		//// -(void)animateViewsForTextDisplay;
		//[Export("animateViewsForTextDisplay")]
		//void AnimateViewsForTextDisplay();

		//// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		//[Export("editingRectForBounds:")]
		//CGRect EditingRectForBounds(CGRect bounds);

		//// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		//[Export("textRectForBounds:")]
		//CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface IsaoTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects), Name = "_TtC16TextFieldEffects13IsaoTextField")]
	interface IsaoTextField
	{
		// @property (nonatomic, strong) UIColor * _Nullable inactiveColor;
		[NullAllowed, Export("inactiveColor", ArgumentSemantic.Strong)]
		UIColor InactiveColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable activeColor;
		[NullAllowed, Export("activeColor", ArgumentSemantic.Strong)]
		UIColor ActiveColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(void)drawViewsForRect:(CGRect)rect;
		[Export("drawViewsForRect:")]
		void DrawViewsForRect(CGRect rect);

		// -(void)animateViewsForTextEntry;
		[Export("animateViewsForTextEntry")]
		void AnimateViewsForTextEntry();

		// -(void)animateViewsForTextDisplay;
		[Export("animateViewsForTextDisplay")]
		void AnimateViewsForTextDisplay();

		// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("editingRectForBounds:")]
		CGRect EditingRectForBounds(CGRect bounds);

		// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("textRectForBounds:")]
		CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface JiroTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects), Name = "_TtC16TextFieldEffects13JiroTextField")]
	interface JiroTextField
	{
		// @property (nonatomic, strong) UIColor * _Nullable borderColor;
		[NullAllowed, Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		//// @property (nonatomic) CGRect bounds;
		//[Export("bounds", ArgumentSemantic.Assign)]
		//CGRect Bounds { get; set; }

		//// -(void)drawViewsForRect:(CGRect)rect;
		//[Export("drawViewsForRect:")]
		//void DrawViewsForRect(CGRect rect);

		//// -(void)animateViewsForTextEntry;
		//[Export("animateViewsForTextEntry")]
		//void AnimateViewsForTextEntry();

		//// -(void)animateViewsForTextDisplay;
		//[Export("animateViewsForTextDisplay")]
		//void AnimateViewsForTextDisplay();

		//// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		//[Export("editingRectForBounds:")]
		//CGRect EditingRectForBounds(CGRect bounds);

		//// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		//[Export("textRectForBounds:")]
		//CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface KaedeTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects),Name = "_TtC16TextFieldEffects14KaedeTextField")]
	interface KaedeTextField
	{
		// @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
		[NullAllowed, Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable foregroundColor;
		[NullAllowed, Export("foregroundColor", ArgumentSemantic.Strong)]
		UIColor ForegroundColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(void)drawViewsForRect:(CGRect)rect;
		[Export("drawViewsForRect:")]
		void DrawViewsForRect(CGRect rect);

		// -(void)animateViewsForTextEntry;
		[Export("animateViewsForTextEntry")]
		void AnimateViewsForTextEntry();

		// -(void)animateViewsForTextDisplay;
		[Export("animateViewsForTextDisplay")]
		void AnimateViewsForTextDisplay();

		// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("editingRectForBounds:")]
		CGRect EditingRectForBounds(CGRect bounds);

		// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("textRectForBounds:")]
		CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface MadokaTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects),Name = "_TtC16TextFieldEffects15MadokaTextField")]
	interface MadokaTextField
	{
		// @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable borderColor;
		[NullAllowed, Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(void)drawViewsForRect:(CGRect)rect;
		[Export("drawViewsForRect:")]
		void DrawViewsForRect(CGRect rect);

		// -(void)animateViewsForTextEntry;
		[Export("animateViewsForTextEntry")]
		void AnimateViewsForTextEntry();

		// -(void)animateViewsForTextDisplay;
		[Export("animateViewsForTextDisplay")]
		void AnimateViewsForTextDisplay();

		// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("editingRectForBounds:")]
		CGRect EditingRectForBounds(CGRect bounds);

		// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("textRectForBounds:")]
		CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface MinoruTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects),Name = "_TtC16TextFieldEffects15MinoruTextField")]
	interface MinoruTextField
	{
		// @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(void)drawViewsForRect:(CGRect)rect;
		[Export("drawViewsForRect:")]
		void DrawViewsForRect(CGRect rect);

		// -(void)animateViewsForTextEntry;
		[Export("animateViewsForTextEntry")]
		void AnimateViewsForTextEntry();

		// -(void)animateViewsForTextDisplay;
		[Export("animateViewsForTextDisplay")]
		void AnimateViewsForTextDisplay();

		// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("editingRectForBounds:")]
		CGRect EditingRectForBounds(CGRect bounds);

		// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("textRectForBounds:")]
		CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface YokoTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects), Name = "_TtC16TextFieldEffects13YokoTextField")]
	interface YokoTextField
	{
		// @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
		[NullAllowed, Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull foregroundColor;
		[Export("foregroundColor", ArgumentSemantic.Strong)]
		UIColor ForegroundColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(void)drawViewsForRect:(CGRect)rect;
		[Export("drawViewsForRect:")]
		void DrawViewsForRect(CGRect rect);

		// -(void)animateViewsForTextEntry;
		[Export("animateViewsForTextEntry")]
		void AnimateViewsForTextEntry();

		// -(void)animateViewsForTextDisplay;
		[Export("animateViewsForTextDisplay")]
		void AnimateViewsForTextDisplay();

		// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("editingRectForBounds:")]
		CGRect EditingRectForBounds(CGRect bounds);

		// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("textRectForBounds:")]
		CGRect TextRectForBounds(CGRect bounds);

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface YoshikoTextField : TextFieldEffects
    [BaseType(typeof(TextFieldEffects), Name = "_TtC16TextFieldEffects16YoshikoTextField")]
	interface YoshikoTextField
	{
		// @property (nonatomic) CGFloat borderSize;
		[Export("borderSize")]
		nfloat BorderSize { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull activeBorderColor;
		[Export("activeBorderColor", ArgumentSemantic.Strong)]
		UIColor ActiveBorderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull inactiveBorderColor;
		[Export("inactiveBorderColor", ArgumentSemantic.Strong)]
		UIColor InactiveBorderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull activeBackgroundColor;
		[Export("activeBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ActiveBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic) CGFloat placeholderFontScale;
		[Export("placeholderFontScale")]
		nfloat PlaceholderFontScale { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export("placeholder")]
		string Placeholder { get; set; }

		// -(void)animateViewsForTextEntry;
		[Export("animateViewsForTextEntry")]
		void AnimateViewsForTextEntry();

		// -(void)animateViewsForTextDisplay;
		[Export("animateViewsForTextDisplay")]
		void AnimateViewsForTextDisplay();

		// @property (nonatomic) CGRect bounds;
		[Export("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(void)drawViewsForRect:(CGRect)rect;
		[Export("drawViewsForRect:")]
		void DrawViewsForRect(CGRect rect);

		// -(CGRect)placeholderRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("placeholderRectForBounds:")]
		CGRect PlaceholderRectForBounds(CGRect bounds);

		// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("editingRectForBounds:")]
		CGRect EditingRectForBounds(CGRect bounds);

		// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result));
		[Export("textRectForBounds:")]
		CGRect TextRectForBounds(CGRect bounds);

		// -(void)prepareForInterfaceBuilder;
		[Export("prepareForInterfaceBuilder")]
		void PrepareForInterfaceBuilder();

		//// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		//[Export("initWithFrame:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(CGRect frame);

		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}
}
