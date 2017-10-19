using System;
using Foundation;
using UIKit;
using UITextField_Shake;

// @interface Shake (UITextField)
[Category]
[BaseType (typeof(UITextField))]
interface UITextField_Shake
{
	// -(void)shake;
	[Export ("shake")]
	void Shake ();

	// -(void)shake:(int)times withDelta:(CGFloat)delta;
	[Export ("shake:withDelta:")]
	void Shake (int times, nfloat delta);

	// -(void)shake:(int)times withDelta:(CGFloat)delta completion:(void (^ _Nullable)(void))handler;
	[Export ("shake:withDelta:completion:")]
	void Shake (int times, nfloat delta, [NullAllowed] Action handler);

	// -(void)shake:(int)times withDelta:(CGFloat)delta speed:(NSTimeInterval)interval;
	[Export ("shake:withDelta:speed:")]
	void Shake (int times, nfloat delta, double interval);

	// -(void)shake:(int)times withDelta:(CGFloat)delta speed:(NSTimeInterval)interval completion:(void (^ _Nullable)(void))handler;
	[Export ("shake:withDelta:speed:completion:")]
	void Shake (int times, nfloat delta, double interval, [NullAllowed] Action handler);

	// -(void)shake:(int)times withDelta:(CGFloat)delta speed:(NSTimeInterval)interval shakeDirection:(ShakeDirection)shakeDirection;
	[Export ("shake:withDelta:speed:shakeDirection:")]
	void Shake (int times, nfloat delta, double interval, ShakeDirection shakeDirection);

	// -(void)shake:(int)times withDelta:(CGFloat)delta speed:(NSTimeInterval)interval shakeDirection:(ShakeDirection)shakeDirection completion:(void (^ _Nullable)(void))handler;
	[Export ("shake:withDelta:speed:shakeDirection:completion:")]
	void Shake (int times, nfloat delta, double interval, ShakeDirection shakeDirection, [NullAllowed] Action handler);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double UITextField_ShakeVersionNumber;
	[Field ("UITextField_ShakeVersionNumber", "__Internal")]
	double UITextField_ShakeVersionNumber { get; }

	// extern const unsigned char [] UITextField_ShakeVersionString;
	[Field ("UITextField_ShakeVersionString", "__Internal")]
	byte[] UITextField_ShakeVersionString { get; }
}
