# UITextFieldShaker

A Xamarin.iOS Binding implementation of the UITextField+Shaker extension.

<img src="https://i2.wp.com/alexdunndev.files.wordpress.com/2017/10/xamagonshake.png" width="200"/>

# Installation

Use NuGet!

```
Install-Package UITextFieldShaker
```
https://www.nuget.org/packages/UITextFieldShaker

# Usage

Simply include the namespace, and start calling `Shake()` on your `UITextFields`!

``` csharp
MyTextField.Shake();
```

There are a number of overloads to allow you to choose how many times it shakes, the delta between shakes, add an action when the shaking is done, choose the direction it shakes, and more.

``` csharp
void Shake();
void Shake(int times, nfloat delta);
void Shake(int times, nfloat delta, [NullAllowed] Action handler);
void Shake(int times, nfloat delta, double interval);
void Shake(int times, nfloat delta, double interval, Action handler);
void Shake(int times, nfloat delta, double interval, ShakeDirection shakeDirection);
void Shake(int times, nfloat delta, double interval, ShakeDirection shakeDirection, Action handler);
```

Start **Shaking**!

<img src="https://i2.wp.com/alexdunndev.files.wordpress.com/2017/10/uitextfieldshaker.gif" width="200"/>
