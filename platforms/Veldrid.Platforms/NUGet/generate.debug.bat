
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.Core.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\netstandard2.0
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.Core.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\netstandard2.0
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.D3D11.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\netstandard2.0
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.D3D11.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\netstandard2.0

copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.Core.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\uap10.0
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.Core.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\uap10.0
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.D3D11.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\uap10.0
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.D3D11\netstandard2.0\Veldrid.D3D11.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\uap10.0

copy C:\Veldrid\veldrid\bin\Debug\Veldrid.Android\Veldrid.Core.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\MonoAndroid
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.Android\Veldrid.Core.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\MonoAndroid
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.Android\Veldrid.Android.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\MonoAndroid
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.Android\Veldrid.Android.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\MonoAndroid

copy C:\Veldrid\veldrid\bin\Debug\Veldrid.iOS\Veldrid.Core.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\Xamarin.iOS
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.iOS\Veldrid.Core.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\Xamarin.iOS
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.iOS\Veldrid.iOS.dll C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\Xamarin.iOS
copy C:\Veldrid\veldrid\bin\Debug\Veldrid.iOS\Veldrid.iOS.pdb C:\Veldrid\veldrid\platforms\Veldrid.Platforms\NUGet\Veldrid.Platforms\lib\Xamarin.iOS

pause

nuget pack Veldrid.Platforms\Veldrid.Platforms.nuspec

copy Veldrid.Platforms.*.nupkg c:\NUget

pause

